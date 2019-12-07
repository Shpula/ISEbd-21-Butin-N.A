﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsSamosval
{
    /// <summary>
    /// Класс-хранидище парковок
    /// </summary>
    public class MultiLevelParking
    {
        /// <summary>
        /// Список с уровнями парковки
        /// </summary>
        List<Parking<ITransport>> parkingStages;
        private int pictureHeight;
        private int pictureWidth;

        /// <summary>
        /// Сколько мест на каждом уровне
        /// </summary>

        private const int countPlaces = 20;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="countStages">Количество уровенй парковки</param>
        /// <param name="pictureWidth"></param>
        /// <param name="pictureHeight"></param>
        public MultiLevelParking(int countStages, int pictureWidth, int pictureHeight)
        {
            parkingStages = new List<Parking<ITransport>>();
            for (int i = 0; i < countStages; ++i)
            {
                parkingStages.Add(new Parking<ITransport>(countPlaces, pictureWidth,
               pictureHeight));
            }
        }
        /// <summary>
        /// Индексатор
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns>
        public Parking<ITransport> this[int ind]
        {
            get
            {
                if (ind > -1 && ind < parkingStages.Count)
                {
                    return parkingStages[ind];
                }
                return null;
            }
        }
        /// <summary>
        /// Сохранение информации по автомобилям на парковках в файл
        /// </summary>
        /// <param name="filename">Путь и имя файла</param>
        /// <returns></returns>
        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                //Записываем количество уровней
                WriteToFile("CountLeveles:" + parkingStages.Count +
               Environment.NewLine, fs);
                foreach (var level in parkingStages)
                {
                    //Начинаем уровень
                    WriteToFile("Level" + Environment.NewLine, fs);
                    for (int i = 0; i < countPlaces; i++)
                    {
                        var car = level[i];
                        if (car != null)
                        {
                            //если место не пустое
                            //Записываем тип мшаины
                            if (car.GetType().Name == "Car")
                            {
                                WriteToFile(i + ":Car:", fs);
                            }
                            if (car.GetType().Name == "SportCar")
                            {
                                WriteToFile(i + ":SportCar:", fs);
                            }
                            //Записываемые параметры
                            WriteToFile(car + Environment.NewLine, fs);
                        }
                    }
                }
            }
            return true;
        }
        /// <summary>
        /// Метод записи информации в файл
        /// </summary>
        /// <param name="text">Строка, которую следует записать</param>
        /// <param name="stream">Поток для записи</param>
        private void WriteToFile(string text, FileStream stream)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(text);
            stream.Write(info, 0, info.Length);
        }
        /// <summary>
        /// Загрузка нформации по автомобилям на парковках из файла
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            string bufferTextFromFile = "";
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                byte[] b = new byte[fs.Length];
                UTF8Encoding temp = new UTF8Encoding(true);
                while (fs.Read(b, 0, b.Length) > 0)
                {
                    bufferTextFromFile += temp.GetString(b);
                }
            }
            bufferTextFromFile = bufferTextFromFile.Replace("\r", "");
            var strs = bufferTextFromFile.Split('\n');
            if (strs[0].Contains("CountLeveles"))
            {
                //считываем количество уровней
                int count = Convert.ToInt32(strs[0].Split(':')[1]);
                if (parkingStages != null)
                {
                    parkingStages.Clear();
                }
                parkingStages = new List<Parking<ITransport>>(count);
            }
            else
            {
                //если нет такой записи, то это не те данные
                return false;
            }
            int counter = -1;
            ITransport car = null;
            for (int i = 1; i < strs.Length; ++i)
            {
                //идем по считанным записям
                if (strs[i] == "Level")
                {
                    //начинаем новый уровень
                    counter++;
                parkingStages.Add(new Parking<ITransport>(countPlaces,
pictureWidth, pictureHeight));
                    continue;
                }
                if (string.IsNullOrEmpty(strs[i]))
                {
                    continue;
                }
                if (strs[i].Split(':')[1] == "SamosvalCar")
                {
                    car = new SamosvalCar(strs[i].Split(':')[2]);
                }
                else if (strs[i].Split(':')[1] == "SuperSamosval")
                {
                    car = new SuperSamosval(strs[i].Split(':')[2]);
                }
                parkingStages[counter][Convert.ToInt32(strs[i].Split(':')[0])] = car;
            }
            return true;
        }
    }
}
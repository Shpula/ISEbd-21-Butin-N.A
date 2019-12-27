using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsSamosval
{
    /// <summary>
    /// Параметризованны класс для хранения набора объектов от интерфейса ITransport
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Parking<T, E> where T : class, ITransport where E : class, IWheels
    {
        private Dictionary<int, T> _places;
        private int _maxCount;
        private Stack<T> removedCar;
        private int PictureWidth { get; set; }
        private int PictureHeight { get; set; }
        private const int _placeSizeWidth = 210;
        private const int _placeSizeHeight = 80;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// 
    
        public static bool operator ==(Parking<T, E> p, int index)
        {
            if (index < 0 || index > p._places.Length || p.CheckFreePlace(index))
            {
                return false;
            }

            for (int i = 0; i < p._places.Length; i++)
            {
                if (p.CheckFreePlace(i) || i == index)
                {
                    continue;
                }
                if (p._places[i].ToString() == p._places[index].ToString())
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Parking<T, E> p, int index)
        {
            if (index < 0 || index > p._places.Length || p.CheckFreePlace(index))
            {
                return false;
            }

            for (int i = 0; i < p._places.Length; i++)
            {
                if (p.CheckFreePlace(i) || i == index)
                {
                    continue;
                }
                if (p._places[i].ToString() == p._places[index].ToString())
                {
                    return false;
                }
            }
            return true;
        }

        public Parking(int sizes, int pictureWidth, int pictureHeight)
        {
            _maxCount = sizes;
            _places = new Dictionary<int, T>();
            removedCar = new Stack<T>();
            PictureWidth = pictureWidth;
            PictureHeight = pictureHeight;
            for (int i = 0; i < _places.Length; i++)
            {
                _places[i] = null;
            }
        }

        /// <summary>
        /// Перегрузка оператора сложения
        /// Логика действия: на парковку добавляется автомобиль
        /// </summary>
        /// <param name="p">Парковка</param>
        /// <param name="car">Добавляемый автомобиль</param>
        /// <returns></returns>
        public static int operator +(Parking<T, E> p, T car)
        {
            if (p._places.Count == p._maxCount)
            {
                return -1;
            }
            for (int i = 0; i < p._maxCount; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    p._places.Add(i, car);
                    p._places[i].SetPosition(5 + i / 5 * _placeSizeWidth + 5,
                     i % 5 * _placeSizeHeight + 15, p.PictureWidth,
                    p.PictureHeight);
                    return i;
                }
            }
            return -1;
        }
        /// <summary>
        /// Перегрузка оператора вычитания
        /// Логика действия: с парковки забираем автомобиль
        /// </summary>
        /// <param name="p">Парковка</param>
        /// <param name="index">Индекс места, с которого пытаемся извлечь
        /// <returns></returns>
        public static T operator -(Parking<T, E> p, int index)
        {
            if (!p.CheckFreePlace(index))
            {
                T car = p._places[index];
                p.removedCar.Push(car);
                p._places.Remove(index);
                return car;
            }
            return null;
        }

        public T GetCarByKey(int key)
        {
            return _places.ContainsKey(key) ? _places[key] : null;
        }

        private bool CheckFreePlace(int index)
        {
            return !_places.ContainsKey(index);
        }

        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>
        /// <param name="g"></param>
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            var keys = _places.Keys.ToList();
            for (int i = 0; i < keys.Count; i++)
            {
                _places[keys[i]].DrawCar(g);
            }
        }
        /// <summary>
        /// Метод отрисовки разметки парковочных мест
        /// </summary>
        /// <param name="g"></param>
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            //границы праковки
            g.DrawRectangle(pen, 0, 0, (_maxCount / 5) * _placeSizeWidth, 480);
            for (int i = 0; i < _maxCount / 5; i++)
            {//отрисовываем, по 5 мест на линии
                for (int j = 0; j < 6; ++j)
                {//линия рамзетки места
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight,
                    i * _placeSizeWidth + 110, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, 400);
            }
        }
    }
}
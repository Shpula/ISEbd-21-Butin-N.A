﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsSamosval
{
    public class SamosvalCar : Vehicle
    {
        private const int carWidth = 100;
        private const int carHeight = 60;
        public Color DopColor { private set; get; }
        public bool MainPipe { private set; get; }
        public bool Container { private set; get; }
   
        public SamosvalCar(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }

        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - carWidth - 10)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > 0 + 50)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - carHeight + 50)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        public override void DrawCar(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush brush = new SolidBrush(Color.Black);
            Brush brush1 = new SolidBrush(Color.Orange);

            //Колёса
            g.FillEllipse(brush, _startPosX, _startPosY, 20, 20);
            g.FillEllipse(brush, _startPosX + 30, _startPosY, 20, 20);
            g.FillEllipse(brush, _startPosX + 60, _startPosY, 20, 20);
            g.FillEllipse(brush, _startPosX + 90, _startPosY, 20, 20);
            //Кузов
            g.FillRectangle(brush1, _startPosX, _startPosY - 15, 115, 15);
            g.FillRectangle(brush1, _startPosX + 65, _startPosY - 50, 30, 50);
            g.FillRectangle(brush1, _startPosX + 65, _startPosY - 30, 50, 30);
            //Стекло
            g.FillRectangle(brush, _startPosX + 85, _startPosY - 45, 10, 15);
            //Контейнер
            g.FillRectangle(brush1, _startPosX - 5, _startPosY - 50, 60, 40);
            //Труба 
            g.FillRectangle(brush, _startPosX + 63, _startPosY - 60, 5, 35  );
        }
    }
}

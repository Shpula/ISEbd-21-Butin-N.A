using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsSamosval
{
    public class SamosvalCar : Vehicle, IComparable<SamosvalCar>, IEquatable<SamosvalCar>
    {
        private const int carWidth = 100;
        private const int carHeight = 60;
   
        public SamosvalCar(int maxSpeed, float weight, Color mainColor, Color dopColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }

        public SamosvalCar(string info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);

            }
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
            Brush dopBrush = new SolidBrush(Color.Black);
            Brush mainBrush = new SolidBrush(MainColor);

            //Колёса
            g.FillEllipse(dopBrush, _startPosX, _startPosY + 50, 20, 20);
            g.FillEllipse(dopBrush, _startPosX + 30, _startPosY + 50, 20, 20);
            g.FillEllipse(dopBrush, _startPosX + 60, _startPosY + 50, 20, 20);
            g.FillEllipse(dopBrush, _startPosX + 90, _startPosY + 50, 20, 20);
            //Кузов
            g.FillRectangle(mainBrush, _startPosX, _startPosY - 15 + 50, 115, 15);
            g.FillRectangle(mainBrush, _startPosX + 65, _startPosY - 50 + 50, 30, 50);
            g.FillRectangle(mainBrush, _startPosX + 65, _startPosY - 30 + 50, 50, 30);
            //Стекло
            g.FillRectangle(dopBrush, _startPosX + 85, _startPosY - 45 + 50, 10, 15);
        }

        public override string ToString()
        {
            return MaxSpeed + ";" + Weight + ";" + MainColor.Name;
        }
        public int CompareTo(SamosvalCar other)
        {
            if (other == null)
            {
                return 1;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return MaxSpeed.CompareTo(other.MaxSpeed);
            }
            if (Weight != other.Weight)
            {
                return Weight.CompareTo(other.Weight);
            }
            if (MainColor != other.MainColor)
            {
                MainColor.Name.CompareTo(other.MainColor.Name);
            }
            return 0;
        }

        /// <summary>
        /// Метод интерфейса IEquatable для класса Car
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(SamosvalCar other)
        {
            if (other == null)
            {
                return false;
            }
            if (GetType().Name != other.GetType().Name)
        {
                return false;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return false;
            }
            if (Weight != other.Weight)
            {
                return false;
            }
            if (MainColor != other.MainColor)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Перегрузка метода от object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is SamosvalCar carObj))
            {
                return false;
            }
            else
            {
                return Equals(carObj);
            }
        }

        /// <summary>
        /// Перегрузка метода от object
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

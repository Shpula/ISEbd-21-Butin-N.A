using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsSamosval
{
    public class CrossWheels : IWheels
    {
        public float _startPosX;
        public float _startPosY;
        public CrossWheels(float x, float y)
        {
            _startPosX = x;
            _startPosY = y;
        }
        public void DrawWheels(Graphics g, CountWheels countWheels, Color color)
        {
            Pen pen = new Pen(Color.Black);
            Brush white = new SolidBrush(color);
            switch ((int)countWheels + 1)
            {
                case 1:
                    g.DrawLine(pen, _startPosX + 5, _startPosY + 5, 5, 5);
                    g.DrawLine(pen, _startPosX + 35, _startPosY + 5, 5, 5);
                    g.DrawLine(pen, _startPosX + 65, _startPosY + 5, 5, 5);
                    g.DrawLine(pen, _startPosX + 95, _startPosY + 5, 5, 5);
                    break;
                case 2:
                    g.DrawLine(pen, _startPosX + 5, _startPosY + 5, 5, 5);
                    g.DrawLine(pen, _startPosX + 35, _startPosY + 5, 5, 5);
                    g.DrawLine(pen, _startPosX + 65, _startPosY + 5, 5, 5);
                    g.DrawLine(pen, _startPosX + 95, _startPosY + 5, 5, 5);

                    g.DrawLine(pen, _startPosX + 5, _startPosY + 5, 7, 7);
                    g.DrawLine(pen, _startPosX + 35, _startPosY + 5, 7, 7);
                    g.DrawLine(pen, _startPosX + 65, _startPosY + 5, 7, 7);
                    g.DrawLine(pen, _startPosX + 95, _startPosY + 5, 7, 7);
                    break;
                case 3:
                    g.DrawLine(pen, _startPosX + 5, _startPosY + 5, 5, 5);
                    g.DrawLine(pen, _startPosX + 35, _startPosY + 5, 5, 5);
                    g.DrawLine(pen, _startPosX + 65, _startPosY + 5, 5, 5);
                    g.DrawLine(pen, _startPosX + 95, _startPosY + 5, 5, 5);

                    g.DrawLine(pen, _startPosX + 5, _startPosY + 5, 7, 7);
                    g.DrawLine(pen, _startPosX + 35, _startPosY + 5, 7, 7);
                    g.DrawLine(pen, _startPosX + 65, _startPosY + 5, 7, 7);
                    g.DrawLine(pen, _startPosX + 95, _startPosY + 5, 7, 7);

                    g.DrawLine(pen, _startPosX + 5, _startPosY + 5, 10, 10);
                    g.DrawLine(pen, _startPosX + 35, _startPosY + 5, 10, 10);
                    g.DrawLine(pen, _startPosX + 65, _startPosY + 5, 10, 10);
                    g.DrawLine(pen, _startPosX + 95, _startPosY + 5, 10, 10);
                    break;
            }
        }
    }
}
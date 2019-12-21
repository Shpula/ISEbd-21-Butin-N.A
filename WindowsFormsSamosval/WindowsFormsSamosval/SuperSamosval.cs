﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsSamosval
{
    class SuperSamosval : SamosvalCar
    {
        public Color DopColor { private set; get; }
        public bool MainPipe { private set; get; }
        public bool Container { private set; get; }

        public CountWheels Wheels { private set; get; }
        public string WheelsForm;
        public Color WheelsColor { private set; get; }

        public SuperSamosval(int maxSpeed, float weight, Color mainColor, Color dopColor,
       bool mainPipe, bool container, CountWheels countWheels, string wheelsForm, Color wheelColor) :
        base(maxSpeed, weight, mainColor)
        {
            DopColor = dopColor;
            MainPipe = mainPipe;
            Container = container;
            Wheels = countWheels;
            WheelsForm = wheelsForm;
            WheelsColor = wheelColor;
        }
        public override void DrawCar(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush dopBrush = new SolidBrush(DopColor);
            Brush brush = new SolidBrush(Color.Black);
            Brush brush1 = new SolidBrush(Color.Orange);

            base.DrawCar(g);

            IWheels motors;
            switch (WheelsForm)
            {
                case "sq":
                    motors = new SqWheels(_startPosX, _startPosY);
                    break;
                case "circle":
                    motors = new CircleWheels(_startPosX, _startPosY);
                    break;
                case "cross":
                    motors = new CrossWheels(_startPosX, _startPosY);
                    break;
                default:
                    motors = new SqWheels(_startPosX, _startPosY);
                    break;
            }
            motors.DrawWheels(g, Wheels, WheelsColor);

            if (MainPipe)
            {
                g.FillRectangle(brush, _startPosX + 63, _startPosY - 60, 5, 35);
            }

            if (Container)
            {
                g.FillRectangle(brush1, _startPosX - 5, _startPosY - 50, 60, 40);
            }
        }
    }
}

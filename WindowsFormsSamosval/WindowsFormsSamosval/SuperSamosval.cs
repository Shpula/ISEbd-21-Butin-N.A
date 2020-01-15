using System;
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
        base(maxSpeed, weight, mainColor, dopColor)
        {
            DopColor = dopColor;
            MainPipe = mainPipe;
            Container = container;
            Wheels = countWheels;
            WheelsForm = wheelsForm;
            WheelsColor = wheelColor;
        }

        public SuperSamosval(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 6)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                Container = Convert.ToBoolean(strs[4]);
                MainPipe = Convert.ToBoolean(strs[5]);
            }
        }

        public override void DrawCar(Graphics g)
        {
            Brush dopBrush = new SolidBrush(DopColor);
            Brush mainBrush = new SolidBrush(MainColor);

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
                g.FillRectangle(dopBrush, _startPosX + 63, _startPosY - 60 + 40, 5, 35);
            }

            if (Container)
            {
                g.FillRectangle(dopBrush, _startPosX - 5, _startPosY - 50 + 40, 60, 40);
            }
        }
        
          public void SetDopColor(Color color)
        {
            DopColor = color;
        }

        public override string ToString()
        {
            return base.ToString() + ";" + DopColor.Name + ";" + Container + ";" + MainPipe;
        }
    }
}

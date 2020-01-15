using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsSamosval
{
    public partial class SamosvalForm : Form
    {
        private SamosvalCar car;
        public SamosvalForm()
        {
            InitializeComponent();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxSamosval.Width, pictureBoxSamosval.Height);
            Graphics gr = Graphics.FromImage(bmp);
            car.DrawCar(gr);
            pictureBoxSamosval.Image = bmp;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            car = new SamosvalCar(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue, Color.Black);
            car.SetPosition(rnd.Next(20, 100), rnd.Next(100, 100), pictureBoxSamosval.Width,
           pictureBoxSamosval.Height);
            Draw();
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    car.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    car.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    car.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    car.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }

        private void buttonCreateSuperSamosval_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            car = new SuperSamosval(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue,
           Color.Yellow, true, true, CountWheels.Three, "cross", Color.Orange);
            car.SetPosition(rnd.Next(20, 100), rnd.Next(100, 100), pictureBoxSamosval.Width,
           pictureBoxSamosval.Height);
            Draw();
        }
    }
}

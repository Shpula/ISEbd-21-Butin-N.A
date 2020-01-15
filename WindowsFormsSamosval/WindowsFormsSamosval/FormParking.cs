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
    public partial class FormParking : Form
    {
        Parking<ITransport, IWheels> parking;

        public FormParking()
        {
            InitializeComponent();
            parking = new Parking<ITransport, IWheels>(20, pictureBoxParking.Width,
           pictureBoxParking.Height);
            Draw();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxParking.Image = bmp;
        }
        private void buttonSetSamosval_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var car = new SamosvalCar(100, 1000, dialog.Color, dialogDop.Color);
                    int place = parking + car;
                    Draw();
                }
            }
        }
        private void buttonSetSuperSamosval_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var car = new SuperSamosval(100, 1000, dialog.Color, dialogDop.Color,
                   true, true, CountWheels.Three, "sq", Color.Orange);
                    int place = parking + car;
                    Draw();
                }
            }
        }
        private void buttonTakeCar_Click(object sender, EventArgs e)
        {
            if (maskedTextBox.Text != "")
            {
                var car = parking - Convert.ToInt32(maskedTextBox.Text);
                if (car != null)
                {
                    Bitmap bmp = new Bitmap(pictureBoxTakeCar.Width,
                   pictureBoxTakeCar.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    car.SetPosition(30, 30, pictureBoxTakeCar.Width,
                   pictureBoxTakeCar.Height);
                    car.DrawCar(gr);
                    pictureBoxTakeCar.Image = bmp;
                }
                else
                {
                    Bitmap bmp = new Bitmap(pictureBoxTakeCar.Width,
                   pictureBoxTakeCar.Height);
                    pictureBoxTakeCar.Image = bmp;
                }
                Draw();
            }

        }
        private void buttonFindMatches_Click(object sender, EventArgs e)
        {
            if (maskedTextBox.Text != "")
            {
                if (parking == Convert.ToInt32(maskedTextBox.Text))
                {
                    MessageBox.Show("Совпадения найдены", "Результат",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Совпадений нет", "Результат",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Draw();
        }
    }
}
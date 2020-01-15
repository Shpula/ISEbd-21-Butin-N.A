using System.Drawing;
using System.Windows.Forms;
using WindowsFormsSamosval;
using System;
namespace WindowsFormsSamosval
{
    public partial class FormCarConfig : Form
    {
        ITransport car = null;
        private event carDelegate eventAddCar;

        public FormCarConfig()
        {
            InitializeComponent();
            panelRed.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;
            panelOrange.MouseDown += panelColor_MouseDown;
            panelBrown.MouseDown += panelColor_MouseDown;
            panelPink.MouseDown += panelColor_MouseDown;
            panelBlack.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor,
           DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (car != null)
            {
                car.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawCar();
            }
        }

        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (car != null)
            {
                if (car is SuperSamosval)
                {
                    (car as
                   SuperSamosval).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawCar();
                }
            }
        }

        public void AddEvent(carDelegate ev)
        {
            if (eventAddCar == null)
            {
                eventAddCar = new carDelegate(ev);
            }
            else
            {
                eventAddCar += ev;
            }
        }

        private void DrawCar()
        {
            if (car != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxCar.Width, pictureBoxCar.Height);
                Graphics gr = Graphics.FromImage(bmp);
                car.SetPosition(5, 5, pictureBoxCar.Width, pictureBoxCar.Height);
                car.DrawCar(gr);
                pictureBoxCar.Image = bmp;
            }
        }

        // Передаем информацию при нажатии на Label
        private void labelSamosval_MouseDown(object sender, MouseEventArgs e)
        {
            labelSamosval.DoDragDrop(labelSamosval.Text, DragDropEffects.Move |
           DragDropEffects.Copy);
        }

        // Передаем информацию при нажатии на Label
        private void labelSuperSamosval_MouseDown(object sender, MouseEventArgs e)
        {
            labelSuperSamosval.DoDragDrop(labelSuperSamosval.Text, DragDropEffects.Move |
           DragDropEffects.Copy);
        }

        // Проверка получаемой информации (ее типа на соответствие требуемому)
        private void panelCar_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        // Действия при приеме перетаскиваемой информации
        private void panelCar_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Обычный самосвал":
                    car = new SamosvalCar(100, 500, Color.White, Color.Black);
                    break;
                case "Супер самосвал":
                    car = new SuperSamosval(100, 500, Color.White, Color.Black, true, true);
                    break;
            }
            DrawCar();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            eventAddCar?.Invoke(car);
            Close();
        }
    }
}

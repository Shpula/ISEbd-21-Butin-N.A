using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsSamosval;

namespace WindowsFormSamosval
{
    public class DrawKolesa
    {
        public Kolesa kolesa { private get; set; }

        private float x;
        private float y;

        public DrawKolesa(Kolesa numberOfKoleso, float _startPosX, float _startPosY)
        {
            kolesa = numberOfKoleso;
            x = _startPosX;
            y = _startPosY;
        }

        private int ConvertToInt(Kolesa numberOfKoleso)
        {
            return (int)numberOfKoleso + 2;
        }

        public void KolesaDraw(Graphics g)
        {
            for (int i = 0; i < ConvertToInt(kolesa); i++)
            {
                Brush kist = new SolidBrush(Color.Black);

                int X = i * 30;
                g.FillEllipse(kist, x + X, y, 30, 30);
                kist.Dispose();
            }
        }
    }
}
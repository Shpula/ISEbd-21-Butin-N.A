using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsSamosval
{
    interface IWheels
    {
        void DrawWheels(Graphics g, CountWheels countmotors, Color color);
    }
}

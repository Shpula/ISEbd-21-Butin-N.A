using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsSamosval;

namespace WindowsFormsSamosval
{
    class Kolesa
    {
        public KolesaCount Count { private set; get; }
        public Color MainColor { private set; get; }
        public Color SecondColor { private set; get; }
        public float _startPosX;
        public float _startPosY;
    }

    public Kolesa(KolesaCount count, Color primarycolor, Color secondcolor, float PosX, float PosY)
    {
        Count = count;
        MainColor = primarycolor;
        SecondColor = secondcolor;
        _startPosX = PosX;
        _startPosY = PosY;
    }

    public enum KolesaCount
    {
        FOUR,
        FIVE,
        SIX
    }
}
private int CountToInt(KolesaCount count)
{
    return (int)count + 4;
}

public void DrawRocket(Graphics g)
{
    for (int i = 0; i < CountToInt(Count); i++)
    {
        Brush kist = new SolidBrush(Color.Black);

        int X = i * 10;
        int Y = i * 12;
        g.FillRectangle(kist, _startPosX + 100 - X, _startPosY - 10 + Y, 20, 10);
        g.FillRectangle(kist, _startPosX + 100 - X, _startPosY - 10 + Y, 40, 5);
        g.FillRectangle(kist, _startPosX + 100 - X, _startPosY + 100 + Y, 20, 10);
        g.FillRectangle(kist, _startPosX + 100 - X, _startPosY + 100 + Y, 40, 5);
        kist.Dispose();
    }
} 
} 
}
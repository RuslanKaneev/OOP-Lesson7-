using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_2
{
    internal class Figure
    {
        public string ColorFigure { get; set; }
        public VisibilityStatus VisibilityFigure { get; set; }


        public int X { get; set; }
        public int Y { get; set; }

        public virtual Figure MoveFigure(int x, int y)

        {
            X += x;
            Y += y;
            return this;
        }
        public string СhangingСolor(string colorFig)
        {
            ColorFigure = colorFig;
            return ColorFigure;
        }

        public VisibilityStatus СhangingVisibilityFigure(VisibilityStatus vis)
        {
            VisibilityFigure = vis;
            return VisibilityFigure;
        }

        public virtual string ToString()
        {
            return "Параметры фигуры: " + " Цвет " + ColorFigure + " Состояние " + VisibilityFigure;

        }

    }
}

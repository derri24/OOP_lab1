using System;
using System.Drawing;

using BaseFigureLib;


namespace laba1_OOP
{
    public class Ellips : IFigure
    {
        public int x, y, width, heigth;
        
        public Color colorPen;
        public int sizePen;

        public Ellips()
        {
            colorPen = new Color();
        }
        public override string ToString()
        {
            return "Эллипc";
        }

        public void Draw(Bitmap bmp)
        {
            Graphics graphics = Graphics.FromImage(bmp);

            Pen pen = new Pen(colorPen, sizePen);

            graphics.DrawEllipse(pen, x, y, width, heigth);
            graphics.Dispose();
        }

        public void SetProperties(Color color,int size)
        {
            colorPen = color;
            sizePen = size;
        }

        public void Resize(int x1, int y1, int x2, int y2)
        {
            if (x2 > x1)
            {
                this.x = x1;
                this.width = x2 - x1;
            }
            else
            {
                this.x = x2;
                this.width = x1 - x2;
            }

            if (y2 > y1)
            {
                this.y = y1;
                this.heigth = y2 - y1;
            }
            else
            {
                this.y = y2;
                this.heigth = y1 - y2;
            }
        }
    }
}
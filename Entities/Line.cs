using System;
using System.Drawing;

using BaseFigureLib;
namespace laba1_OOP
{
 
    public class Line : IFigure
    {
        public int x1, y1, x2, y2;
        
        public Color colorPen;
        public int sizePen;

        public Line()
        {
            colorPen = new Color();
        }
        public override string ToString()
        {
            return "Отрезок";
        }
        public  void Draw(Bitmap bmp)
        {
            Graphics graphics = Graphics.FromImage(bmp);
            Pen pen = new Pen(colorPen, sizePen);
            graphics.DrawLine(pen, x1, y1, x2, y2);
            graphics.Dispose();
        }

        public void SetProperties(Color color,int size)
        {
            colorPen = color;
            sizePen = size;
        }
        public  void Resize(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }
    }
}
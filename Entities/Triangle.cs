using System;
using System.Drawing;
using BaseFigureLib;

namespace laba1_OOP
{
    class Triangle : IFigure
    {
        public int x1, x2, x3, y1, y2, y3;

        public Color colorPen;
        public int sizePen;
        
        public Triangle()
        {
            colorPen = new Color();
        }
        public override string ToString()
        {
            return "Треугольник";
        }
        public  void Draw(Bitmap bmp)
        {
            Graphics graphics = Graphics.FromImage(bmp);
            Pen pen = new Pen(colorPen, sizePen);

            Point point_1 = new Point(x1, y1);
            Point point_2 = new Point(x2, y2);
            Point point_3 = new Point(x3, y3);

            Point[] points = new Point[3] {point_1, point_2, point_3};
            graphics.DrawPolygon(pen, points);
            graphics.Dispose();
        }
        public void SetProperties(Color color,int size)
        {
            colorPen = color;
            sizePen = size;
        }
        public  void Resize(int x1, int y1, int x2, int y2)
        {
            int temp;
            if ((x1 > x2))
            {
                temp = x2;
                x2 = x1;
                x1 = temp;
            }
            if ((y1 > y2))
            {
                temp = y2;
                y2 = y1;
                y1 = temp;
            }

            this.x1 = x2;
            this.y1 = y2;

            this.x2 = x1;
            this.y2 = y2;

            this.x3 = x1 + Math.Abs(x2 - x1) / 2;
            this.y3 = y1;
        }
    }
}
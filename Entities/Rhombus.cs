using System;
using System.Drawing;
using BaseFigureLib;

namespace laba1_OOP
{

    public class Rhombus : IFigure
    {
        public int x1, y1, x2, y2, x3, y3, x4, y4;
        public Color colorPen;
        public int sizePen;
        
        public Rhombus()
        {
            colorPen = new Color();
        }
        public override string ToString()
        {
            return "Ромб";
        }
        
        public  void Draw(Bitmap bmp)
        {
            Graphics graphics = Graphics.FromImage(bmp);
            Pen pen = new Pen(colorPen, sizePen);
         
            Point point_1 = new Point(x1, y1);
            Point point_2 = new Point(x2, y2);
            Point point_3 = new Point(x3, y3);
            Point point_4 = new Point(x4, y4);

            Point[] points = new Point[4] {point_1, point_2, point_3,point_4};
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
            this.x1 = x1 + (x2 - x1) / 2;
            this.y1 = y1;

            this.x2 = x2;
            this.y2 = y1 + (y2 - y1) / 2;

            this.x3= x1 + (x2 - x1) / 2;
            this.y3 = y2;

            this.x4 = x1;
            this.y4 = y1 + (y2 - y1) / 2;
        }
    
    }
}
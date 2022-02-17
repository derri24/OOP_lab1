using System.Drawing;

namespace laba1_OOP
{
    class Triangle : Figure
    {
        private int x1, x2, x3, y1, y2, y3;

        public Triangle(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.x3 = x3;
            this.y1 = y1;
            this.y2 = y2;
            this.y3 = y3;
        }

        public override void Draw(Bitmap bmp)
        {
            Graphics graphics = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.DarkGreen, 5);
         
            Point point_1 = new Point(x1, y1);
            Point point_2 = new Point(x2, y2);
            Point point_3 = new Point(x3, y3);
            
            Point[] points = new Point[3] {point_1, point_2, point_3};
            graphics.DrawPolygon(pen, points);
        }
    }
}
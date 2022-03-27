using System.Drawing;

namespace laba1_OOP
{
    public class Polygon:Figure
    {
        private int x1, x2, x3, y1, y2, y3,x4,y4,x5,y5,x6,y6;
        public Polygon(int x1, int y1,int x2, int y2, int x3, int y3,int x4,int y4,int x5,int y5,int x6,int y6)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.x3 = x3;
            this.x4 = x4;
            this.x5 = x5;
            this.x6 = x6;
            this.y1 = y1;
            this.y2 = y2;
            this.y3 = y3;
            this.y4 = y4;
            this.y5 = y5;
            this.y6 = y6;
        }

        public override void Draw(Bitmap bmp)
        {
            Graphics graphics = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Coral, 5);

            Point point_1 = new Point(x1,y1);
            Point point_2 = new Point(x2,y2);
            Point point_3 = new Point(x3,y3);
            Point point_4 = new Point(x4,y4);
            Point point_5 = new Point(x5,y5);
            Point point_6 = new Point(x6,y6);
            Point[] points = new Point[6]{point_1,point_2,point_3,point_4,point_5,point_6};
            graphics.DrawPolygon(pen, points);
        }
    }
}
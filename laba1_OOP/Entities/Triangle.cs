using System.Drawing;

namespace laba1_OOP
{
   
    class Triangle : IFigure
    {
        private int x1, x2, x3, y1, y2, y3;
        public Triangle(int x1, int y1,int x2, int y2, int x3, int y3)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.x3 = x3;
            this.y1 = y1;
            this.y2 = y2;
            this.y3 = y3;
        }
        public void Draw(Bitmap bmp)
        {
            Graphics graphics = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.DarkGreen, 5);
            graphics.DrawLine(pen, x1,y1,x2,y2);
            graphics.DrawLine(pen, x2,y2,x3,y3);
            graphics.DrawLine(pen, x3,y3,x1,y1);
        }
    }
}
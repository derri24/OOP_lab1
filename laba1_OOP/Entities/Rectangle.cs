using System.Drawing;

namespace laba1_OOP
{
    public class Rectangle:Figure
    {
        private int x, y,width,heigth;
        public Rectangle(int x, int y,int width,int heigth)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.heigth = heigth;
        }
        public override void Draw(Bitmap bmp)
        {
            Graphics graphics = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.DarkBlue, 5);
            graphics.DrawRectangle(pen,x,y,width,heigth);
        }
    }
}
using System.Drawing;

namespace laba1_OOP
{
    public class Square:Figure
    {
        private int x, y,width;
        
        public Square(int x, int y,int width)
        {
            this.x = x;
            this.y = y;
            this.width = width;
        }
        
        public override void Draw(Bitmap bmp)
        {
            Graphics graphics = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Violet, 5);
            graphics.DrawRectangle(pen,x,y,width,width);
        }
    }
}
using System.Drawing;

namespace laba1_OOP
{
    public class Circle:Figure
    {
      
        private int x, y,width;
        
        public Circle(int x, int y,int width)
        {
            this.x = x;
            this.y = y;
            this.width = width;
        }
        public override void Draw(Bitmap bmp)
        {
            Graphics graphics = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Yellow, 5);
            graphics.DrawEllipse(pen,x,y,width,width);
        }
    }
}
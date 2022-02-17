using System.Drawing;

namespace laba1_OOP
{
    public class Ellips:IFigure
    {
        private int x, y,width,heigth;
        
        public Ellips(int x, int y,int width,int heigth)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.heigth = heigth;
        }
        
        public void Draw(Bitmap bmp)
        {
            Graphics graphics = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Turquoise, 5);
            graphics.DrawEllipse(pen,x,y,width,heigth);
        }
    }
}
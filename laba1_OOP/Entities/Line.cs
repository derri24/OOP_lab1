using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace laba1_OOP
{
    public class Line:IFigure
    {
        private int x1, y1, x2, y2;
        public Line(int x1,int y1,int x2,int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }
        public void Draw(Bitmap bmp)
        {
            Graphics graphics = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Red, 5);
            graphics.DrawLine(pen, x1,y1,x2,y2);
        }
    }
}
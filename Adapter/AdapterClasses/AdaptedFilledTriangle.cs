using System.Drawing;
using BaseFigureLib;

namespace laba1_OOP.Adapter.AdapterClasses
{
    public class AdaptedFilledTriangle:IFigure
    {
        private FilledTriangle.FilledTriangle filledTriangle;
        
        public AdaptedFilledTriangle()
        {
            filledTriangle = new FilledTriangle.FilledTriangle();
        }

        public override string ToString()
        {
            return filledTriangle.ToString();
        }

        public void Draw(Bitmap bmp)
        {
            filledTriangle.Draw(bmp);
        }
        public void SetProperties(Color color,int size)
        {
            filledTriangle.R = color.R;
            filledTriangle.G = color.G;
            filledTriangle.B = color.B;
        }
        public  void Resize(int x1, int y1, int x2, int y2)
        {
            filledTriangle.Resize(x1, y1, x2, y2);
        }
    }
}
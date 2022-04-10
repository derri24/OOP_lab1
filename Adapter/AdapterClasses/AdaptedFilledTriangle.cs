using System.Drawing;
using LibraryFigure;

namespace laba1_OOP.Adapter.AdapterClasses
{
    public class AdaptedFilledTriangle:Figure
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

        public override void Draw(Bitmap bmp)
        {
            filledTriangle.Draw(bmp);
            filledTriangle.R = colorPen.R;
            filledTriangle.G = colorPen.G;
            filledTriangle.B = colorPen.B;
        }

        public override void Resize(int x1, int y1, int x2, int y2)
        {
            filledTriangle.Resize(x1, y1, x2, y2);
        }
    }
}
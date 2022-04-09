using System.Drawing;
using LibraryFigure;

namespace laba1_OOP.Adapter.AdapterClasses
{
    public class AdapterFilledTriangle:Figure
    {
        private FilledTriangle.FilledTriangle filledTriangle;
        
        public AdapterFilledTriangle()
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
        }

        public override void Resize(int x1, int y1, int x2, int y2)
        {
            filledTriangle.Resize(x1, y1, x2, y2);
        }
    }
}
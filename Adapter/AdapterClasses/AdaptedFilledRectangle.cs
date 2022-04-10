using System.Drawing;

using LibraryFigure;

namespace laba1_OOP.Adapter.AdapterClasses
{
    public class AdaptedFilledRectangle:Figure
    {
        
        private FilledRectangle.FilledRectangle filledRectangle;
        
        public AdaptedFilledRectangle()
        {
            filledRectangle = new FilledRectangle.FilledRectangle();
        }

        public override string ToString()
        {
            return filledRectangle.ToString();
        }

        public override void Draw(Bitmap bmp)
        {
            filledRectangle.Draw(bmp);
            filledRectangle.R = colorPen.R;
            filledRectangle.G = colorPen.G;
            filledRectangle.B = colorPen.B;
        }

        public override void Resize(int x1, int y1, int x2, int y2)
        {
            filledRectangle.Resize(x1, y1, x2, y2);
        }
    }
}
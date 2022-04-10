using System.Drawing;
using LibraryFigure;



namespace laba1_OOP.Adapter.AdapterClasses
{
    public class AdaptedFilledHexagon: Figure
    {
        private FilledHexagon.FilledHexagon filledEllipse;
        
        public AdaptedFilledHexagon()
        {
            filledEllipse = new FilledHexagon.FilledHexagon();
        }

        public override string ToString()
        {
            return filledEllipse.ToString();
        }

        public override void Draw(Bitmap bmp)
        {
            filledEllipse.Draw(bmp);
            filledEllipse.R = colorPen.R;
            filledEllipse.G = colorPen.G;
            filledEllipse.B = colorPen.B;
        }

        public override void Resize(int x1, int y1, int x2, int y2)
        {
            filledEllipse.Resize(x1, y1, x2, y2);
        }
    }
}
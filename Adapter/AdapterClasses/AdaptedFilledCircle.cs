using System.Drawing;

using LibraryFigure;

namespace laba1_OOP.Adapter.AdapterClasses
{
    public class AdapterFilledCircle : Figure
    {
        private FilledCircle.FilledEllipse filledCircle;
        
        public AdapterFilledCircle()
        {
            filledCircle = new FilledCircle.FilledEllipse();
        }

        public override string ToString()
        {
            return filledCircle.ToString();
        }

        public override void Draw(Bitmap bmp)
        {
            filledCircle.Draw(bmp);
        }

        public override void Resize(int x1, int y1, int x2, int y2)
        {
            filledCircle.Resize(x1, y1, x2, y2);
        }
    }
}
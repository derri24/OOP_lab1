using System.Drawing;
using LibraryFigure;
using FilledHexagonLib;


namespace laba1_OOP.Adapter.AdapterClasses
{
    public class AdapterFilledHexagon: Figure
    {
        private FilledHexagon filledEllipse;
        
        public AdapterFilledHexagon()
        {
            filledEllipse = new FilledHexagon();
        }

        public override string ToString()
        {
            return filledEllipse.ToString();
        }

        public override void Draw(Bitmap bmp)
        {
            filledEllipse.Draw(bmp);
        }

        public override void Resize(int x1, int y1, int x2, int y2)
        {
            filledEllipse.Resize(x1, y1, x2, y2);
        }
    }
}
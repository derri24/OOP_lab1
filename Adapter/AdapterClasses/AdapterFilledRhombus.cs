using System.Drawing;
using LibraryFigure;


namespace laba1_OOP.Adapter.AdapterClasses
{
    public class AdapterFilledRhombus:Figure
    {
        private FilledRhombus.FilledRhombus filledRhombus;
        
        public AdapterFilledRhombus()
        {
            filledRhombus = new FilledRhombus.FilledRhombus();
        }

        public override string ToString()
        {
            return filledRhombus.ToString();
        }

        public override void Draw(Bitmap bmp)
        {
            filledRhombus.Draw(bmp);
        }

        public override void Resize(int x1, int y1, int x2, int y2)
        {
            filledRhombus.Resize(x1, y1, x2, y2);
        }
    }
}
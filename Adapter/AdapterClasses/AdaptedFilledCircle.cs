using System.Drawing;

using BaseFigureLib;

namespace laba1_OOP.Adapter.AdapterClasses
{
    public class AdapterFilledCircle : IFigure
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
        public  void Draw(Bitmap bmp)
        {
            filledCircle.Draw(bmp);
        }
        public void SetProperties(Color color,int size)
        {
            filledCircle.R = color.R;
            filledCircle.G = color.G;
            filledCircle.B = color.B;
        }
        public  void Resize(int x1, int y1, int x2, int y2)
        {
            filledCircle.Resize(x1, y1, x2, y2);
        }
    }
}
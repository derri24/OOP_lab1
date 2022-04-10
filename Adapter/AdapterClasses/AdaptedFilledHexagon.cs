using System.Drawing;
using BaseFigureLib;



namespace laba1_OOP.Adapter.AdapterClasses
{
    public class AdaptedFilledHexagon: IFigure
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
        public  void Draw(Bitmap bmp)
        {
            filledEllipse.Draw(bmp);
        }
        public void SetProperties(Color color,int size)
        {
            filledEllipse.R = color.R;
            filledEllipse.G = color.G;
            filledEllipse.B = color.B;
        }
        public  void Resize(int x1, int y1, int x2, int y2)
        {
            filledEllipse.Resize(x1, y1, x2, y2);
        }
    }
}
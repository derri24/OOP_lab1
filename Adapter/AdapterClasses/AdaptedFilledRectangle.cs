using System.Drawing;
using BaseFigureLib;

namespace laba1_OOP.Adapter.AdapterClasses
{
    public class AdaptedFilledRectangle:IFigure
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
        public  void Draw(Bitmap bmp)
        {
            filledRectangle.Draw(bmp);
        }

        public void SetProperties(Color color,int size)
        {
            filledRectangle.R = color.R;
            filledRectangle.G = color.G;
            filledRectangle.B = color.B;
        }
        public  void Resize(int x1, int y1, int x2, int y2)
        {
            filledRectangle.Resize(x1, y1, x2, y2);
        }
    }
}
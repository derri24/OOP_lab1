using System.Drawing;
using BaseFigureLib;

namespace laba1_OOP.Adapter.AdapterClasses
{
    public class AdaptedFilledRhombus:IFigure
    {
        private FilledRhombus.FilledRhombus filledRhombus;
        
        public AdaptedFilledRhombus()
        {
            filledRhombus = new FilledRhombus.FilledRhombus();
        }

        public override string ToString()
        {
            return filledRhombus.ToString();
        }

        public  void Draw(Bitmap bmp)
        {
            filledRhombus.Draw(bmp);
        }
        
        public void SetProperties(Color color,int size)
        {
            filledRhombus.R = color.R;
            filledRhombus.G = color.G;
            filledRhombus.B = color.B;
        }

        public  void Resize(int x1, int y1, int x2, int y2)
        {
            filledRhombus.Resize(x1, y1, x2, y2);
        }
    }
}
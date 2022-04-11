using System.Drawing;
using BaseFigureLib;

namespace laba1_OOP
{
    public class DisplayFigure
    {
        public void Draw(IFigure figure, Bitmap btn)
        {
            if (figure != null)
                figure.Draw(btn);
            
        }

        public void Resize(IFigure figure, int x1, int y1, int x2, int y2)
        {
            if (figure != null)
                figure.Resize(x1, y1, x2, y2);
        }

        public void SetProperties(IFigure figure, Color color, int size)
        {
            if (figure != null)
            {
                figure.SetProperties(color, size);
            }
        }
    }
}
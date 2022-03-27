using LibraryFigure;
using System.Collections.Generic;
namespace laba1_OOP.Plugins
{
    public class EncryptingPlugin
    {
        public virtual void Serialization(List<Figure> filterlistOfFigures,int key)
        {
        }

        public virtual List<Figure> Deserialization( int key)
        {
            List<Figure> listOfFigures = new List<Figure>();
            return listOfFigures;
        }
    }
}
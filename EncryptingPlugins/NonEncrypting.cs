using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using LibraryFigure;
using Newtonsoft.Json;

namespace laba1_OOP.Plugins
{
    public class NonEncrypting:EncryptingPlugin
    {
        public override void Serialization( List<Figure> filterlistOfFigures,int key)
        {
            string filename = "figure.dat";
            string jsonString = JsonConvert.SerializeObject(filterlistOfFigures,
                new JsonSerializerSettings {TypeNameHandling = TypeNameHandling.All});
            FileStream outputStream = new FileStream(filename, FileMode.Create);
            StreamWriter streamWriter = new StreamWriter(outputStream);
            streamWriter.Write(jsonString);
            streamWriter.Close();
            outputStream.Close();
        }


        public override List<Figure> Deserialization(int key)
        {
            string filename = "figure.dat";
            List<Figure> listOfFigures = new List<Figure>();
            FileStream inputStream = new FileStream(filename, FileMode.OpenOrCreate);
            try
            {
                StreamReader streamReader = new StreamReader(inputStream);
                string jsonString = streamReader.ReadToEnd();
                List<Figure> loaded = JsonConvert.DeserializeObject<List<Figure>>(jsonString,
                    new JsonSerializerSettings {TypeNameHandling = TypeNameHandling.Auto});
                if (loaded != null)
                    listOfFigures = loaded;
            }
            catch
            {
               MessageBox.Show("Ошибка файла!");
           }
            inputStream.Close();
            return listOfFigures;
        }
    }
}
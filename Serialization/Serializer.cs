using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using BaseFigureLib;
using Newtonsoft.Json;

namespace laba1_OOP.Plugins
{
    public class Serializer
    {
        public void Serialize(List<IFigure> filterlistOfFigures)
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


        public List<IFigure> Deserialize()
        {
            string filename = "figure.dat";
            List<IFigure> listOfFigures = new List<IFigure>();
            FileStream inputStream = new FileStream(filename, FileMode.OpenOrCreate);
            try
            {
                StreamReader streamReader = new StreamReader(inputStream);
                string jsonString = streamReader.ReadToEnd();
                List<IFigure> loaded = JsonConvert.DeserializeObject<List<IFigure>>(jsonString,
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
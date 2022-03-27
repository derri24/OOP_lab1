using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using LibraryFigure;
using Newtonsoft.Json;

namespace laba1_OOP.Plugins
{
    public class RailwayFence
    {
        public string Encryption(int key, string encryptionString)
        {
            char[,] matrix = new char[key, encryptionString.Length];
            int i = 0;
            StringBuilder decryptionString = new StringBuilder("");
            bool flag = false;
            for (int j = 0; j < encryptionString.Length; j++)
            {
                matrix[i, j] = encryptionString[j];
                if (i == key - 1)
                    flag = true;
                else if (i == 0)
                    flag = false;
                if (flag == true)
                    i--;
                else
                    i++;
            }

            for (int j = 0; j < key; j++)
            for (int k = 0; k < encryptionString.Length; k++)
                if (matrix[j, k] != 0)
                    decryptionString.Append(matrix[j, k]);
            return decryptionString.ToString();
        }

        public string Decryption(int key, string decryptionString)
        {
            StringBuilder encryptionString = new StringBuilder("");

            char[,] matrix = new char[key, decryptionString.Length];
            int i = 0;
            bool flag = false;
            for (int j = 0; j < decryptionString.Length; j++)
            {
                matrix[i, j] = '*';
                if (i == key - 1)
                    flag = true;
                else if (i == 0)
                    flag = false;
                if (flag == true)
                    i--;
                else
                    i++;
            }

            int index = 0;
            for (int j = 0; j < key; j++)
            for (int k = 0; k < decryptionString.Length; k++)
                if (matrix[j, k] == '*')
                {
                    matrix[j, k] = decryptionString[index];
                    index++;
                }

            for (int j = 0; j < decryptionString.Length; j++)
            for (int k = 0; k < key; k++)
                if (matrix[k, j] != 0)
                    encryptionString.Append(matrix[k, j]);
            return encryptionString.ToString();
        }
    }

    public class Encrypting : EncryptingPlugin
    {
        public override void Serialization(List<Figure> filterlistOfFigures, int key)
        {
            string filename = "figure.dat";

            string jsonString = JsonConvert.SerializeObject(filterlistOfFigures,
                new JsonSerializerSettings {TypeNameHandling = TypeNameHandling.All});
            FileStream outputStream = new FileStream(filename, FileMode.Create);
            StreamWriter streamWriter = new StreamWriter(outputStream);

            RailwayFence railwayFence = new RailwayFence();
            jsonString = railwayFence.Encryption(key, jsonString);

            streamWriter.Write(jsonString);
            streamWriter.Close();
            outputStream.Close();
        }


        public override List<Figure> Deserialization( int key)
        {
            string filename = "figure.dat";
            List<Figure> listOfFigures = new List<Figure>();
            FileStream inputStream = new FileStream(filename, FileMode.OpenOrCreate);
            try
            {
                StreamReader streamReader = new StreamReader(inputStream);
                string jsonString = streamReader.ReadToEnd();

                RailwayFence railwayFence = new RailwayFence();
                jsonString = railwayFence.Decryption(key, jsonString);

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
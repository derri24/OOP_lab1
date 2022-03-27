using System;
using System.IO;
using System.Windows.Forms;
using laba1_OOP.Plugins;

namespace laba1_OOP
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        public int ChoiceEncryption;
        public int Key;
        public EncryptingPlugin encryptingPlugin;

        private void ReadParameters()
        {
            string fileName = "parameters.dat";
            FileStream fileStream = new FileStream(fileName, FileMode.OpenOrCreate);
            StreamReader streamReader = new StreamReader(fileStream);
            string temp = streamReader.ReadLine();
            if (!String.IsNullOrEmpty(temp))
            {
                ChoiceEncryption = Convert.ToInt32(temp);
                if (ChoiceEncryption == 2)
                    Key = Convert.ToInt32(streamReader.ReadLine());
            }
            streamReader.Close();
            fileStream.Close();
        }

        private void WriteParameters()
        {
            string fileName = "parameters.dat";
            FileStream fileStream = new FileStream(fileName, FileMode.Create);
            StreamWriter streamWriter = new StreamWriter(fileStream);
            streamWriter.WriteLine(ChoiceEncryption);
            if (ChoiceEncryption == 2)
                streamWriter.WriteLine(Key);
            streamWriter.Close();
            fileStream.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Key = Convert.ToInt32(KeyValue.Text);
            WriteParameters();
            if (ChoiceEncryption == 1)
                encryptingPlugin = new NonEncrypting();
            else if (ChoiceEncryption == 2)
                encryptingPlugin = new Encrypting();

            Close();
        }

        private void NonEncryptionRBtn_Click(object sender, EventArgs e)
        {
            ChoiceEncryption = 1;
        }

        private void RailwayFanceRBtn_Click(object sender, EventArgs e)
        {
            ChoiceEncryption = 2;
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            ReadParameters();
            if (ChoiceEncryption == 1)
            {
                NonEncryptionRBtn.Checked = true;
            }
            else if (ChoiceEncryption == 2)
            {
                KeyValue.Value = Key;
                RailwayFanceRBtn.Checked = true;
            }
        }
    }
}
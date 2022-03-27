using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using laba1_OOP.Plugins;
using LibraryFigure;
using Newtonsoft.Json;

namespace laba1_OOP
{
    public partial class Form1 : Form
    {
        private List<Figure> listOfFigures;

        public Form1()
        {
            InitializeComponent();
            Image image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = image;
        }

        private List<Figure> FilterListOfFigures()
        {
            List<Figure> filteredListOfFigerus = new List<Figure>();
            if (listOfFigures != null)
                for (int i = 0; i < listOfFigures.Count; i++)
                    if (listOfFigures[i] is Triangle ||
                        listOfFigures[i] is Rectangle ||
                        listOfFigures[i] is Rhombus ||
                        listOfFigures[i] is Ellips ||
                        listOfFigures[i] is Square ||
                        listOfFigures[i] is Line)
                        filteredListOfFigerus.Add(listOfFigures[i]);
            return filteredListOfFigerus;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Line line = new Line();
            tempFigure = line;
            label2.Text = "oтрезок";
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            listOfFigures.Clear();
            сlearBitmap();
            encryptingPlugin.Serialization(FilterListOfFigures(), KeyValue);
        }

        private void сlearBitmap()
        {
            Bitmap btm = (Bitmap) pictureBox1.Image;
            Graphics graphics = Graphics.FromImage(btm);
            graphics.Clear(Color.White);
            pictureBox1.Image = btm;
            listBox1.Items.Clear();
        }

        private void RectangleBtn_Click(object sender, EventArgs e)
        {
            Rectangle rectangle = new Rectangle();
            tempFigure = rectangle;
            label2.Text = "прямоугольник";
        }

        private void EllipsBtn_Click(object sender, EventArgs e)
        {
            Ellips ellips = new Ellips();
            tempFigure = ellips;
            label2.Text = "эллипс";
        }

        private void SquareBtn_Click(object sender, EventArgs e)
        {
            Square square = new Square();
            tempFigure = square;
            label2.Text = "квадрат";
        }


        private void TriangleBtn_Click(object sender, EventArgs e)
        {
            Triangle triangle = new Triangle();
            tempFigure = triangle;
            label2.Text = "треугольник";
        }

        private void Rhombus_Click(object sender, EventArgs e)
        {
            Rhombus rhombus = new Rhombus();
            tempFigure = rhombus;
            label2.Text = "ромб";
        }

        private int startX, startY;
        private int endX, endY;
        private bool flag = false;
        private Bitmap tempBitmap;
        private Figure tempFigure;

        private Color tempColor;
        private int tempSize;

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            startX = e.X;
            startY = e.Y;
            flag = true;
            if (tempFigure != null)
                tempFigure = (Figure) Activator.CreateInstance(tempFigure.GetType());
            tempBitmap = (Bitmap) pictureBox1.Image.Clone();
        }

        private void updateListBox()
        {
            listBox1.Items.Clear();
            if (listOfFigures != null)
                for (int i = 0; i < listOfFigures.Count; i++)
                {
                    if (listOfFigures.Count > 0)
                        listBox1.Items.Add(listOfFigures[i].ToString());
                }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            endX = e.X;
            endY = e.Y;
            flag = false;
            if ((tempFigure != null) && (endX != startX) && (endY != startY))
            {
                listOfFigures.Add(tempFigure);
                updateListBox();
                encryptingPlugin.Serialization(FilterListOfFigures(), KeyValue);
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag == true)
            {
                endX = e.X;
                endY = e.Y;
                drawFigure();
            }
        }

        private void drawFigure()
        {
            pictureBox1.Image.Dispose();
            pictureBox1.Image = new Bitmap(tempBitmap);
            if (tempFigure != null)
            {
                tempFigure.colorPen = tempColor;
                tempFigure.sizePen = tempSize;
                tempFigure.Resize(startX, startY, endX, endY);
                Bitmap btm = (Bitmap) pictureBox1.Image;
                tempFigure.Draw(btm);
                pictureBox1.Image = btm;
            }
        }


        private bool changeFlag = false;

        private void button1_Click_1(object sender, EventArgs e)
        {
            tempColor = Color.Red;
            if (changeFlag == true)
                changeFigure();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tempColor = Color.Coral;
            if (changeFlag == true)
                changeFigure();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tempColor = Color.Yellow;
            if (changeFlag == true)
                changeFigure();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            tempColor = Color.PaleGreen;
            if (changeFlag == true)
                changeFigure();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tempColor = Color.LightSeaGreen;
            if (changeFlag == true)
                changeFigure();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tempColor = Color.Lime;
            if (changeFlag == true)
                changeFigure();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            tempColor = Color.ForestGreen;
            if (changeFlag == true)
                changeFigure();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tempColor = Color.Cyan;
            if (changeFlag == true)
                changeFigure();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tempColor = Color.DodgerBlue;
            if (changeFlag == true)
                changeFigure();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tempColor = Color.MediumBlue;
            if (changeFlag == true)
                changeFigure();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tempColor = Color.Violet;
            if (changeFlag == true)
                changeFigure();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            tempColor = Color.Magenta;
            if (changeFlag == true)
                changeFigure();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            tempColor = Color.DeepPink;
            if (changeFlag == true)
                changeFigure();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            tempColor = Color.DarkViolet;
            if (changeFlag == true)
                changeFigure();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            tempColor = Color.Black;
            if (changeFlag == true)
                changeFigure();
        }

        
        private EncryptingPlugin encryptingPlugin;

        private void updateBitmap()
        {
            Bitmap btm = new Bitmap(pictureBox1.Image);
            pictureBox1.Image.Dispose();
            pictureBox1.Image = btm;
            if (listOfFigures != null)
                for (int i = 0; i < listOfFigures.Count; i++)
                {
                    listOfFigures[i].Draw(btm);
                }

            encryptingPlugin.Serialization(FilterListOfFigures(), KeyValue);
        }

        private void deleteFigure()
        {
            listOfFigures.RemoveAt(listBox1.SelectedIndex);
            сlearBitmap();
            updateBitmap();
            updateListBox();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if ((listBox1.Items.Count > 0) && (listBox1.SelectedIndex > -1))
            {
                deleteFigure();
            }
            else
            {
                MessageBox.Show("Выберите фигуру для удаления =)");
            }
        }

        private void changeFigure()
        {
            if ((listBox1.Items.Count > 0) && (listBox1.SelectedIndex > -1))
            {
                listOfFigures[listBox1.SelectedIndex].sizePen = tempSize;
                listOfFigures[listBox1.SelectedIndex].colorPen = tempColor;
                Bitmap btm = new Bitmap(pictureBox1.Image.Width, pictureBox1.Image.Height);
                pictureBox1.Image.Dispose();
                pictureBox1.Image = btm;
                updateBitmap();
                btm.Dispose();
            }
        }

        private void ChangeBtn_Click(object sender, EventArgs e)
        {
            if ((listBox1.SelectedIndex > -1))
            {
                changeFlag = true;
            }
            else
            {
                MessageBox.Show("Выберите фигуру для редактирования =)");
            }
        }

        private void trackBar1_ValueChanged_1(object sender, EventArgs e)
        {
            tempSize = trackBar1.Value;
            if (changeFlag == true)
                changeFigure();
        }


        List<Type> listOfClassesFromPlugin = new List<Type>();

        private void SomeBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listOfClassesFromPlugin.Count; i++)
                if (listOfClassesFromPlugin[i].Name == ((Button) sender).Name)
                {
                    tempFigure = (Figure) Activator.CreateInstance(listOfClassesFromPlugin[i]);
                    label2.Text = tempFigure.ToString();
                }
        }

        int x = 10;

        private Button ChangeBtnProperties(Button btnForChange)
        {
            btnForChange.Size = new Size(173, 24);
            btnForChange.Location = new Point(x, 508);
            btnForChange.FlatStyle = FlatStyle.Flat;
            btnForChange.BackColor = Color.White;
            btnForChange.Font = new Font("Georgia", 9, FontStyle.Bold);
            btnForChange.BringToFront();
            Controls.Add(btnForChange);
            x += 178;
            return btnForChange;
        }

        private void AddTypeFigure(Type type)
        {
            bool contains = false;
            for (int i = 0; i < listOfClassesFromPlugin.Count; i++)
                if (listOfClassesFromPlugin[i].Name == type.Name)
                    contains = true;
            if (contains == false)
            {
                Figure figure = (Figure) Activator.CreateInstance(type);
                Button newButton = new Button();

                newButton.Name = type.Name;
                newButton.Text = figure.ToString();

                newButton = ChangeBtnProperties(newButton);
                newButton.Click += SomeBtn_Click;

                listOfClassesFromPlugin.Add(type);
            }
        }

        public List<Type> GetFigureClassesFromPlugins()
        {
            List<Type> types = new List<Type>();
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string pluginPath = folderBrowserDialog.SelectedPath;
                var pluginFiles = Directory.GetFiles(pluginPath, "*.dll");
                foreach (var file in pluginFiles)
                {
                    Assembly myDll = Assembly.LoadFrom(file);
                    //ищем типы, которые наследуются от Figure,
                    var allDllTypes = myDll.GetTypes();
                    foreach (var type in allDllTypes)
                    {
                        if (type.BaseType.FullName == typeof(Figure).FullName)
                            types.Add(type);
                    }
                }
            }

            return types;
        }

        private void LoadPluginsBtn_Click(object sender, EventArgs e)
        {
            List<Type> types = GetFigureClassesFromPlugins();
            for (int i = 0; i < types.Count; i++)
                AddTypeFigure(types[i]);
        }
        //
        
        private void ReadParameters()
        {
            string fileName = "parameters.dat";
            FileStream fileStream = new FileStream(fileName, FileMode.OpenOrCreate);
            StreamReader streamReader = new StreamReader(fileStream);
            string temp = streamReader.ReadLine();
            if (!String.IsNullOrEmpty(temp))
            {
                SelectedEncrypt = Convert.ToInt32(temp);
                if (SelectedEncrypt == 2)
                    KeyValue = Convert.ToInt32(streamReader.ReadLine());
            }

            streamReader.Close();
            fileStream.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadParameters();
            if (SelectedEncrypt == 1)
                encryptingPlugin = new NonEncrypting();
            else if (SelectedEncrypt == 2)
                encryptingPlugin = new Encrypting();

            tempColor = Color.Red;
        }

        private int KeyValue = 1;
        private int SelectedEncrypt = 1;

        public void OpenButtons()
        {
            LineBtn.Enabled = true;
            Rhombus.Enabled = true;
            TriangleBtn.Enabled = true;
            RectangleBtn.Enabled = true;
            SquareBtn.Enabled = true;
            EllipsBtn.Enabled = true;
            SettingsBtn.Enabled = true;
            LoadPluginsBtn.Enabled = true;
            ClearBtn.Enabled = true;
            DeleteBtn.Enabled = true;
            ChangeBtn.Enabled = true;
        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            try
            {
                listOfFigures = encryptingPlugin.Deserialization(KeyValue);
                updateBitmap();
                updateListBox();
            }
            catch
            {
                MessageBox.Show("Ошибка! Возможно, параметры шифрования были изменены.");
            }

            OpenButtons();
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm1 = new SettingsForm();
            settingsForm1.Key = KeyValue;
            if (settingsForm1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Изменения успешно сохранены!");
                KeyValue = settingsForm1.Key;
                encryptingPlugin = settingsForm1.encryptingPlugin;
                encryptingPlugin.Serialization(listOfFigures, KeyValue);
            }
        }
    }
}
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
using laba1_OOP.Adapter.AdapterClasses;
using laba1_OOP.Plugins;

using BaseFigureLib;
using Newtonsoft.Json;

namespace laba1_OOP
{
    public partial class Form1 : Form
    {
        private List<IFigure> listOfFigures;
        
        private DisplayFigure displayFigure;

        public Form1()
        {
            InitializeComponent();
            Image image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = image;
            displayFigure = new DisplayFigure();
        }

        private List<IFigure> FilterListOfFigures()
        {
            List<IFigure> filteredListOfFigerus = new List<IFigure>();
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
            Singleton.Serializer.Serialize(FilterListOfFigures());
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
        
        private IFigure tempFigure;

        private Color tempColor;
        private int tempSize;

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            startX = e.X;
            startY = e.Y;
            flag = true;
            if (tempFigure != null)
                tempFigure = (IFigure) Activator.CreateInstance(tempFigure.GetType());
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
                Singleton.Serializer.Serialize(FilterListOfFigures());
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
                displayFigure.SetProperties( tempFigure,tempColor,tempSize);
                displayFigure.Resize(tempFigure, startX, startY, endX, endY);
                Bitmap btm = (Bitmap) pictureBox1.Image;
                displayFigure.Draw(tempFigure, btm);
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

        private void button13_Click_1(object sender, EventArgs e)
        {
            tempColor = Color.Black;
            if (changeFlag == true)
                changeFigure();
        }

        private void updateBitmap()
        {
            Bitmap btm = new Bitmap(pictureBox1.Image);
            pictureBox1.Image.Dispose();
            pictureBox1.Image = btm;
            if (listOfFigures != null)
                for (int i = 0; i < listOfFigures.Count; i++)
                {
                    displayFigure.Draw( listOfFigures[i], btm);
                }
            
            Singleton.Serializer.Serialize(FilterListOfFigures());
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
                displayFigure.SetProperties( listOfFigures[listBox1.SelectedIndex],tempColor,tempSize);
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
                    tempFigure = (IFigure) Activator.CreateInstance(listOfClassesFromPlugin[i]);
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
                IFigure figure = (IFigure) Activator.CreateInstance(type);
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
                        if (type.BaseType.FullName == typeof(IFigure).FullName)
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

      
        private void Form1_Load(object sender, EventArgs e)
        {
            
            listOfFigures = Singleton.Serializer.Deserialize();
            updateBitmap();
            updateListBox();
            tempColor = Color.Red;
        }

        private void FilledCircleBtn_Click(object sender, EventArgs e)
        {
            AdapterFilledCircle adapterFilledCircle = new AdapterFilledCircle();
            tempFigure = adapterFilledCircle;
            label2.Text = "закрашенный круг";
        }

        private void FilledRectangleBtn_Click(object sender, EventArgs e)
        {
            AdaptedFilledRectangle adapterFilledRectangle = new AdaptedFilledRectangle();
            tempFigure = adapterFilledRectangle;
            label2.Text = "закрашенный прямоугольник";
        }

        private void FilledTriangleBtn_Click(object sender, EventArgs e)
        {
            AdaptedFilledTriangle adapterFilledTriangle = new AdaptedFilledTriangle();
            tempFigure = adapterFilledTriangle;
            label2.Text = "закрашенный треугольник";
        }

        private void FilledPhombusBtn_Click(object sender, EventArgs e)
        {
            AdaptedFilledRhombus adapterFilledRhombus = new AdaptedFilledRhombus();
            tempFigure = adapterFilledRhombus;
            label2.Text = "закрашенный ромб";
        }

        private void FilledHexagonBtn_Click(object sender, EventArgs e)
        {
            AdaptedFilledHexagon adapterFilledHexagon = new AdaptedFilledHexagon();
            tempFigure = adapterFilledHexagon;
            label2.Text = "закрашенный шестиугольник";
        }
        
    }
}
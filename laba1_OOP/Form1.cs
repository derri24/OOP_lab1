using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace laba1_OOP
{
    public partial class Form1 : Form
    {
        private ListOfFigures listOfFigures;

        public Form1()
        {
            InitializeComponent();
            Image image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = image;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Line line = new Line(10, 115, 100, 195);
            listOfFigures.figures.Add(line);
            LineBtn.Enabled = false;
            MessageBox.Show("Фигура 'Отрезок' добавлена в список для отображения. ", "Сообщение",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Bitmap btm = (Bitmap) pictureBox1.Image;
            Graphics graphics = Graphics.FromImage(btm);
            graphics.Clear(Color.White);
            pictureBox1.Image = btm;

            RectangleBtn.Enabled = true;
            TriangleBtn.Enabled = true;
            LineBtn.Enabled = true;
            SquareBtn.Enabled = true;
            EllipsBtn.Enabled = true;
            CircleBtn.Enabled = true;
            TrapezeBtn.Enabled = true;
            PolygonBtn.Enabled = true;

            listOfFigures.figures.Clear();
        }

        private void RectangleBtn_Click(object sender, EventArgs e)
        {
            Rectangle rectangle = new Rectangle(145, 25, 110, 70);
            listOfFigures.figures.Add(rectangle);
            RectangleBtn.Enabled = false;
            MessageBox.Show("Фигура 'Прямоугольник' добавлена в список для отображения. ", "Сообщение",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EllipsBtn_Click(object sender, EventArgs e)
        {
            Ellips ellips = new Ellips(140, 230, 115, 70);
            listOfFigures.figures.Add(ellips);
            EllipsBtn.Enabled = false;
            MessageBox.Show("Фигура 'Эллипс' добавлена в список для отображения. ", "Сообщение",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SquareBtn_Click(object sender, EventArgs e)
        {
            Square square = new Square(10, 225, 85);
            listOfFigures.figures.Add(square);
            SquareBtn.Enabled = false;
            MessageBox.Show("Фигура 'Квадрат' добавлена в список для отображения. ", "Сообщение",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CircleBtn_Click(object sender, EventArgs e)
        {
            Circle circle = new Circle(285, 115, 90);
            listOfFigures.figures.Add(circle);
            CircleBtn.Enabled = false;
            MessageBox.Show("Фигура 'Круг' добавлена в список для отображения. ", "Сообщение",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void TriangleBtn_Click(object sender, EventArgs e)
        {
            Triangle triangle = new Triangle(10, 95, 70, 25, 130, 95);
            listOfFigures.figures.Add(triangle);
            TriangleBtn.Enabled = false;
            MessageBox.Show("Фигура 'Треугольник' добавлена в список для отображения. ", "Сообщение",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TrapezeBtn_Click(object sender, EventArgs e)
        {
            Trapeze trapeze = new Trapeze(275, 95, 305, 45, 375, 45, 405, 95);
            listOfFigures.figures.Add(trapeze);
            TrapezeBtn.Enabled = false;
            MessageBox.Show("Фигура 'Трапеция' добавлена в список для отображения. ", "Сообщение",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PolygonBtn_Click(object sender, EventArgs e)
        {
            Polygon polygon = new Polygon(150, 160, 170, 200, 220, 200, 240,
                160, 220, 120, 170, 120);

            listOfFigures.figures.Add(polygon);
            PolygonBtn.Enabled = false;
            MessageBox.Show("Фигура 'Многоугольник' добавлена в список для отображения. ", "Сообщение",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listOfFigures = new ListOfFigures();
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            Bitmap btm = (Bitmap) pictureBox1.Image;
            for (int i = 0; i < listOfFigures.figures.Count; i++)
            {
                listOfFigures.figures[i].Draw(btm);
            }
            pictureBox1.Image = btm;
        }
    }

   
}
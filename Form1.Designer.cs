namespace laba1_OOP
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LineBtn = new System.Windows.Forms.Button();
            this.TriangleBtn = new System.Windows.Forms.Button();
            this.EllipsBtn = new System.Windows.Forms.Button();
            this.SquareBtn = new System.Windows.Forms.Button();
            this.RectangleBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Rhombus = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ChangeBtn = new System.Windows.Forms.Button();
            this.LoadPluginsBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.FilledCircleBtn = new System.Windows.Forms.Button();
            this.FilledHexagonBtn = new System.Windows.Forms.Button();
            this.FilledRectangleBtn = new System.Windows.Forms.Button();
            this.FilledPhombusBtn = new System.Windows.Forms.Button();
            this.FilledTriangleBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // LineBtn
            // 
            this.LineBtn.BackColor = System.Drawing.Color.White;
            this.LineBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LineBtn.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.LineBtn.Location = new System.Drawing.Point(16, 590);
            this.LineBtn.Name = "LineBtn";
            this.LineBtn.Size = new System.Drawing.Size(131, 29);
            this.LineBtn.TabIndex = 0;
            this.LineBtn.Text = "Отрезок";
            this.LineBtn.UseVisualStyleBackColor = false;
            this.LineBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // TriangleBtn
            // 
            this.TriangleBtn.BackColor = System.Drawing.Color.White;
            this.TriangleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TriangleBtn.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.TriangleBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TriangleBtn.Location = new System.Drawing.Point(293, 590);
            this.TriangleBtn.Name = "TriangleBtn";
            this.TriangleBtn.Size = new System.Drawing.Size(161, 29);
            this.TriangleBtn.TabIndex = 1;
            this.TriangleBtn.Text = "Треугольник";
            this.TriangleBtn.UseVisualStyleBackColor = false;
            this.TriangleBtn.Click += new System.EventHandler(this.TriangleBtn_Click);
            // 
            // EllipsBtn
            // 
            this.EllipsBtn.BackColor = System.Drawing.Color.White;
            this.EllipsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EllipsBtn.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.EllipsBtn.Location = new System.Drawing.Point(766, 591);
            this.EllipsBtn.Name = "EllipsBtn";
            this.EllipsBtn.Size = new System.Drawing.Size(144, 28);
            this.EllipsBtn.TabIndex = 7;
            this.EllipsBtn.Text = "Эллипс";
            this.EllipsBtn.UseVisualStyleBackColor = false;
            this.EllipsBtn.Click += new System.EventHandler(this.EllipsBtn_Click);
            // 
            // SquareBtn
            // 
            this.SquareBtn.BackColor = System.Drawing.Color.White;
            this.SquareBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SquareBtn.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.SquareBtn.Location = new System.Drawing.Point(153, 590);
            this.SquareBtn.Name = "SquareBtn";
            this.SquareBtn.Size = new System.Drawing.Size(134, 29);
            this.SquareBtn.TabIndex = 2;
            this.SquareBtn.Text = "Квадрат";
            this.SquareBtn.UseVisualStyleBackColor = false;
            this.SquareBtn.Click += new System.EventHandler(this.SquareBtn_Click);
            // 
            // RectangleBtn
            // 
            this.RectangleBtn.BackColor = System.Drawing.Color.White;
            this.RectangleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RectangleBtn.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.RectangleBtn.Location = new System.Drawing.Point(460, 591);
            this.RectangleBtn.Name = "RectangleBtn";
            this.RectangleBtn.Size = new System.Drawing.Size(173, 29);
            this.RectangleBtn.TabIndex = 3;
            this.RectangleBtn.Text = "Прямоугольник";
            this.RectangleBtn.UseVisualStyleBackColor = false;
            this.RectangleBtn.Click += new System.EventHandler(this.RectangleBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.Color.White;
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBtn.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.ClearBtn.Location = new System.Drawing.Point(916, 551);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(237, 28);
            this.ClearBtn.TabIndex = 9;
            this.ClearBtn.Text = "Очистить";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictureBox1.Location = new System.Drawing.Point(16, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(894, 549);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Выбранный инструмент: ";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Georgia", 7.8F, ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(246, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(448, 23);
            this.label2.TabIndex = 12;
            // 
            // Rhombus
            // 
            this.Rhombus.BackColor = System.Drawing.Color.White;
            this.Rhombus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rhombus.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.Rhombus.Location = new System.Drawing.Point(639, 591);
            this.Rhombus.Name = "Rhombus";
            this.Rhombus.Size = new System.Drawing.Size(121, 29);
            this.Rhombus.TabIndex = 13;
            this.Rhombus.Text = "Ромб";
            this.Rhombus.UseVisualStyleBackColor = false;
            this.Rhombus.Click += new System.EventHandler(this.Rhombus_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Georgia", 9.2F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(916, 273);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(237, 202);
            this.listBox1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(916, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Список фигур: ";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button14);
            this.flowLayoutPanel1.Controls.Add(this.button8);
            this.flowLayoutPanel1.Controls.Add(this.button15);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.button10);
            this.flowLayoutPanel1.Controls.Add(this.button12);
            this.flowLayoutPanel1.Controls.Add(this.button7);
            this.flowLayoutPanel1.Controls.Add(this.button6);
            this.flowLayoutPanel1.Controls.Add(this.button11);
            this.flowLayoutPanel1.Controls.Add(this.button9);
            this.flowLayoutPanel1.Controls.Add(this.button13);
            this.flowLayoutPanel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(919, 34);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(234, 132);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 38);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.PaleGreen;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Location = new System.Drawing.Point(49, 3);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(40, 38);
            this.button14.TabIndex = 13;
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.MediumBlue;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(95, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(40, 38);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.ForestGreen;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Location = new System.Drawing.Point(141, 3);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(40, 38);
            this.button15.TabIndex = 14;
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Coral;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(187, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 38);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Yellow;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(3, 47);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 38);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(49, 47);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(40, 38);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Lime;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(95, 47);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 38);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Violet;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(141, 47);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(40, 38);
            this.button10.TabIndex = 9;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Magenta;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Location = new System.Drawing.Point(187, 47);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(40, 38);
            this.button12.TabIndex = 11;
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DodgerBlue;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(3, 91);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(40, 38);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Cyan;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(49, 91);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(40, 38);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.DeepPink;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(95, 91);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(40, 38);
            this.button11.TabIndex = 10;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.DarkViolet;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(141, 91);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(40, 38);
            this.button9.TabIndex = 8;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click_1);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Black;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Location = new System.Drawing.Point(187, 91);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(40, 38);
            this.button13.TabIndex = 15;
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Location = new System.Drawing.Point(919, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 60);
            this.panel1.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label5.Location = new System.Drawing.Point(3, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 17);
            this.label5.TabIndex = 2;
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.Location = new System.Drawing.Point(8, 13);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(219, 37);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged_1);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.White;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.DeleteBtn.Location = new System.Drawing.Point(916, 517);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(237, 28);
            this.DeleteBtn.TabIndex = 18;
            this.DeleteBtn.Text = "Удалить";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ChangeBtn
            // 
            this.ChangeBtn.BackColor = System.Drawing.Color.White;
            this.ChangeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeBtn.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.ChangeBtn.Location = new System.Drawing.Point(916, 483);
            this.ChangeBtn.Name = "ChangeBtn";
            this.ChangeBtn.Size = new System.Drawing.Size(237, 28);
            this.ChangeBtn.TabIndex = 19;
            this.ChangeBtn.Text = "Редактировать";
            this.ChangeBtn.UseVisualStyleBackColor = false;
            this.ChangeBtn.Click += new System.EventHandler(this.ChangeBtn_Click);
            // 
            // LoadPluginsBtn
            // 
            this.LoadPluginsBtn.BackColor = System.Drawing.Color.White;
            this.LoadPluginsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadPluginsBtn.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.LoadPluginsBtn.Location = new System.Drawing.Point(916, 591);
            this.LoadPluginsBtn.Name = "LoadPluginsBtn";
            this.LoadPluginsBtn.Size = new System.Drawing.Size(237, 29);
            this.LoadPluginsBtn.TabIndex = 22;
            this.LoadPluginsBtn.Text = "Загрузить плагины";
            this.LoadPluginsBtn.UseVisualStyleBackColor = false;
            this.LoadPluginsBtn.Click += new System.EventHandler(this.LoadPluginsBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FilledCircleBtn
            // 
            this.FilledCircleBtn.BackColor = System.Drawing.Color.White;
            this.FilledCircleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilledCircleBtn.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.FilledCircleBtn.Location = new System.Drawing.Point(362, 626);
            this.FilledCircleBtn.Name = "FilledCircleBtn";
            this.FilledCircleBtn.Size = new System.Drawing.Size(271, 28);
            this.FilledCircleBtn.TabIndex = 26;
            this.FilledCircleBtn.Text = "Закрашенный эллипс";
            this.FilledCircleBtn.UseVisualStyleBackColor = false;
            this.FilledCircleBtn.Click += new System.EventHandler(this.FilledCircleBtn_Click);
            // 
            // FilledHexagonBtn
            // 
            this.FilledHexagonBtn.BackColor = System.Drawing.Color.White;
            this.FilledHexagonBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilledHexagonBtn.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.FilledHexagonBtn.Location = new System.Drawing.Point(17, 659);
            this.FilledHexagonBtn.Name = "FilledHexagonBtn";
            this.FilledHexagonBtn.Size = new System.Drawing.Size(340, 28);
            this.FilledHexagonBtn.TabIndex = 27;
            this.FilledHexagonBtn.Text = "Закрашенный шестиугольник";
            this.FilledHexagonBtn.UseVisualStyleBackColor = false;
            this.FilledHexagonBtn.Click += new System.EventHandler(this.FilledHexagonBtn_Click);
            // 
            // FilledRectangleBtn
            // 
            this.FilledRectangleBtn.BackColor = System.Drawing.Color.White;
            this.FilledRectangleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilledRectangleBtn.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.FilledRectangleBtn.Location = new System.Drawing.Point(17, 625);
            this.FilledRectangleBtn.Name = "FilledRectangleBtn";
            this.FilledRectangleBtn.Size = new System.Drawing.Size(339, 28);
            this.FilledRectangleBtn.TabIndex = 28;
            this.FilledRectangleBtn.Text = "Закрашенный прямоугольник";
            this.FilledRectangleBtn.UseVisualStyleBackColor = false;
            this.FilledRectangleBtn.Click += new System.EventHandler(this.FilledRectangleBtn_Click);
            // 
            // FilledPhombusBtn
            // 
            this.FilledPhombusBtn.BackColor = System.Drawing.Color.White;
            this.FilledPhombusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilledPhombusBtn.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.FilledPhombusBtn.Location = new System.Drawing.Point(639, 625);
            this.FilledPhombusBtn.Name = "FilledPhombusBtn";
            this.FilledPhombusBtn.Size = new System.Drawing.Size(271, 28);
            this.FilledPhombusBtn.TabIndex = 29;
            this.FilledPhombusBtn.Text = "Закрашенный ромб";
            this.FilledPhombusBtn.UseVisualStyleBackColor = false;
            this.FilledPhombusBtn.Click += new System.EventHandler(this.FilledPhombusBtn_Click);
            // 
            // FilledTriangleBtn
            // 
            this.FilledTriangleBtn.BackColor = System.Drawing.Color.White;
            this.FilledTriangleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilledTriangleBtn.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.FilledTriangleBtn.Location = new System.Drawing.Point(362, 660);
            this.FilledTriangleBtn.Name = "FilledTriangleBtn";
            this.FilledTriangleBtn.Size = new System.Drawing.Size(306, 28);
            this.FilledTriangleBtn.TabIndex = 30;
            this.FilledTriangleBtn.Text = "Закрашенный треугольник";
            this.FilledTriangleBtn.UseVisualStyleBackColor = false;
            this.FilledTriangleBtn.Click += new System.EventHandler(this.FilledTriangleBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1165, 708);
            this.Controls.Add(this.FilledTriangleBtn);
            this.Controls.Add(this.FilledPhombusBtn);
            this.Controls.Add(this.FilledRectangleBtn);
            this.Controls.Add(this.FilledHexagonBtn);
            this.Controls.Add(this.FilledCircleBtn);
            this.Controls.Add(this.LoadPluginsBtn);
            this.Controls.Add(this.ChangeBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Rhombus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.RectangleBtn);
            this.Controls.Add(this.SquareBtn);
            this.Controls.Add(this.EllipsBtn);
            this.Controls.Add(this.TriangleBtn);
            this.Controls.Add(this.LineBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(15, 15);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.trackBar1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button FilledHexagonBtn;
        private System.Windows.Forms.Button FilledRectangleBtn;
        private System.Windows.Forms.Button FilledPhombusBtn;
        private System.Windows.Forms.Button FilledTriangleBtn;

        private System.Windows.Forms.Button FilledCircleBtn;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button ChangeBtn;

        private System.Windows.Forms.TrackBar trackBar1;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Button Rhombus;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        #endregion

        private System.Windows.Forms.Button LineBtn;
        private System.Windows.Forms.Button TriangleBtn;
        private System.Windows.Forms.Button EllipsBtn;
        private System.Windows.Forms.Button SquareBtn;
        private System.Windows.Forms.Button RectangleBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button LoadPluginsBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}


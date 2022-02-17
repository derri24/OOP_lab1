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
            this.CircleBtn = new System.Windows.Forms.Button();
            this.EllipsBtn = new System.Windows.Forms.Button();
            this.SquareBtn = new System.Windows.Forms.Button();
            this.RectangleBtn = new System.Windows.Forms.Button();
            this.TrapezeBtn = new System.Windows.Forms.Button();
            this.PolygonBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DrawBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LineBtn
            // 
            this.LineBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LineBtn.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.LineBtn.Location = new System.Drawing.Point(12, 28);
            this.LineBtn.Name = "LineBtn";
            this.LineBtn.Size = new System.Drawing.Size(162, 32);
            this.LineBtn.TabIndex = 0;
            this.LineBtn.Text = "Отрезок";
            this.LineBtn.UseVisualStyleBackColor = true;
            this.LineBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // TriangleBtn
            // 
            this.TriangleBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TriangleBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.TriangleBtn.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.TriangleBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TriangleBtn.Location = new System.Drawing.Point(12, 66);
            this.TriangleBtn.Name = "TriangleBtn";
            this.TriangleBtn.Size = new System.Drawing.Size(162, 32);
            this.TriangleBtn.TabIndex = 1;
            this.TriangleBtn.Text = "Треугольник";
            this.TriangleBtn.UseVisualStyleBackColor = false;
            this.TriangleBtn.Click += new System.EventHandler(this.TriangleBtn_Click);
            // 
            // CircleBtn
            // 
            this.CircleBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CircleBtn.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.CircleBtn.Location = new System.Drawing.Point(12, 256);
            this.CircleBtn.Name = "CircleBtn";
            this.CircleBtn.Size = new System.Drawing.Size(162, 32);
            this.CircleBtn.TabIndex = 6;
            this.CircleBtn.Text = "Круг";
            this.CircleBtn.UseVisualStyleBackColor = true;
            this.CircleBtn.Click += new System.EventHandler(this.CircleBtn_Click);
            // 
            // EllipsBtn
            // 
            this.EllipsBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.EllipsBtn.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.EllipsBtn.Location = new System.Drawing.Point(12, 294);
            this.EllipsBtn.Name = "EllipsBtn";
            this.EllipsBtn.Size = new System.Drawing.Size(162, 32);
            this.EllipsBtn.TabIndex = 7;
            this.EllipsBtn.Text = "Эллипс";
            this.EllipsBtn.UseVisualStyleBackColor = true;
            this.EllipsBtn.Click += new System.EventHandler(this.EllipsBtn_Click);
            // 
            // SquareBtn
            // 
            this.SquareBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SquareBtn.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.SquareBtn.Location = new System.Drawing.Point(12, 104);
            this.SquareBtn.Name = "SquareBtn";
            this.SquareBtn.Size = new System.Drawing.Size(162, 32);
            this.SquareBtn.TabIndex = 2;
            this.SquareBtn.Text = "Квадрат";
            this.SquareBtn.UseVisualStyleBackColor = true;
            this.SquareBtn.Click += new System.EventHandler(this.SquareBtn_Click);
            // 
            // RectangleBtn
            // 
            this.RectangleBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RectangleBtn.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.RectangleBtn.Location = new System.Drawing.Point(12, 142);
            this.RectangleBtn.Name = "RectangleBtn";
            this.RectangleBtn.Size = new System.Drawing.Size(162, 32);
            this.RectangleBtn.TabIndex = 3;
            this.RectangleBtn.Text = "Прямоугольник";
            this.RectangleBtn.UseVisualStyleBackColor = true;
            this.RectangleBtn.Click += new System.EventHandler(this.RectangleBtn_Click);
            // 
            // TrapezeBtn
            // 
            this.TrapezeBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.TrapezeBtn.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.TrapezeBtn.Location = new System.Drawing.Point(12, 180);
            this.TrapezeBtn.Name = "TrapezeBtn";
            this.TrapezeBtn.Size = new System.Drawing.Size(162, 32);
            this.TrapezeBtn.TabIndex = 4;
            this.TrapezeBtn.Text = "Трапеция";
            this.TrapezeBtn.UseVisualStyleBackColor = true;
            this.TrapezeBtn.Click += new System.EventHandler(this.TrapezeBtn_Click);
            // 
            // PolygonBtn
            // 
            this.PolygonBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.PolygonBtn.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.PolygonBtn.Location = new System.Drawing.Point(12, 218);
            this.PolygonBtn.Name = "PolygonBtn";
            this.PolygonBtn.Size = new System.Drawing.Size(162, 32);
            this.PolygonBtn.TabIndex = 5;
            this.PolygonBtn.Text = "Многоугольник";
            this.PolygonBtn.UseVisualStyleBackColor = true;
            this.PolygonBtn.Click += new System.EventHandler(this.PolygonBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.ClearBtn.Location = new System.Drawing.Point(12, 412);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(162, 32);
            this.ClearBtn.TabIndex = 9;
            this.ClearBtn.Text = "Очистить";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictureBox1.Location = new System.Drawing.Point(189, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(564, 416);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // DrawBtn
            // 
            this.DrawBtn.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.DrawBtn.Location = new System.Drawing.Point(12, 374);
            this.DrawBtn.Name = "DrawBtn";
            this.DrawBtn.Size = new System.Drawing.Size(162, 32);
            this.DrawBtn.TabIndex = 11;
            this.DrawBtn.Text = "Отрисовать\r\n";
            this.DrawBtn.UseVisualStyleBackColor = true;
            this.DrawBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Добавить в список: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(765, 462);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DrawBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.PolygonBtn);
            this.Controls.Add(this.TrapezeBtn);
            this.Controls.Add(this.RectangleBtn);
            this.Controls.Add(this.SquareBtn);
            this.Controls.Add(this.EllipsBtn);
            this.Controls.Add(this.CircleBtn);
            this.Controls.Add(this.TriangleBtn);
            this.Controls.Add(this.LineBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(15, 15);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button DrawBtn;

        #endregion

        private System.Windows.Forms.Button LineBtn;
        private System.Windows.Forms.Button TriangleBtn;
        private System.Windows.Forms.Button CircleBtn;
        private System.Windows.Forms.Button EllipsBtn;
        private System.Windows.Forms.Button SquareBtn;
        private System.Windows.Forms.Button RectangleBtn;
        private System.Windows.Forms.Button TrapezeBtn;
        private System.Windows.Forms.Button PolygonBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


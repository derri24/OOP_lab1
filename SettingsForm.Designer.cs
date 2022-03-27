using System.ComponentModel;

namespace laba1_OOP
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NonEncryptionRBtn = new System.Windows.Forms.RadioButton();
            this.RailwayFanceRBtn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.KeyValue = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.KeyValue)).BeginInit();
            this.SuspendLayout();
            // 
            // NonEncryptionRBtn
            // 
            this.NonEncryptionRBtn.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.NonEncryptionRBtn.Location = new System.Drawing.Point(21, 39);
            this.NonEncryptionRBtn.Name = "NonEncryptionRBtn";
            this.NonEncryptionRBtn.Size = new System.Drawing.Size(259, 25);
            this.NonEncryptionRBtn.TabIndex = 2;
            this.NonEncryptionRBtn.TabStop = true;
            this.NonEncryptionRBtn.Text = "Без шифрования";
            this.NonEncryptionRBtn.UseVisualStyleBackColor = true;
            this.NonEncryptionRBtn.Click += new System.EventHandler(this.NonEncryptionRBtn_Click);
            // 
            // RailwayFanceRBtn
            // 
            this.RailwayFanceRBtn.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.RailwayFanceRBtn.Location = new System.Drawing.Point(21, 70);
            this.RailwayFanceRBtn.Name = "RailwayFanceRBtn";
            this.RailwayFanceRBtn.Size = new System.Drawing.Size(285, 62);
            this.RailwayFanceRBtn.TabIndex = 4;
            this.RailwayFanceRBtn.TabStop = true;
            this.RailwayFanceRBtn.Text = "Шифруя железнодорожной изгородью\r\n\r\n c ключом";
            this.RailwayFanceRBtn.UseVisualStyleBackColor = true;
            this.RailwayFanceRBtn.Click += new System.EventHandler(this.RailwayFanceRBtn_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Реализация сохранения: ";
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SaveBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.SaveBtn.Location = new System.Drawing.Point(21, 177);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(276, 32);
            this.SaveBtn.TabIndex = 6;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // KeyValue
            // 
            this.KeyValue.Location = new System.Drawing.Point(231, 133);
            this.KeyValue.Maximum = new decimal(new int[] {30, 0, 0, 0});
            this.KeyValue.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.KeyValue.Name = "KeyValue";
            this.KeyValue.ReadOnly = true;
            this.KeyValue.Size = new System.Drawing.Size(49, 22);
            this.KeyValue.TabIndex = 7;
            this.KeyValue.Value = new decimal(new int[] {1, 0, 0, 0});
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label2.Location = new System.Drawing.Point(21, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ключ для шифрования: ";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 221);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.KeyValue);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RailwayFanceRBtn);
            this.Controls.Add(this.NonEncryptionRBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize) (this.KeyValue)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.NumericUpDown KeyValue;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button SaveBtn;

        private System.Windows.Forms.RadioButton RailwayFanceRBtn;
        private System.Windows.Forms.RadioButton NonEncryptionRBtn;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}
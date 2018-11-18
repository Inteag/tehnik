namespace WindowsFormsApp1
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Soh = new System.Windows.Forms.Button();
            this.Pb1 = new System.Windows.Forms.PictureBox();
            this.Pb2 = new System.Windows.Forms.PictureBox();
            this.Pb3 = new System.Windows.Forms.PictureBox();
            this.Pb4 = new System.Windows.Forms.PictureBox();
            this.Pov = new System.Windows.Forms.Button();
            this.Inv = new System.Windows.Forms.Button();
            this.Ser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Vse = new System.Windows.Forms.Button();
            this.Pb5 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Two = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Pb6 = new System.Windows.Forms.PictureBox();
            this.Ochis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb6)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Soh
            // 
            this.Soh.Location = new System.Drawing.Point(27, 203);
            this.Soh.Name = "Soh";
            this.Soh.Size = new System.Drawing.Size(92, 42);
            this.Soh.TabIndex = 0;
            this.Soh.Text = "открыть";
            this.Soh.UseVisualStyleBackColor = true;
            this.Soh.Click += new System.EventHandler(this.Soh_Click);
            // 
            // Pb1
            // 
            this.Pb1.Location = new System.Drawing.Point(81, 12);
            this.Pb1.Name = "Pb1";
            this.Pb1.Size = new System.Drawing.Size(159, 132);
            this.Pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb1.TabIndex = 1;
            this.Pb1.TabStop = false;
            // 
            // Pb2
            // 
            this.Pb2.Location = new System.Drawing.Point(285, 12);
            this.Pb2.Name = "Pb2";
            this.Pb2.Size = new System.Drawing.Size(159, 132);
            this.Pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb2.TabIndex = 2;
            this.Pb2.TabStop = false;
            // 
            // Pb3
            // 
            this.Pb3.Location = new System.Drawing.Point(464, 12);
            this.Pb3.Name = "Pb3";
            this.Pb3.Size = new System.Drawing.Size(159, 132);
            this.Pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb3.TabIndex = 3;
            this.Pb3.TabStop = false;
            // 
            // Pb4
            // 
            this.Pb4.Location = new System.Drawing.Point(655, 12);
            this.Pb4.Name = "Pb4";
            this.Pb4.Size = new System.Drawing.Size(159, 132);
            this.Pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb4.TabIndex = 4;
            this.Pb4.TabStop = false;
            // 
            // Pov
            // 
            this.Pov.Location = new System.Drawing.Point(138, 203);
            this.Pov.Name = "Pov";
            this.Pov.Size = new System.Drawing.Size(102, 42);
            this.Pov.TabIndex = 5;
            this.Pov.Text = "Поворот";
            this.Pov.UseVisualStyleBackColor = true;
            this.Pov.Click += new System.EventHandler(this.Pov_Click);
            // 
            // Inv
            // 
            this.Inv.Location = new System.Drawing.Point(254, 203);
            this.Inv.Name = "Inv";
            this.Inv.Size = new System.Drawing.Size(97, 42);
            this.Inv.TabIndex = 6;
            this.Inv.Text = "Инверсия";
            this.Inv.UseVisualStyleBackColor = true;
            this.Inv.Click += new System.EventHandler(this.Inv_Click);
            // 
            // Ser
            // 
            this.Ser.Location = new System.Drawing.Point(27, 270);
            this.Ser.Name = "Ser";
            this.Ser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Ser.Size = new System.Drawing.Size(92, 42);
            this.Ser.TabIndex = 7;
            this.Ser.Text = "Оттенок серого";
            this.Ser.UseVisualStyleBackColor = true;
            this.Ser.Click += new System.EventHandler(this.Ser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 8;
            // 
            // Vse
            // 
            this.Vse.Location = new System.Drawing.Point(138, 270);
            this.Vse.Name = "Vse";
            this.Vse.Size = new System.Drawing.Size(102, 42);
            this.Vse.TabIndex = 9;
            this.Vse.Text = "Всё";
            this.Vse.UseVisualStyleBackColor = true;
            this.Vse.Click += new System.EventHandler(this.Vse_Click_1);
            // 
            // Pb5
            // 
            this.Pb5.Location = new System.Drawing.Point(464, 159);
            this.Pb5.Name = "Pb5";
            this.Pb5.Size = new System.Drawing.Size(159, 132);
            this.Pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb5.TabIndex = 10;
            this.Pb5.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 13;
            // 
            // Two
            // 
            this.Two.Location = new System.Drawing.Point(254, 270);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(97, 42);
            this.Two.TabIndex = 14;
            this.Two.Text = "Два цвета";
            this.Two.UseVisualStyleBackColor = true;
            this.Two.Click += new System.EventHandler(this.Two_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 15;
            // 
            // Pb6
            // 
            this.Pb6.Location = new System.Drawing.Point(655, 159);
            this.Pb6.Name = "Pb6";
            this.Pb6.Size = new System.Drawing.Size(159, 132);
            this.Pb6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb6.TabIndex = 16;
            this.Pb6.TabStop = false;
            // 
            // Ochis
            // 
            this.Ochis.Location = new System.Drawing.Point(729, 315);
            this.Ochis.Name = "Ochis";
            this.Ochis.Size = new System.Drawing.Size(75, 39);
            this.Ochis.TabIndex = 17;
            this.Ochis.Text = "Очистить фильтры";
            this.Ochis.UseVisualStyleBackColor = true;
            this.Ochis.Click += new System.EventHandler(this.Ochis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 450);
            this.Controls.Add(this.Ochis);
            this.Controls.Add(this.Pb6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Two);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Pb5);
            this.Controls.Add(this.Vse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ser);
            this.Controls.Add(this.Inv);
            this.Controls.Add(this.Pov);
            this.Controls.Add(this.Pb4);
            this.Controls.Add(this.Pb3);
            this.Controls.Add(this.Pb2);
            this.Controls.Add(this.Pb1);
            this.Controls.Add(this.Soh);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Soh;
        private System.Windows.Forms.PictureBox Pb1;
        private System.Windows.Forms.PictureBox Pb2;
        private System.Windows.Forms.PictureBox Pb3;
        private System.Windows.Forms.PictureBox Pb4;
        private System.Windows.Forms.Button Pov;
        private System.Windows.Forms.Button Inv;
        private System.Windows.Forms.Button Ser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Vse;
        private System.Windows.Forms.PictureBox Pb5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Two;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox Pb6;
        private System.Windows.Forms.Button Ochis;
    }
}


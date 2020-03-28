namespace DigitalFiltering
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dfPictureBox = new System.Windows.Forms.PictureBox();
            this.readFileButton = new System.Windows.Forms.Button();
            this.signalButton = new System.Windows.Forms.Button();
            this.spectrButton = new System.Windows.Forms.Button();
            this.dfButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.spectrPictureBox = new System.Windows.Forms.PictureBox();
            this.signalPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listBox3 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dfPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spectrPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.signalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dfPictureBox
            // 
            this.dfPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dfPictureBox.Location = new System.Drawing.Point(12, 355);
            this.dfPictureBox.Name = "dfPictureBox";
            this.dfPictureBox.Size = new System.Drawing.Size(788, 150);
            this.dfPictureBox.TabIndex = 2;
            this.dfPictureBox.TabStop = false;
            // 
            // readFileButton
            // 
            this.readFileButton.Location = new System.Drawing.Point(3, 544);
            this.readFileButton.Name = "readFileButton";
            this.readFileButton.Size = new System.Drawing.Size(75, 36);
            this.readFileButton.TabIndex = 1;
            this.readFileButton.Text = "Чтение файла";
            this.readFileButton.UseVisualStyleBackColor = true;
            this.readFileButton.Click += new System.EventHandler(this.readFileButton_Click);
            // 
            // signalButton
            // 
            this.signalButton.Enabled = false;
            this.signalButton.Location = new System.Drawing.Point(84, 544);
            this.signalButton.Name = "signalButton";
            this.signalButton.Size = new System.Drawing.Size(75, 36);
            this.signalButton.TabIndex = 2;
            this.signalButton.Text = "Исходый сигнал";
            this.signalButton.UseVisualStyleBackColor = true;
            this.signalButton.Click += new System.EventHandler(this.signalButton_Click);
            // 
            // spectrButton
            // 
            this.spectrButton.Enabled = false;
            this.spectrButton.Location = new System.Drawing.Point(165, 544);
            this.spectrButton.Name = "spectrButton";
            this.spectrButton.Size = new System.Drawing.Size(54, 36);
            this.spectrButton.TabIndex = 3;
            this.spectrButton.Text = "Спектр";
            this.spectrButton.UseVisualStyleBackColor = true;
            this.spectrButton.Click += new System.EventHandler(this.spectrButton_Click);
            // 
            // dfButton
            // 
            this.dfButton.Enabled = false;
            this.dfButton.Location = new System.Drawing.Point(225, 544);
            this.dfButton.Name = "dfButton";
            this.dfButton.Size = new System.Drawing.Size(35, 36);
            this.dfButton.TabIndex = 4;
            this.dfButton.Text = "ЦФ";
            this.dfButton.UseVisualStyleBackColor = true;
            this.dfButton.Click += new System.EventHandler(this.dfButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(266, 511);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(145, 69);
            this.listBox1.TabIndex = 7;
            this.listBox1.TabStop = false;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(417, 511);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(145, 69);
            this.listBox2.TabIndex = 8;
            this.listBox2.TabStop = false;
            // 
            // spectrPictureBox
            // 
            this.spectrPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.spectrPictureBox.Location = new System.Drawing.Point(12, 188);
            this.spectrPictureBox.Name = "spectrPictureBox";
            this.spectrPictureBox.Size = new System.Drawing.Size(788, 150);
            this.spectrPictureBox.TabIndex = 9;
            this.spectrPictureBox.TabStop = false;
            // 
            // signalPictureBox
            // 
            this.signalPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.signalPictureBox.Location = new System.Drawing.Point(12, 22);
            this.signalPictureBox.Name = "signalPictureBox";
            this.signalPictureBox.Size = new System.Drawing.Size(788, 150);
            this.signalPictureBox.TabIndex = 10;
            this.signalPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Исходный сигнал";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Спектр";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Сигнал после ЦФ";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(725, 544);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 36);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Выход";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "dat";
            this.openFileDialog1.Filter = "DAT Files (*.dat)|*.dat|Все файлы (*.*)|*.*";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(568, 511);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(145, 69);
            this.listBox3.TabIndex = 11;
            this.listBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 583);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.signalPictureBox);
            this.Controls.Add(this.spectrPictureBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dfButton);
            this.Controls.Add(this.spectrButton);
            this.Controls.Add(this.signalButton);
            this.Controls.Add(this.readFileButton);
            this.Controls.Add(this.dfPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Цифровая фильтрация методом ДПФ";
            ((System.ComponentModel.ISupportInitialize)(this.dfPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spectrPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.signalPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox dfPictureBox;
        private System.Windows.Forms.Button readFileButton;
        private System.Windows.Forms.Button signalButton;
        private System.Windows.Forms.Button spectrButton;
        private System.Windows.Forms.Button dfButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.PictureBox spectrPictureBox;
        private System.Windows.Forms.PictureBox signalPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox listBox3;
    }
}



namespace Annealing
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
            this.tMinInp = new System.Windows.Forms.TextBox();
            this.tMaxInp = new System.Windows.Forms.TextBox();
            this.alphaInp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lengthInp = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.wayInp = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tMinInp
            // 
            this.tMinInp.Location = new System.Drawing.Point(26, 40);
            this.tMinInp.Name = "tMinInp";
            this.tMinInp.Size = new System.Drawing.Size(100, 20);
            this.tMinInp.TabIndex = 0;
            this.tMinInp.TextChanged += new System.EventHandler(this.tMinInp_TextChanged);
            // 
            // tMaxInp
            // 
            this.tMaxInp.Location = new System.Drawing.Point(160, 40);
            this.tMaxInp.Name = "tMaxInp";
            this.tMaxInp.Size = new System.Drawing.Size(100, 20);
            this.tMaxInp.TabIndex = 1;
            this.tMaxInp.TextChanged += new System.EventHandler(this.tMaxInp_TextChanged);
            // 
            // alphaInp
            // 
            this.alphaInp.Location = new System.Drawing.Point(292, 40);
            this.alphaInp.Name = "alphaInp";
            this.alphaInp.Size = new System.Drawing.Size(100, 20);
            this.alphaInp.TabIndex = 2;
            this.alphaInp.TextChanged += new System.EventHandler(this.alphaInp_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "t min";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "t max";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "alpha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Длина кратчайшего пути:";
            // 
            // lengthInp
            // 
            this.lengthInp.AutoSize = true;
            this.lengthInp.Location = new System.Drawing.Point(157, 123);
            this.lengthInp.Name = "lengthInp";
            this.lengthInp.Size = new System.Drawing.Size(19, 13);
            this.lengthInp.TabIndex = 7;
            this.lengthInp.Text = "<>";
            this.lengthInp.Click += new System.EventHandler(this.lengthInp_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Выбрать файл";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(185, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Запустить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Путь:";
            // 
            // wayInp
            // 
            this.wayInp.AutoSize = true;
            this.wayInp.Location = new System.Drawing.Point(58, 149);
            this.wayInp.Name = "wayInp";
            this.wayInp.Size = new System.Drawing.Size(19, 13);
            this.wayInp.TabIndex = 12;
            this.wayInp.Text = "<>";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 176);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 108);
            this.textBox1.TabIndex = 13;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.wayInp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lengthInp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.alphaInp);
            this.Controls.Add(this.tMaxInp);
            this.Controls.Add(this.tMinInp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tMinInp;
        private System.Windows.Forms.TextBox tMaxInp;
        private System.Windows.Forms.TextBox alphaInp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lengthInp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label wayInp;
        private System.Windows.Forms.TextBox textBox1;
    }
}


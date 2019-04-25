namespace _1
{
    partial class OctopusColculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OctopusColculator));
            this.num1 = new System.Windows.Forms.TextBox();
            this.den2 = new System.Windows.Forms.TextBox();
            this.den1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.den3 = new System.Windows.Forms.TextBox();
            this.num3 = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Multiplications = new System.Windows.Forms.Button();
            this.Div = new System.Windows.Forms.Button();
            this.Plus1 = new System.Windows.Forms.Button();
            this.Minus1 = new System.Windows.Forms.Button();
            this.Convert = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // num1
            // 
            this.num1.BackColor = System.Drawing.Color.White;
            this.num1.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.num1.Location = new System.Drawing.Point(13, 13);
            this.num1.MaximumSize = new System.Drawing.Size(150, 39);
            this.num1.MinimumSize = new System.Drawing.Size(150, 39);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(150, 39);
            this.num1.TabIndex = 0;
            this.num1.Text = "0";
            this.num1.TextChanged += new System.EventHandler(this.num1_TextChanged);
            // 
            // den2
            // 
            this.den2.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.den2.Location = new System.Drawing.Point(243, 71);
            this.den2.Name = "den2";
            this.den2.Size = new System.Drawing.Size(150, 39);
            this.den2.TabIndex = 1;
            this.den2.Text = "1";
            this.den2.TextChanged += new System.EventHandler(this.den2_TextChanged);
            // 
            // den1
            // 
            this.den1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.den1.Location = new System.Drawing.Point(13, 71);
            this.den1.Name = "den1";
            this.den1.Size = new System.Drawing.Size(150, 39);
            this.den1.TabIndex = 2;
            this.den1.Text = "1";
            this.den1.TextChanged += new System.EventHandler(this.den1_TextChanged);
            // 
            // num2
            // 
            this.num2.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.num2.Location = new System.Drawing.Point(243, 13);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(150, 39);
            this.num2.TabIndex = 3;
            this.num2.Text = "0";
            this.num2.TextChanged += new System.EventHandler(this.num2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(171, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 55);
            this.label1.TabIndex = 4;
            this.label1.Text = "+";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(410, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 55);
            this.label2.TabIndex = 5;
            this.label2.Text = "=";
            // 
            // den3
            // 
            this.den3.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.den3.Location = new System.Drawing.Point(479, 71);
            this.den3.Name = "den3";
            this.den3.ReadOnly = true;
            this.den3.Size = new System.Drawing.Size(183, 39);
            this.den3.TabIndex = 6;
            this.den3.Text = "1";
            // 
            // num3
            // 
            this.num3.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.num3.Location = new System.Drawing.Point(479, 13);
            this.num3.Name = "num3";
            this.num3.ReadOnly = true;
            this.num3.Size = new System.Drawing.Size(183, 39);
            this.num3.TabIndex = 7;
            this.num3.Text = "0";
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Times New Roman", 28.2F);
            this.Add.Location = new System.Drawing.Point(13, 140);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(139, 75);
            this.Add.TabIndex = 8;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Minus
            // 
            this.Minus.Font = new System.Drawing.Font("Times New Roman", 28.2F);
            this.Minus.Location = new System.Drawing.Point(13, 234);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(139, 75);
            this.Minus.TabIndex = 9;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // Multiplications
            // 
            this.Multiplications.Font = new System.Drawing.Font("Times New Roman", 28.2F);
            this.Multiplications.Location = new System.Drawing.Point(177, 140);
            this.Multiplications.Name = "Multiplications";
            this.Multiplications.Size = new System.Drawing.Size(139, 75);
            this.Multiplications.TabIndex = 10;
            this.Multiplications.Text = "*";
            this.Multiplications.UseVisualStyleBackColor = true;
            this.Multiplications.Click += new System.EventHandler(this.Multiplications_Click);
            // 
            // Div
            // 
            this.Div.Font = new System.Drawing.Font("Times New Roman", 28.2F);
            this.Div.Location = new System.Drawing.Point(178, 234);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(139, 75);
            this.Div.TabIndex = 11;
            this.Div.Text = "÷";
            this.Div.UseVisualStyleBackColor = true;
            this.Div.Click += new System.EventHandler(this.Div_Click);
            // 
            // Plus1
            // 
            this.Plus1.Font = new System.Drawing.Font("Times New Roman", 28.2F);
            this.Plus1.Location = new System.Drawing.Point(340, 140);
            this.Plus1.Name = "Plus1";
            this.Plus1.Size = new System.Drawing.Size(139, 75);
            this.Plus1.TabIndex = 12;
            this.Plus1.Text = "++";
            this.Plus1.UseVisualStyleBackColor = true;
            this.Plus1.Click += new System.EventHandler(this.Plus1_Click);
            // 
            // Minus1
            // 
            this.Minus1.Font = new System.Drawing.Font("Times New Roman", 28.2F);
            this.Minus1.Location = new System.Drawing.Point(340, 234);
            this.Minus1.Name = "Minus1";
            this.Minus1.Size = new System.Drawing.Size(139, 75);
            this.Minus1.TabIndex = 13;
            this.Minus1.Text = "--";
            this.Minus1.UseVisualStyleBackColor = true;
            this.Minus1.Click += new System.EventHandler(this.Minus1_Click);
            // 
            // Convert
            // 
            this.Convert.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Convert.Location = new System.Drawing.Point(497, 140);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(166, 169);
            this.Convert.TabIndex = 14;
            this.Convert.Text = "привести ответ к десятичному виду ";
            this.Convert.UseVisualStyleBackColor = true;
            this.Convert.Click += new System.EventHandler(this.Convert_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 55);
            this.label3.MaximumSize = new System.Drawing.Size(155, 10);
            this.label3.MinimumSize = new System.Drawing.Size(150, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 10);
            this.label3.TabIndex = 16;
            this.label3.Text = "=======================================";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 55);
            this.label4.MaximumSize = new System.Drawing.Size(155, 10);
            this.label4.MinimumSize = new System.Drawing.Size(150, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 10);
            this.label4.TabIndex = 17;
            this.label4.Text = "=======================================";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(476, 55);
            this.label5.MaximumSize = new System.Drawing.Size(188, 10);
            this.label5.MinimumSize = new System.Drawing.Size(150, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 10);
            this.label5.TabIndex = 18;
            this.label5.Text = "=======================================";
            // 
            // OctopusColculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 338);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Convert);
            this.Controls.Add(this.Minus1);
            this.Controls.Add(this.Plus1);
            this.Controls.Add(this.Div);
            this.Controls.Add(this.Multiplications);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.den3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.den1);
            this.Controls.Add(this.den2);
            this.Controls.Add(this.num1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OctopusColculator";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox den2;
        private System.Windows.Forms.TextBox den1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox den3;
        private System.Windows.Forms.TextBox num3;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Multiplications;
        private System.Windows.Forms.Button Div;
        private System.Windows.Forms.Button Plus1;
        private System.Windows.Forms.Button Minus1;
        private System.Windows.Forms.Button Convert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}


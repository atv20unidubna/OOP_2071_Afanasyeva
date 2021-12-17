namespace Rational_fraction
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
            this.textBox_num1 = new System.Windows.Forms.TextBox();
            this.textBox_den1 = new System.Windows.Forms.TextBox();
            this.textBox_den2 = new System.Windows.Forms.TextBox();
            this.textBox_num2 = new System.Windows.Forms.TextBox();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_divide = new System.Windows.Forms.Button();
            this.button_multiply = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_NOD = new System.Windows.Forms.TextBox();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.textBox_cut = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_num1
            // 
            this.textBox_num1.Location = new System.Drawing.Point(40, 36);
            this.textBox_num1.Name = "textBox_num1";
            this.textBox_num1.Size = new System.Drawing.Size(75, 22);
            this.textBox_num1.TabIndex = 1;
            // 
            // textBox_den1
            // 
            this.textBox_den1.Location = new System.Drawing.Point(40, 66);
            this.textBox_den1.Name = "textBox_den1";
            this.textBox_den1.Size = new System.Drawing.Size(75, 22);
            this.textBox_den1.TabIndex = 2;
            // 
            // textBox_den2
            // 
            this.textBox_den2.Location = new System.Drawing.Point(183, 64);
            this.textBox_den2.Name = "textBox_den2";
            this.textBox_den2.Size = new System.Drawing.Size(75, 22);
            this.textBox_den2.TabIndex = 3;
            // 
            // textBox_num2
            // 
            this.textBox_num2.Location = new System.Drawing.Point(183, 36);
            this.textBox_num2.Name = "textBox_num2";
            this.textBox_num2.Size = new System.Drawing.Size(75, 22);
            this.textBox_num2.TabIndex = 4;
            // 
            // button_plus
            // 
            this.button_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_plus.Location = new System.Drawing.Point(37, 125);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(54, 43);
            this.button_plus.TabIndex = 7;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.Click += new System.EventHandler(this.button_plus_Click);
            // 
            // button_minus
            // 
            this.button_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_minus.Location = new System.Drawing.Point(97, 125);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(54, 43);
            this.button_minus.TabIndex = 8;
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = true;
            this.button_minus.Click += new System.EventHandler(this.button_minus_Click);
            // 
            // button_divide
            // 
            this.button_divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_divide.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_divide.Location = new System.Drawing.Point(37, 174);
            this.button_divide.Name = "button_divide";
            this.button_divide.Size = new System.Drawing.Size(54, 43);
            this.button_divide.TabIndex = 9;
            this.button_divide.Text = "/";
            this.button_divide.UseVisualStyleBackColor = true;
            this.button_divide.Click += new System.EventHandler(this.button_divide_Click);
            // 
            // button_multiply
            // 
            this.button_multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_multiply.Location = new System.Drawing.Point(97, 174);
            this.button_multiply.Name = "button_multiply";
            this.button_multiply.Size = new System.Drawing.Size(54, 43);
            this.button_multiply.TabIndex = 10;
            this.button_multiply.Text = "*";
            this.button_multiply.UseVisualStyleBackColor = true;
            this.button_multiply.Click += new System.EventHandler(this.button_multiply_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(125, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "sign";
            // 
            // textBox_NOD
            // 
            this.textBox_NOD.Location = new System.Drawing.Point(338, 100);
            this.textBox_NOD.Multiline = true;
            this.textBox_NOD.Name = "textBox_NOD";
            this.textBox_NOD.Size = new System.Drawing.Size(56, 31);
            this.textBox_NOD.TabIndex = 14;
            
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(338, 41);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(141, 40);
            this.textBox_result.TabIndex = 15;
            // 
            // textBox_cut
            // 
            this.textBox_cut.Location = new System.Drawing.Point(552, 41);
            this.textBox_cut.Multiline = true;
            this.textBox_cut.Name = "textBox_cut";
            this.textBox_cut.Size = new System.Drawing.Size(131, 38);
            this.textBox_cut.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(283, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(503, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(283, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(198, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "НОД";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_cut);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.textBox_NOD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_multiply);
            this.Controls.Add(this.button_divide);
            this.Controls.Add(this.button_minus);
            this.Controls.Add(this.button_plus);
            this.Controls.Add(this.textBox_num2);
            this.Controls.Add(this.textBox_den2);
            this.Controls.Add(this.textBox_den1);
            this.Controls.Add(this.textBox_num1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_num1;
        private System.Windows.Forms.TextBox textBox_den1;
        private System.Windows.Forms.TextBox textBox_den2;
        private System.Windows.Forms.TextBox textBox_num2;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_divide;
        private System.Windows.Forms.Button button_multiply;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_NOD;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.TextBox textBox_cut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}


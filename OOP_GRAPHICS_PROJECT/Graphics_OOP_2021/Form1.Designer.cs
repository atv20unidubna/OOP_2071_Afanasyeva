namespace Graphics_OOP_2021
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_refresh = new System.Windows.Forms.Button();
            this.rb_circle = new System.Windows.Forms.RadioButton();
            this.groupBox_figures = new System.Windows.Forms.GroupBox();
            this.rb_sandcart = new System.Windows.Forms.RadioButton();
            this.rb_cart = new System.Windows.Forms.RadioButton();
            this.rb_coalcart = new System.Windows.Forms.RadioButton();
            this.rb_rect = new System.Windows.Forms.RadioButton();
            this.groupBox_train = new System.Windows.Forms.GroupBox();
            this.textBox_vagonquantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_createtrain = new System.Windows.Forms.Button();
            this.groupBox_figures.SuspendLayout();
            this.groupBox_train.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1041, 505);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(16, 529);
            this.button_refresh.Margin = new System.Windows.Forms.Padding(4);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(80, 30);
            this.button_refresh.TabIndex = 5;
            this.button_refresh.Text = "refresh";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // rb_circle
            // 
            this.rb_circle.AutoSize = true;
            this.rb_circle.Location = new System.Drawing.Point(8, 23);
            this.rb_circle.Margin = new System.Windows.Forms.Padding(4);
            this.rb_circle.Name = "rb_circle";
            this.rb_circle.Size = new System.Drawing.Size(64, 21);
            this.rb_circle.TabIndex = 6;
            this.rb_circle.TabStop = true;
            this.rb_circle.Text = "Circle";
            this.rb_circle.UseVisualStyleBackColor = true;
            // 
            // groupBox_figures
            // 
            this.groupBox_figures.Controls.Add(this.rb_sandcart);
            this.groupBox_figures.Controls.Add(this.rb_cart);
            this.groupBox_figures.Controls.Add(this.rb_coalcart);
            this.groupBox_figures.Controls.Add(this.rb_rect);
            this.groupBox_figures.Controls.Add(this.rb_circle);
            this.groupBox_figures.Location = new System.Drawing.Point(1092, 27);
            this.groupBox_figures.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_figures.Name = "groupBox_figures";
            this.groupBox_figures.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_figures.Size = new System.Drawing.Size(204, 178);
            this.groupBox_figures.TabIndex = 7;
            this.groupBox_figures.TabStop = false;
            this.groupBox_figures.Text = "Choose your figure";
            // 
            // rb_sandcart
            // 
            this.rb_sandcart.AutoSize = true;
            this.rb_sandcart.Location = new System.Drawing.Point(8, 138);
            this.rb_sandcart.Margin = new System.Windows.Forms.Padding(4);
            this.rb_sandcart.Name = "rb_sandcart";
            this.rb_sandcart.Size = new System.Drawing.Size(85, 21);
            this.rb_sandcart.TabIndex = 9;
            this.rb_sandcart.TabStop = true;
            this.rb_sandcart.Text = "Coal cart";
            this.rb_sandcart.UseVisualStyleBackColor = true;
            // 
            // rb_cart
            // 
            this.rb_cart.AutoSize = true;
            this.rb_cart.Location = new System.Drawing.Point(8, 80);
            this.rb_cart.Margin = new System.Windows.Forms.Padding(4);
            this.rb_cart.Name = "rb_cart";
            this.rb_cart.Size = new System.Drawing.Size(96, 21);
            this.rb_cart.TabIndex = 8;
            this.rb_cart.TabStop = true;
            this.rb_cart.Text = "Empty cart";
            this.rb_cart.UseVisualStyleBackColor = true;
            // 
            // rb_coalcart
            // 
            this.rb_coalcart.AutoSize = true;
            this.rb_coalcart.Location = new System.Drawing.Point(8, 110);
            this.rb_coalcart.Margin = new System.Windows.Forms.Padding(4);
            this.rb_coalcart.Name = "rb_coalcart";
            this.rb_coalcart.Size = new System.Drawing.Size(90, 21);
            this.rb_coalcart.TabIndex = 10;
            this.rb_coalcart.TabStop = true;
            this.rb_coalcart.Text = "Sand cart";
            this.rb_coalcart.UseVisualStyleBackColor = true;
            // 
            // rb_rect
            // 
            this.rb_rect.AutoSize = true;
            this.rb_rect.Location = new System.Drawing.Point(8, 52);
            this.rb_rect.Margin = new System.Windows.Forms.Padding(4);
            this.rb_rect.Name = "rb_rect";
            this.rb_rect.Size = new System.Drawing.Size(90, 21);
            this.rb_rect.TabIndex = 7;
            this.rb_rect.TabStop = true;
            this.rb_rect.Text = "Rectange";
            this.rb_rect.UseVisualStyleBackColor = true;
            // 
            // groupBox_train
            // 
            this.groupBox_train.Controls.Add(this.textBox_vagonquantity);
            this.groupBox_train.Controls.Add(this.label1);
            this.groupBox_train.Controls.Add(this.button_createtrain);
            this.groupBox_train.Location = new System.Drawing.Point(1092, 229);
            this.groupBox_train.Name = "groupBox_train";
            this.groupBox_train.Size = new System.Drawing.Size(203, 104);
            this.groupBox_train.TabIndex = 8;
            this.groupBox_train.TabStop = false;
            this.groupBox_train.Text = "TRAIN";
            // 
            // textBox_vagonquantity
            // 
            this.textBox_vagonquantity.Location = new System.Drawing.Point(8, 38);
            this.textBox_vagonquantity.Name = "textBox_vagonquantity";
            this.textBox_vagonquantity.Size = new System.Drawing.Size(189, 22);
            this.textBox_vagonquantity.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter vagon quantity:";
            // 
            // button_createtrain
            // 
            this.button_createtrain.Location = new System.Drawing.Point(70, 66);
            this.button_createtrain.Name = "button_createtrain";
            this.button_createtrain.Size = new System.Drawing.Size(68, 25);
            this.button_createtrain.TabIndex = 0;
            this.button_createtrain.Text = "Create";
            this.button_createtrain.UseVisualStyleBackColor = true;
            this.button_createtrain.Click += new System.EventHandler(this.button_createtrain_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1324, 574);
            this.Controls.Add(this.groupBox_train);
            this.Controls.Add(this.groupBox_figures);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Draw figure";
            this.groupBox_figures.ResumeLayout(false);
            this.groupBox_figures.PerformLayout();
            this.groupBox_train.ResumeLayout(false);
            this.groupBox_train.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.RadioButton rb_circle;
        private System.Windows.Forms.GroupBox groupBox_figures;
        private System.Windows.Forms.RadioButton rb_coalcart;
        private System.Windows.Forms.RadioButton rb_sandcart;
        private System.Windows.Forms.RadioButton rb_cart;
        private System.Windows.Forms.RadioButton rb_rect;
        private System.Windows.Forms.GroupBox groupBox_train;
        private System.Windows.Forms.TextBox textBox_vagonquantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_createtrain;
    }
}


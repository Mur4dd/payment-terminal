namespace FF
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            components = new System.ComponentModel.Container();
            richTextBox1 = new RichTextBox();
            button2 = new Button();
            maskedTextBox2 = new MaskedTextBox();
            label4 = new Label();
            label3 = new Label();
            footer = new Panel();
            button4 = new Button();
            button3 = new Button();
            label11 = new Label();
            label10 = new Label();
            navbar = new Panel();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            button1 = new Button();
            errorProvider1 = new ErrorProvider(components);
            label6 = new Label();
            footer.SuspendLayout();
            navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(619, 166);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(217, 305);
            richTextBox1.TabIndex = 37;
            richTextBox1.Text = "";
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.Red;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(216, 493);
            button2.Name = "button2";
            button2.Size = new Size(150, 35);
            button2.TabIndex = 36;
            button2.Text = "Ödə";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(239, 438);
            maskedTextBox2.Mask = "₼ 00000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(114, 23);
            maskedTextBox2.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(172, 376);
            label4.Name = "label4";
            label4.Size = new Size(244, 37);
            label4.TabIndex = 34;
            label4.Text = "Məbləği Daxil Edin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(121, 151);
            label3.Name = "label3";
            label3.Size = new Size(355, 37);
            label3.TabIndex = 32;
            label3.Text = "Abonent Kodunu Daxil Edin";
            // 
            // footer
            // 
            footer.BackColor = Color.FromArgb(31, 31, 31);
            footer.Controls.Add(button4);
            footer.Controls.Add(button3);
            footer.Controls.Add(label11);
            footer.Controls.Add(label10);
            footer.Dock = DockStyle.Bottom;
            footer.Location = new Point(0, 553);
            footer.Name = "footer";
            footer.Size = new Size(984, 108);
            footer.TabIndex = 31;
            // 
            // button4
            // 
            button4.BackColor = Color.DimGray;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderColor = Color.Red;
            button4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(28, 32);
            button4.Name = "button4";
            button4.Size = new Size(150, 35);
            button4.TabIndex = 32;
            button4.Text = "Əsas səhifə";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DimGray;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = Color.Red;
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(216, 32);
            button3.Name = "button3";
            button3.Size = new Size(150, 35);
            button3.TabIndex = 31;
            button3.Text = "Əvvələ";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(466, 42);
            label11.Name = "label11";
            label11.Size = new Size(63, 25);
            label11.TabIndex = 1;
            label11.Text = "*13 31";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(444, 17);
            label10.Name = "label10";
            label10.Size = new Size(116, 25);
            label10.TabIndex = 0;
            label10.Text = "Qaynar xətt";
            // 
            // navbar
            // 
            navbar.BackColor = Color.FromArgb(31, 31, 31);
            navbar.Controls.Add(label2);
            navbar.Controls.Add(label1);
            navbar.Dock = DockStyle.Top;
            navbar.Location = new Point(0, 0);
            navbar.Name = "navbar";
            navbar.Size = new Size(984, 108);
            navbar.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(28, 54);
            label2.Name = "label2";
            label2.Size = new Size(235, 30);
            label2.TabIndex = 1;
            label2.Text = "Milli Ödəniş Terminalınız";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(28, 17);
            label1.Name = "label1";
            label1.Size = new Size(120, 37);
            label1.TabIndex = 0;
            label1.Text = "milliPay";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(234, 214);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 23);
            textBox1.TabIndex = 38;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(121, 263);
            label5.Name = "label5";
            label5.Size = new Size(150, 37);
            label5.TabIndex = 39;
            label5.Text = "Borcunuz :";
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.Red;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(216, 317);
            button1.Name = "button1";
            button1.Size = new Size(150, 35);
            button1.TabIndex = 40;
            button1.Text = "Borcu Yoxla";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(698, 133);
            label6.Name = "label6";
            label6.Size = new Size(60, 30);
            label6.TabIndex = 41;
            label6.Text = "Qəbz";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(984, 661);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(richTextBox1);
            Controls.Add(button2);
            Controls.Add(maskedTextBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(footer);
            Controls.Add(navbar);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            footer.ResumeLayout(false);
            footer.PerformLayout();
            navbar.ResumeLayout(false);
            navbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button button2;
        private MaskedTextBox maskedTextBox2;
        private Label label4;
        private Label label3;
        private Panel footer;
        private Label label11;
        private Label label10;
        private Panel navbar;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private Label label5;
        private Button button1;
        private ErrorProvider errorProvider1;
        private Button button3;
        private Button button4;
        private Label label6;
    }
}
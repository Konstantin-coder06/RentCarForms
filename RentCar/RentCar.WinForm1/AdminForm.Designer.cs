namespace RentCar.WinForm1
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            pictureBox1 = new PictureBox();
            roundPanel2 = new RoundPanel();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            button1 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            roundPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(906, 542);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // roundPanel2
            // 
            roundPanel2.BackColor = SystemColors.ControlLightLight;
            roundPanel2.Controls.Add(textBox2);
            roundPanel2.Controls.Add(textBox1);
            roundPanel2.Controls.Add(label4);
            roundPanel2.Controls.Add(button1);
            roundPanel2.Controls.Add(button3);
            roundPanel2.CornerRadius = 30;
            roundPanel2.Location = new Point(487, 103);
            roundPanel2.Name = "roundPanel2";
            roundPanel2.Size = new Size(352, 289);
            roundPanel2.TabIndex = 18;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.InactiveBorder;
            textBox2.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox2.Location = new Point(14, 119);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(220, 47);
            textBox2.TabIndex = 41;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveBorder;
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox1.Location = new Point(14, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(220, 47);
            textBox1.TabIndex = 40;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLightLight;
            label4.Font = new Font("Segoe UI Black", 12.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(30, 143, 147);
            label4.Location = new Point(8, 11);
            label4.Name = "label4";
            label4.Size = new Size(341, 30);
            label4.TabIndex = 18;
            label4.Text = "Enter username and password";
            // 
            // button1
            // 
            button1.AutoEllipsis = true;
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 5;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Black", 12.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(30, 143, 147);
            button1.Location = new Point(14, 229);
            button1.Name = "button1";
            button1.Size = new Size(109, 57);
            button1.TabIndex = 17;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.AutoEllipsis = true;
            button3.BackColor = Color.White;
            button3.FlatAppearance.BorderColor = Color.White;
            button3.FlatAppearance.BorderSize = 5;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Black", 12.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(30, 143, 147);
            button3.Location = new Point(229, 229);
            button3.Name = "button3";
            button3.Size = new Size(109, 57);
            button3.TabIndex = 16;
            button3.Text = "Yes";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 525);
            Controls.Add(roundPanel2);
            Controls.Add(pictureBox1);
            Name = "AdminForm";
            Text = "AdminForm";
            Load += AdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            roundPanel2.ResumeLayout(false);
            roundPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private RoundPanel roundPanel2;
        private Button button1;
        private Button button3;
        private Label label4;
        public TextBox textBox2;
        public TextBox textBox1;
    }
}
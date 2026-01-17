namespace RentCar.WinForm1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox2 = new PictureBox();
            button3 = new Button();
            button4 = new Button();
            label4 = new Label();
            roundPanel2 = new RoundPanel();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            roundPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(601, 450);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
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
            button3.Location = new Point(122, 46);
            button3.Name = "button3";
            button3.Size = new Size(109, 57);
            button3.TabIndex = 16;
            button3.Text = "Yes";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.AutoEllipsis = true;
            button4.BackColor = Color.White;
            button4.FlatAppearance.BorderColor = Color.White;
            button4.FlatAppearance.BorderSize = 5;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Black", 12.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button4.ForeColor = Color.FromArgb(30, 143, 147);
            button4.Location = new Point(0, 46);
            button4.Name = "button4";
            button4.Size = new Size(109, 57);
            button4.TabIndex = 15;
            button4.Text = "No";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLightLight;
            label4.Font = new Font("Segoe UI Black", 12.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(30, 143, 147);
            label4.Location = new Point(361, 73);
            label4.Name = "label4";
            label4.Size = new Size(186, 60);
            label4.TabIndex = 13;
            label4.Text = "Do you want to\r\nenter as admin?";
            // 
            // roundPanel2
            // 
            roundPanel2.BackColor = SystemColors.ControlLightLight;
            roundPanel2.Controls.Add(button1);
            roundPanel2.Controls.Add(button3);
            roundPanel2.Controls.Add(button4);
            roundPanel2.CornerRadius = 30;
            roundPanel2.Location = new Point(329, 136);
            roundPanel2.Name = "roundPanel2";
            roundPanel2.Size = new Size(231, 200);
            roundPanel2.TabIndex = 17;
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
            button1.Location = new Point(63, 143);
            button1.Name = "button1";
            button1.Size = new Size(109, 57);
            button1.TabIndex = 17;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 143, 147);
            ClientSize = new Size(601, 450);
            Controls.Add(roundPanel2);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            roundPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox2;
        private Button button3;
        private Button button4;
        private Label label4;
        private RoundPanel roundPanel2;
        private Button button1;
    }
}
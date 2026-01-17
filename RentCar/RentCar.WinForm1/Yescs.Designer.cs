namespace RentCar.WinForm1
{
    partial class Yescs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yescs));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            button1 = new Button();
            roundPanel1 = new RoundPanel();
            button16 = new Button();
            button15 = new Button();
            button10 = new Button();
            button8 = new Button();
            button9 = new Button();
            button7 = new Button();
            button6 = new Button();
            button3 = new Button();
            button5 = new Button();
            button4 = new Button();
            button2 = new Button();
            button12 = new Button();
            button11 = new Button();
            button13 = new Button();
            roundPanel7 = new RoundPanel();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button14 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            roundPanel1.SuspendLayout();
            roundPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Segoe UI Black", 26F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(5, 157);
            label1.Name = "label1";
            label1.Size = new Size(710, 60);
            label1.TabIndex = 0;
            label1.Text = "Welcome to 'DriveTime rentals'";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1902, 1153);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(5, 217);
            label2.Name = "label2";
            label2.Size = new Size(429, 46);
            label2.TabIndex = 2;
            label2.Text = "What do you want to see?";
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = SystemColors.ControlLightLight;
            button1.FlatAppearance.BorderSize = 6;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Symbol", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(23, 3);
            button1.Name = "button1";
            button1.Size = new Size(441, 46);
            button1.TabIndex = 3;
            button1.Text = "1. Show all cars from all  offices";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // roundPanel1
            // 
            roundPanel1.BackColor = SystemColors.ControlLightLight;
            roundPanel1.Controls.Add(button16);
            roundPanel1.Controls.Add(button15);
            roundPanel1.Controls.Add(button10);
            roundPanel1.Controls.Add(button8);
            roundPanel1.Controls.Add(button9);
            roundPanel1.Controls.Add(button7);
            roundPanel1.Controls.Add(button6);
            roundPanel1.Controls.Add(button3);
            roundPanel1.Controls.Add(button5);
            roundPanel1.Controls.Add(button4);
            roundPanel1.Controls.Add(button2);
            roundPanel1.Controls.Add(button1);
            roundPanel1.CornerRadius = 30;
            roundPanel1.Location = new Point(32, 269);
            roundPanel1.Name = "roundPanel1";
            roundPanel1.Size = new Size(572, 721);
            roundPanel1.TabIndex = 5;
            roundPanel1.Paint += roundPanel1_Paint;
            // 
            // button16
            // 
            button16.Cursor = Cursors.Hand;
            button16.FlatAppearance.BorderColor = SystemColors.ControlLightLight;
            button16.FlatAppearance.BorderSize = 6;
            button16.FlatStyle = FlatStyle.Flat;
            button16.Font = new Font("Segoe UI Symbol", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button16.Location = new Point(20, 229);
            button16.Name = "button16";
            button16.Size = new Size(308, 46);
            button16.TabIndex = 6;
            button16.Text = "5. Show all electric cars ";
            button16.TextAlign = ContentAlignment.MiddleLeft;
            button16.UseVisualStyleBackColor = true;
            button16.Click += button16_Click;
            // 
            // button15
            // 
            button15.Cursor = Cursors.Hand;
            button15.FlatAppearance.BorderColor = SystemColors.ControlLightLight;
            button15.FlatAppearance.BorderSize = 6;
            button15.FlatStyle = FlatStyle.Flat;
            button15.Font = new Font("Segoe UI Symbol", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button15.Location = new Point(20, 168);
            button15.Name = "button15";
            button15.Size = new Size(516, 55);
            button15.TabIndex = 5;
            button15.Text = "4. Show all cars with combustion engine";
            button15.TextAlign = ContentAlignment.MiddleLeft;
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // button10
            // 
            button10.Cursor = Cursors.Hand;
            button10.FlatAppearance.BorderColor = SystemColors.ControlLightLight;
            button10.FlatAppearance.BorderSize = 6;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Segoe UI Symbol", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button10.Location = new Point(6, 621);
            button10.Name = "button10";
            button10.Size = new Size(405, 46);
            button10.TabIndex = 3;
            button10.Text = "12. Show Seven-Seater SUV";
            button10.TextAlign = ContentAlignment.MiddleLeft;
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button8
            // 
            button8.Cursor = Cursors.Hand;
            button8.FlatAppearance.BorderColor = SystemColors.ControlLightLight;
            button8.FlatAppearance.BorderSize = 6;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI Symbol", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button8.Location = new Point(6, 517);
            button8.Name = "button8";
            button8.Size = new Size(442, 46);
            button8.TabIndex = 3;
            button8.Text = "10. Show Four-Seater' Convertable";
            button8.TextAlign = ContentAlignment.MiddleLeft;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Cursor = Cursors.Hand;
            button9.FlatAppearance.BorderColor = SystemColors.ControlLightLight;
            button9.FlatAppearance.BorderSize = 6;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI Symbol", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button9.Location = new Point(6, 569);
            button9.Name = "button9";
            button9.Size = new Size(337, 46);
            button9.TabIndex = 4;
            button9.Text = "11. Show Five-Seater SUV";
            button9.TextAlign = ContentAlignment.MiddleLeft;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button7
            // 
            button7.Cursor = Cursors.Hand;
            button7.FlatAppearance.BorderColor = SystemColors.ControlLightLight;
            button7.FlatAppearance.BorderSize = 6;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI Symbol", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button7.Location = new Point(20, 457);
            button7.Name = "button7";
            button7.Size = new Size(428, 54);
            button7.TabIndex = 4;
            button7.Text = "9. Show Two-Seater' Convertable";
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.CausesValidation = false;
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderColor = SystemColors.ControlLightLight;
            button6.FlatAppearance.BorderSize = 6;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI Symbol", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button6.Location = new Point(23, 398);
            button6.Name = "button6";
            button6.Size = new Size(405, 53);
            button6.TabIndex = 3;
            button6.Text = "8. Show Four-Seater' Coupe";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = SystemColors.ControlLightLight;
            button3.FlatAppearance.BorderSize = 6;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Symbol", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button3.Location = new Point(20, 114);
            button3.Name = "button3";
            button3.Size = new Size(565, 48);
            button3.TabIndex = 4;
            button3.Text = "3. Show all cars from offices with same name";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderColor = SystemColors.ControlLightLight;
            button5.FlatAppearance.BorderSize = 6;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI Symbol", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button5.Location = new Point(23, 333);
            button5.Name = "button5";
            button5.Size = new Size(388, 59);
            button5.TabIndex = 4;
            button5.Text = "7. Show Two-Seater' Coupe";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderColor = SystemColors.ControlLightLight;
            button4.FlatAppearance.BorderSize = 6;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Symbol", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button4.Location = new Point(23, 281);
            button4.Name = "button4";
            button4.Size = new Size(352, 46);
            button4.TabIndex = 3;
            button4.Text = "6. Show Sedan";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = SystemColors.ControlLightLight;
            button2.FlatAppearance.BorderSize = 6;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Symbol", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(23, 55);
            button2.Name = "button2";
            button2.Size = new Size(474, 53);
            button2.TabIndex = 4;
            button2.Text = "2. Show all cars from only one office";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button12
            // 
            button12.BackColor = SystemColors.ControlLightLight;
            button12.Cursor = Cursors.Hand;
            button12.FlatAppearance.BorderColor = SystemColors.ControlLightLight;
            button12.FlatAppearance.BorderSize = 6;
            button12.FlatStyle = FlatStyle.Flat;
            button12.Font = new Font("Segoe UI Symbol", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button12.Location = new Point(610, 322);
            button12.Name = "button12";
            button12.Size = new Size(557, 57);
            button12.TabIndex = 3;
            button12.Text = "14. Show only one brand cars typed by you";
            button12.TextAlign = ContentAlignment.MiddleLeft;
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // button11
            // 
            button11.BackColor = SystemColors.ControlLightLight;
            button11.Cursor = Cursors.Hand;
            button11.FlatAppearance.BorderColor = SystemColors.ControlLightLight;
            button11.FlatAppearance.BorderSize = 6;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Segoe UI Symbol", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button11.Location = new Point(610, 267);
            button11.Name = "button11";
            button11.Size = new Size(494, 57);
            button11.TabIndex = 4;
            button11.Text = "13. Show cars with price typed by you";
            button11.TextAlign = ContentAlignment.MiddleLeft;
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // button13
            // 
            button13.Cursor = Cursors.Hand;
            button13.FlatAppearance.BorderColor = SystemColors.ControlLightLight;
            button13.FlatAppearance.BorderSize = 6;
            button13.FlatStyle = FlatStyle.Flat;
            button13.Font = new Font("Segoe UI Variable Text", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button13.Location = new Point(-14, 3);
            button13.Name = "button13";
            button13.Size = new Size(216, 119);
            button13.TabIndex = 5;
            button13.Text = "Exit";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // roundPanel7
            // 
            roundPanel7.BackColor = SystemColors.ControlLightLight;
            roundPanel7.Controls.Add(button13);
            roundPanel7.CornerRadius = 30;
            roundPanel7.Location = new Point(32, 1004);
            roundPanel7.Name = "roundPanel7";
            roundPanel7.Size = new Size(428, 161);
            roundPanel7.TabIndex = 8;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ButtonHighlight;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(212, 110);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonShadow;
            label3.Location = new Point(251, 58);
            label3.Name = "label3";
            label3.Size = new Size(137, 25);
            label3.TabIndex = 10;
            label3.Text = "Become renter";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonShadow;
            label4.Location = new Point(949, 58);
            label4.Name = "label4";
            label4.Size = new Size(123, 25);
            label4.TabIndex = 11;
            label4.Text = "How it works";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonHighlight;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonShadow;
            label5.Location = new Point(1279, 58);
            label5.Name = "label5";
            label5.Size = new Size(140, 25);
            label5.TabIndex = 12;
            label5.Text = "Why choose us";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ButtonHighlight;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonShadow;
            label6.Location = new Point(599, 58);
            label6.Name = "label6";
            label6.Size = new Size(116, 25);
            label6.TabIndex = 13;
            label6.Text = "Rental deals";
            // 
            // button14
            // 
            button14.BackColor = SystemColors.ControlLightLight;
            button14.Cursor = Cursors.Hand;
            button14.FlatAppearance.BorderColor = SystemColors.ControlLightLight;
            button14.FlatAppearance.BorderSize = 6;
            button14.FlatStyle = FlatStyle.Flat;
            button14.Font = new Font("Segoe UI Symbol", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button14.Location = new Point(610, 383);
            button14.Name = "button14";
            button14.Size = new Size(276, 57);
            button14.TabIndex = 5;
            button14.Text = "15. Make reservation";
            button14.TextAlign = ContentAlignment.MiddleLeft;
            button14.UseVisualStyleBackColor = false;
            button14.Click += button14_Click;
            // 
            // Yescs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1153);
            Controls.Add(button11);
            Controls.Add(button12);
            Controls.Add(button14);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(roundPanel7);
            Controls.Add(roundPanel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Yescs";
            Text = "DRIVETIME RENTALS";
            Load += Yescs_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            roundPanel1.ResumeLayout(false);
            roundPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Button button1;
        private RoundPanel roundPanel1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button7;
        private Button button8;
        private Button button5;
        private Button button6;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private RoundPanel roundPanel7;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button14;
        private Button button16;
        private Button button15;
    }
}
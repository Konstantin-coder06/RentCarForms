using Microsoft.EntityFrameworkCore.Query.Internal;

namespace RentCar.WinForm1
{
    partial class OptionsOfYes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsOfYes));
            pictureBox1 = new PictureBox();
            richTextBox1 = new RichTextBox();
            roundPanel7 = new RoundPanel();
            button13 = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox3 = new ComboBox();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label6 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            roundPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1902, 1153);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.HighlightText;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            richTextBox1.Location = new Point(0, 169);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(845, 830);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // roundPanel7
            // 
            roundPanel7.BackColor = SystemColors.ControlLightLight;
            roundPanel7.Controls.Add(button13);
            roundPanel7.CornerRadius = 30;
            roundPanel7.Location = new Point(12, 1005);
            roundPanel7.Name = "roundPanel7";
            roundPanel7.Size = new Size(428, 161);
            roundPanel7.TabIndex = 9;
            // 
            // button13
            // 
            button13.Cursor = Cursors.Hand;
            button13.FlatAppearance.BorderColor = SystemColors.ControlLightLight;
            button13.FlatAppearance.BorderSize = 6;
            button13.FlatStyle = FlatStyle.Flat;
            button13.Font = new Font("Segoe UI Variable Text", 16F, FontStyle.Bold, GraphicsUnit.Point);
            button13.Location = new Point(3, 29);
            button13.Name = "button13";
            button13.Size = new Size(315, 55);
            button13.TabIndex = 5;
            button13.Text = "Return to the options";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(851, 235);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(348, 45);
            comboBox1.TabIndex = 11;
            comboBox1.Text = "Choose Office Id:";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(851, 235);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(348, 45);
            comboBox2.TabIndex = 12;
            comboBox2.Text = "Choose Office' name:";
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox1.Location = new Point(851, 304);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(223, 43);
            textBox1.TabIndex = 13;
            textBox1.Text = "Min Price";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox2.Location = new Point(851, 363);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(223, 43);
            textBox2.TabIndex = 14;
            textBox2.Text = "Max Price";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(851, 235);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(348, 45);
            comboBox3.TabIndex = 15;
            comboBox3.Text = "Choose Brand:";
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ButtonHighlight;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(212, 110);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 16;
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
            label3.TabIndex = 17;
            label3.Text = "Become renter";
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
            label6.TabIndex = 18;
            label6.Text = "Rental deals";
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
            label4.TabIndex = 19;
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
            label5.TabIndex = 20;
            label5.Text = "Why choose us";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(851, 423);
            button1.Name = "button1";
            button1.Size = new Size(103, 37);
            button1.TabIndex = 21;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // OptionsOfYes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1153);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(comboBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(roundPanel7);
            Controls.Add(richTextBox1);
            Controls.Add(pictureBox1);
            Name = "OptionsOfYes";
            Text = "DRIVETIME RENTALS";
            Load += OptionsOfYes_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            roundPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        public RichTextBox richTextBox1;
        private RoundPanel roundPanel7;
        private Button button13;
        public ComboBox comboBox1;
        public ComboBox comboBox2;
        public TextBox textBox1;
        public TextBox textBox2;
        public ComboBox comboBox3;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label6;
        private Label label4;
        private Label label5;
        public Button button1;
    }
}
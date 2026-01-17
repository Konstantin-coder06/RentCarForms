using RentCar.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCar.WinForm1
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            InitializeTextBox1();
            InitializeTextBox2();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        ControllerAdmin controllerAdmin;
     
        private void InitializeTextBox1()
        {
            textBox1.Text = "Username";
            textBox1.ForeColor = Color.Gray;

            textBox1.Enter += new EventHandler(RemoveText1);
            textBox1.Leave += new EventHandler(AddText1);
        }

        public void RemoveText1(object sender, EventArgs e)
        {
            if (textBox1.Text == "Username")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        public void AddText1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Username";
                textBox1.ForeColor = Color.Gray;
            }
        }
        private void InitializeTextBox2()
        {
            textBox2.Text = "Password";
            textBox2.ForeColor = Color.Gray;

            textBox2.Enter += new EventHandler(RemoveText2);
            textBox2.Leave += new EventHandler(AddText2);
        }

        public void RemoveText2(object sender, EventArgs e)
        {
            if (textBox2.Text == "Password")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        public void AddText2(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.Text = "Password";
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            controllerAdmin=new ControllerAdmin();
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            string inf=await controllerAdmin.Locate(textBox1.Text,textBox2.Text);
           
            if(inf == "Welcome")
            {
                No no = new No();
                no.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show(inf);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

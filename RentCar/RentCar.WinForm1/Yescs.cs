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
using RentCar.Data.Entities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace RentCar.WinForm1
{
    public partial class Yescs : Form
    {
        public Yescs()
        {
            InitializeComponent();
        }
        ControllerOffice controllerOffice = new ControllerOffice();
        ControllerCar controllerCar = new ControllerCar();
        ControllerCType controllerCType = new ControllerCType();
        ControllerCar_Type controllerCar_Type = new ControllerCar_Type();
        ControllerCustomer customer = new ControllerCustomer();
        ControllerReservation reservation = new ControllerReservation();
        private async void Yescs_Load(object sender, EventArgs e)
        {
          await  controllerOffice.InsertOffice();
           await controllerCar.InsertCar();
           await controllerCType.InsertType();
           await controllerCar_Type.InsertCarTypes();
           await customer.InsertCustomer();
           await reservation.InsertReservation();
        }

        private void button13_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            string inf = await controllerCar.ShowAllCarFromAllOffices();
            OptionsOfYes yes = new OptionsOfYes();

            yes.richTextBox1.Text += "All cars from all offices\n\n";
            yes.richTextBox1.Text += inf;
            yes.comboBox1.Visible = false;
            yes.comboBox2.Visible = false;
            yes.comboBox3.Visible = false;
            yes.button1.Visible = false;
            yes.textBox1.Visible = false;
            yes.textBox2.Visible = false;
            yes.Show();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            string inf = await controllerOffice.ShowAllOffices();
            OptionsOfYes yes = new OptionsOfYes();

            yes.richTextBox1.Text += "--Offices--\n\n";
            yes.richTextBox1.Text += inf;
            yes.comboBox1.Text = "Choose Office Id:";
            yes.comboBox1.Visible = true;
            yes.comboBox2.Visible = false;
            yes.comboBox3.Visible = false;
            yes.button1.Visible = false;
            yes.textBox1.Visible = false;
            yes.textBox2.Visible = false;
            yes.Show();
        }
        private async void button3_Click(object sender, EventArgs e)
        {
            string inf = await controllerOffice.ShowOfficesDistinct();
            OptionsOfYes yes = new OptionsOfYes();

            yes.richTextBox1.Text += "--Offices--\n\n";         
            yes.richTextBox1.Text += inf;
            
            yes.comboBox1.Text = "Choose office' name:";
            yes.comboBox1.Visible = false;
            yes.comboBox2.Visible = true;
            yes.comboBox3.Visible = false;
            yes.button1.Visible = false;
            yes.textBox1.Visible = false;
            yes.textBox2.Visible = false;
            yes.Show();
        }
        private async void button4_Click(object sender, EventArgs e)
        {
            string inf = await controllerCar.ShowSedan();
            OptionsOfYes yes = new OptionsOfYes();
            if (inf == "There is no cars with this type now")
            {
                yes.richTextBox1.ForeColor = Color.Red;
                yes.richTextBox1.Text += $"{inf}. We will add soon";
            }
            else
            {
                yes.richTextBox1.Text += "--All Sedans--\n\n";
                yes.richTextBox1.Text += inf;
            }
            yes.comboBox1.Visible = false;
            yes.comboBox2.Visible = false;
            yes.comboBox3.Visible = false;
            yes.button1.Visible = false;
            yes.textBox1.Visible = false;
            yes.textBox2.Visible = false;
            yes.Show();
        }
        private async void button5_Click(object sender, EventArgs e)
        {
            string inf = await controllerCar.ShowCoupe();
            OptionsOfYes yes = new OptionsOfYes();

            if (inf == "There is no cars with this type now")
            {
                yes.richTextBox1.ForeColor = Color.Red;
                yes.richTextBox1.Text += $"{inf}. We will add soon";
            }
            else
            {
                yes.richTextBox1.Text += "--All Coupes--\n\n";
                yes.richTextBox1.Text += inf;
            }
            yes.comboBox1.Visible = false;
            yes.comboBox2.Visible = false;
            yes.comboBox3.Visible = false;
            yes.button1.Visible = false;
            yes.textBox1.Visible = false;
            yes.textBox2.Visible = false;
            yes.Show();
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            string inf = await controllerCar.ShowGrandCoupe();
            OptionsOfYes yes = new OptionsOfYes();

            if (inf == "There is no cars with this type now")
            {
                yes.richTextBox1.ForeColor = Color.Red;
                yes.richTextBox1.Text += $"{inf}. We will add soon";
            }
            else
            {
                yes.richTextBox1.Text += "--All Grand Coupes--\n\n";
                yes.richTextBox1.Text += inf;
            }
            yes.comboBox1.Visible = false;
            yes.comboBox2.Visible = false;
            yes.comboBox3.Visible = false;
            yes.button1.Visible = false;
            yes.textBox1.Visible = false;
            yes.textBox2.Visible = false;
            yes.Show();
        }
        private async void button7_Click(object sender, EventArgs e)
        {
            string inf = await controllerCar.ShowConvertable2();
            OptionsOfYes yes = new OptionsOfYes();
            if (inf == "There is no cars with this type now")
            {
                yes.richTextBox1.ForeColor = Color.Red;
                yes.richTextBox1.Text += $"{inf}. We will add soon";
            }
            else
            {
                yes.richTextBox1.Text += "--All Two-Seater Convertables--\n\n";
                yes.richTextBox1.Text += inf;
            }
            yes.comboBox1.Visible = false;
            yes.comboBox2.Visible = false;
            yes.comboBox3.Visible = false;
            yes.button1.Visible = false;
            yes.textBox1.Visible = false;
            yes.textBox2.Visible = false;
            yes.Show();
        }
        private async void button8_Click(object sender, EventArgs e)
        {
            string inf = await controllerCar.ShowConvertable4();
            OptionsOfYes yes = new OptionsOfYes();
            if (inf == "There is no cars with this type now")
            {
                yes.richTextBox1.ForeColor = Color.Red;
                yes.richTextBox1.Text += $"{inf}. We will add soon";
            }
            else
            {
                yes.richTextBox1.Text += "--All Four-Seater Convertables--\n\n";
                yes.richTextBox1.Text += inf;
            }
            yes.comboBox1.Visible = false;
            yes.comboBox2.Visible = false;
            yes.comboBox3.Visible = false;
            yes.button1.Visible = false;
            yes.textBox1.Visible = false;
            yes.textBox2.Visible = false;
            yes.Show();
        }
        private async void button9_Click(object sender, EventArgs e)
        {
            string inf = await controllerCar.ShowSUV5();
            OptionsOfYes yes = new OptionsOfYes();
            if (inf == "There is no cars with this type now")
            {
                yes.richTextBox1.ForeColor = Color.Red;
                yes.richTextBox1.Text += $"{inf}. We will add soon";
            }
            else
            {
                yes.richTextBox1.Text += "--All Fife-Seater SUVs--\n\n";
                yes.richTextBox1.Text += inf;
            }

            yes.comboBox1.Visible = false;
            yes.comboBox2.Visible = false;
            yes.comboBox3.Visible = false;
            yes.button1.Visible = false;
            yes.textBox1.Visible = false;
            yes.textBox2.Visible = false;
            yes.Show();
        }

        private async void button10_Click(object sender, EventArgs e)
        {
            string inf = await controllerCar.ShowSUV7();
            OptionsOfYes yes = new OptionsOfYes();

            if (inf == "There is no cars with this type now")
            {
                yes.richTextBox1.ForeColor = Color.Red;
                yes.richTextBox1.Text += $"{inf}. We will add soon";
            }
            else
            {
                yes.richTextBox1.Text += "--All Seven-Seater SUVs--\n\n";
                yes.richTextBox1.Text += inf;
            }
            yes.button1.Visible = false;
            yes.comboBox1.Visible = false;
            yes.comboBox2.Visible = false;
            yes.comboBox3.Visible = false;
            yes.textBox1.Visible = false;
            yes.textBox2.Visible = false;
            yes.Show();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            OptionsOfYes yes = new OptionsOfYes();
            yes.comboBox1.Visible = false;
            yes.comboBox2.Visible = false;
            yes.comboBox3.Visible = false;

            yes.textBox1.Visible = true;
            yes.textBox2.Visible = true;
            yes.Show();
        }

        private async void button12_Click(object sender, EventArgs e)
        {
            string inf = await controllerCar.ShowBrands();
            OptionsOfYes yes = new OptionsOfYes();
            if (inf == "There is no cars with this brand now")
            {
                yes.richTextBox1.ForeColor = Color.Red;
                yes.richTextBox1.Text += $"{inf}. We will add soon";
            }
            else
            {
                yes.richTextBox1.Text += "--Brands--\n\n";
                yes.richTextBox1.Text += inf;
            }
            yes.comboBox1.Visible = false;
            yes.comboBox2.Visible = false;
            yes.comboBox3.Visible = true;

            yes.button1.Visible = false;
            yes.textBox1.Visible = false;
            yes.textBox2.Visible = false;
            yes.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private async void button14_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.label1.Text = "To add reservation enter:";
            addForm.label2.Text = "Start date";
            addForm.label3.Text = "End date";
            addForm.label4.Text = "Start location";
            addForm.label5.Text = "End location";
            addForm.label6.Text = "Start city";
            addForm.label11.Text = "End city";
            addForm.label15.Visible = false;
            addForm.label14.Visible = false;
            addForm.label12.Visible = false;
            addForm.label13.Visible = false;

            addForm.textBox7.Visible = false;
            addForm.textBox8.Visible = false;
            addForm.textBox9.Visible = false;
            addForm.textBox10.Visible = false;
            addForm.comboBox1.Location = new Point(536, 704);
            addForm.comboBox2.Visible = false;
            addForm.comboBox6.Visible = false;
            addForm.comboBox8.Visible = false;

            addForm.richTextBox1.Text = await controllerCar.ShowBrandsAndModels();
            addForm.richTextBox3.Text = await customer.ALlCustomers();
            addForm.richTextBox2.Visible = false;
            addForm.richTextBox1.Location = new Point(39, 704);
            addForm.button1.Location = new Point(39, 965);
            addForm.button1.Text = "Calculate the price";
            addForm.button4.Visible = false;
            addForm.button2.Visible = false;
            addForm.Show();
        }

        private void roundPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void button15_Click(object sender, EventArgs e)
        {
            string inf = await controllerCar.AllCombitionEngine();
            OptionsOfYes yes = new OptionsOfYes();

            yes.richTextBox1.Text += "--All Combition engine Car--\n\n";
            yes.richTextBox1.Text += inf;


            yes.comboBox1.Visible = false;
            yes.comboBox2.Visible = false;
            yes.comboBox3.Visible = false;
            yes.button1.Visible = false;
            yes.textBox1.Visible = false;
            yes.textBox2.Visible = false;
            yes.Show();
        }

        private async void button16_Click(object sender, EventArgs e)
        {
            string inf = await controllerCar.AllElectric();
            OptionsOfYes yes = new OptionsOfYes();

            yes.richTextBox1.Text += "--All Electric Car--\n\n";
            yes.richTextBox1.Text += inf;


            yes.comboBox1.Visible = false;
            yes.comboBox2.Visible = false;
            yes.comboBox3.Visible = false;
            yes.button1.Visible = false;
            yes.textBox1.Visible = false;
            yes.textBox2.Visible = false;
            yes.Show();
        }
    }
}

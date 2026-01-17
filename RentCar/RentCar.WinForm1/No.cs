using RentCar.Core;
using RentCar.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RentCar.WinForm1
{
    public partial class No : Form
    {
        public No()
        {
            InitializeComponent();
        }
        ControllerCar controllerCar;
        ControllerOffice controllerOffice;
        ControllerCustomer controllercustomer;
        ControllerCType controllerCType;
      
        private void No_Load(object sender, EventArgs e)
        {
            roundPanel4.Visible = false;
            roundPanel2.Visible = false;
            roundPanel5.Visible = false;
            controllerCar = new ControllerCar();
            controllerOffice = new ControllerOffice();
            controllercustomer = new ControllerCustomer();
            controllerCType = new ControllerCType();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            roundPanel5.Visible = false;
            roundPanel2.Visible = false;
            roundPanel4.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            roundPanel4.Visible = false;
            roundPanel5.Visible = false;
            roundPanel2.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            roundPanel5.Visible = true;
            roundPanel2.Visible = false;
            roundPanel4.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //UPDATE
        private async void button20_Click(object sender, EventArgs e)
        {
            //1
            AddRemoveUpdate addRemoveUpdate = new AddRemoveUpdate();
            addRemoveUpdate.label1.Text = "To change car's office ";
            addRemoveUpdate.label2.Text = "Choose car to move";
            addRemoveUpdate.label3.Text = "Choose office in which will be the car";
            addRemoveUpdate.label4.Visible = false;
            addRemoveUpdate.label5.Visible = false;
            addRemoveUpdate.label11.Visible = false;

            addRemoveUpdate.comboBox1.Visible = true;
            addRemoveUpdate.comboBox2.Visible = true;
            addRemoveUpdate.comboBox3.Visible = false;
            addRemoveUpdate.comboBox4.Visible = false;
            addRemoveUpdate.comboBox5.Visible = false;
            addRemoveUpdate.comboBox7.Visible = false;
            addRemoveUpdate.comboBox6.Visible = false;
            addRemoveUpdate.comboBox8.Visible = false;

            addRemoveUpdate.textBox1.Visible = false;
            addRemoveUpdate.textBox2.Visible = false;

            addRemoveUpdate.button1.Visible = false;
            addRemoveUpdate.button2.Visible = false;
            addRemoveUpdate.dateTimePicker1.Visible = false;

            addRemoveUpdate.richTextBox1.Text += await controllerCar.CarsOFfice();
            addRemoveUpdate.richTextBox2.Text += await controllerOffice.ShowAllOffices();
            addRemoveUpdate.Show();
        }

        private async void button19_Click(object sender, EventArgs e)
        {
            //2
            AddRemoveUpdate addRemoveUpdate = new AddRemoveUpdate();
            addRemoveUpdate.label1.Text = "To change car's rating";
            addRemoveUpdate.label2.Text = "Choose car";
            addRemoveUpdate.label3.Text = "Choose rating for the car";
            addRemoveUpdate.label4.Visible = false;
            addRemoveUpdate.label5.Visible = false;
            addRemoveUpdate.label11.Visible = false;

            addRemoveUpdate.comboBox1.Visible = false;
            addRemoveUpdate.comboBox2.Visible = false;
            addRemoveUpdate.comboBox3.Visible = true;
            addRemoveUpdate.comboBox4.Visible = false;
            addRemoveUpdate.comboBox5.Visible = false;
            addRemoveUpdate.comboBox7.Visible = false;
            addRemoveUpdate.comboBox6.Visible = false;
            addRemoveUpdate.comboBox8.Visible = false;

            addRemoveUpdate.textBox1.Visible = false;
            addRemoveUpdate.textBox2.Visible = false;

            addRemoveUpdate.button1.Visible = false;
            addRemoveUpdate.button2.Visible = false;

            addRemoveUpdate.dateTimePicker1.Visible = false;
            addRemoveUpdate.richTextBox2.Visible = false;

            addRemoveUpdate.richTextBox1.Text += await controllerCar.CarRating();
            addRemoveUpdate.Show();
        }

        private async void button18_Click(object sender, EventArgs e)
        {
            
                AddRemoveUpdate addRemoveUpdate = new AddRemoveUpdate();
                addRemoveUpdate.label1.Text = "To change customer's phone";
                addRemoveUpdate.label2.Text = "Choose customer";
                addRemoveUpdate.label3.Text = "Type new phone number for the car";
                addRemoveUpdate.label4.Text = "Phone";
                addRemoveUpdate.label4.Visible = false;
                addRemoveUpdate.label5.Visible = false;
                addRemoveUpdate.label11.Visible = false;

                addRemoveUpdate.comboBox1.Visible = false;
                addRemoveUpdate.comboBox2.Visible = false;
                addRemoveUpdate.comboBox3.Visible = false;
                addRemoveUpdate.comboBox4.Visible = false;
                addRemoveUpdate.comboBox5.Visible = true;
                addRemoveUpdate.comboBox6.Visible = false;
                addRemoveUpdate.comboBox7.Visible = false;
                addRemoveUpdate.comboBox8.Visible = false;

                addRemoveUpdate.richTextBox2.Visible = false;
                addRemoveUpdate.textBox1.Visible = false;
                addRemoveUpdate.textBox2.Visible = false;
                addRemoveUpdate.dateTimePicker1.Visible = false;

                addRemoveUpdate.button1.Visible = false;
                addRemoveUpdate.button2.Visible = false;
            button1.Text = "Change the phone number";
           // addRemoveUpdate.richTextBox1.Clear();
            //addRemoveUpdate.richTextBox1.Text = await controllercustomer.CustomerPhone();
            addRemoveUpdate.Show();
        }

        private async void button17_Click(object sender, EventArgs e)
        {
            AddRemoveUpdate addRemoveUpdate = new AddRemoveUpdate();
            addRemoveUpdate.label1.Text = "To change customer's city";
            addRemoveUpdate.label2.Text = "Choose customer";
            addRemoveUpdate.label3.Text = "Type new city for the customer";
            addRemoveUpdate.label4.Visible = false;
            addRemoveUpdate.label5.Visible = false;
            addRemoveUpdate.label11.Visible = false;

            addRemoveUpdate.comboBox1.Visible = false;
            addRemoveUpdate.comboBox2.Visible = false;
            addRemoveUpdate.comboBox3.Visible = false;
            addRemoveUpdate.comboBox4.Visible = false;
            addRemoveUpdate.comboBox5.Visible = true;
            addRemoveUpdate.comboBox6.Visible = false;
            addRemoveUpdate.comboBox7.Visible = false;
            addRemoveUpdate.comboBox8.Visible = false;

            addRemoveUpdate.richTextBox2.Visible = false;
            addRemoveUpdate.textBox1.Visible = false;
            addRemoveUpdate.textBox2.Visible = false;

            addRemoveUpdate.button1.Visible = false;
            addRemoveUpdate.button2.Visible = false;
            addRemoveUpdate.dateTimePicker1.Visible = false;
            addRemoveUpdate.button1.Width = 300;
            addRemoveUpdate.button1.Text = "Change the city";
            //addRemoveUpdate.richTextBox1.Text += await controllercustomer.CustomerCityCountry();
            addRemoveUpdate.Show();
        }

        private async void button14_Click(object sender, EventArgs e)
        {
            AddRemoveUpdate addRemoveUpdate = new AddRemoveUpdate();
            addRemoveUpdate.label1.Text = "To change customer's city and country";
            addRemoveUpdate.label2.Text = "Choose customer";
            addRemoveUpdate.label3.Text = "Type new city and country for the customer";
            addRemoveUpdate.label4.Visible = false;
            addRemoveUpdate.label5.Visible = false;
            addRemoveUpdate.label11.Visible = false;

            addRemoveUpdate.comboBox1.Visible = false;
            addRemoveUpdate.comboBox2.Visible = false;
            addRemoveUpdate.comboBox3.Visible = false;
            addRemoveUpdate.comboBox4.Visible = false;
            addRemoveUpdate.comboBox5.Visible = true;
            addRemoveUpdate.comboBox6.Visible = false;
            addRemoveUpdate.comboBox7.Visible = false;
            addRemoveUpdate.comboBox8.Visible = false;

            addRemoveUpdate.richTextBox2.Visible = false;
            addRemoveUpdate.textBox1.Visible = false;
            addRemoveUpdate.textBox2.Visible = false;
            addRemoveUpdate.dateTimePicker1.Visible = false;

            addRemoveUpdate.button1.Text = "Change the city and country for customer";
            addRemoveUpdate.button1.Width = 650;
            addRemoveUpdate.button1.Height = 63;
            addRemoveUpdate.button1.Visible = false;
            addRemoveUpdate.button2.Visible = false;

           // addRemoveUpdate.richTextBox1.Text += await controllercustomer.CustomerCityCountry();
            addRemoveUpdate.Show();
        }

        private async void button25_Click(object sender, EventArgs e)
        {
            AddRemoveUpdate addRemoveUpdate = new AddRemoveUpdate();
            addRemoveUpdate.label1.Text = "To change office's address";
            addRemoveUpdate.label2.Text = "Choose office";
            addRemoveUpdate.label3.Text = "Type new address for the office";
            addRemoveUpdate.label4.Text = "Address";
            addRemoveUpdate.label4.Visible = false;
            addRemoveUpdate.label5.Visible = false;
            addRemoveUpdate.label11.Visible = false;

            addRemoveUpdate.comboBox1.Visible = false;
            addRemoveUpdate.comboBox2.Visible = false;
            addRemoveUpdate.comboBox3.Visible = false;
            addRemoveUpdate.comboBox4.Visible = false;
            addRemoveUpdate.comboBox5.Visible = true;
            addRemoveUpdate.comboBox6.Visible = true;
            addRemoveUpdate.comboBox7.Visible = false;
            addRemoveUpdate.comboBox8.Visible = false;

            addRemoveUpdate.richTextBox2.Visible = false;
            addRemoveUpdate.textBox1.Visible = false;
            addRemoveUpdate.textBox2.Visible = false;
            addRemoveUpdate.dateTimePicker1.Visible = false;

            addRemoveUpdate.button1.Visible = false;
            addRemoveUpdate.button2.Visible = false;
            addRemoveUpdate.button1.Width = 500;
            addRemoveUpdate.button1.Text = "Change the address of the office";
            //addRemoveUpdate.richTextBox1.Text += await controllerOffice.ShowAllOffices();
            addRemoveUpdate.Show();
        }

        private async void button24_Click(object sender, EventArgs e)
        {
            AddRemoveUpdate addRemoveUpdate = new AddRemoveUpdate();
            addRemoveUpdate.label1.Text = "To change office's city";
            addRemoveUpdate.label2.Text = "Choose office";
            addRemoveUpdate.label3.Text = "Type new city for the office";
            addRemoveUpdate.label4.Visible = false;
            addRemoveUpdate.label5.Visible = false;
            addRemoveUpdate.label11.Visible = false;

            addRemoveUpdate.comboBox1.Visible = false;
            addRemoveUpdate.comboBox2.Visible = false;
            addRemoveUpdate.comboBox3.Visible = false;
            addRemoveUpdate.comboBox4.Visible = false;
            addRemoveUpdate.comboBox5.Visible = true;
            addRemoveUpdate.comboBox6.Visible = true;
            addRemoveUpdate.comboBox7.Visible = false;
            addRemoveUpdate.comboBox8.Visible = false;

            addRemoveUpdate.richTextBox2.Visible = false;
            addRemoveUpdate.textBox1.Visible = false;
            addRemoveUpdate.textBox2.Visible = false;
            addRemoveUpdate.dateTimePicker1.Visible = false;
            addRemoveUpdate.button1.Width = 500;
            addRemoveUpdate.button1.Text = "Change the city of the office";
            addRemoveUpdate.button1.Visible = false;
            addRemoveUpdate.button2.Visible = false;
          //  addRemoveUpdate.richTextBox1.Text += await controllerOffice.ShowAllOfficesCityCountry();
            addRemoveUpdate.Show();
        }

        private async void button22_Click(object sender, EventArgs e)
        {
            AddRemoveUpdate addRemoveUpdate = new AddRemoveUpdate();
            addRemoveUpdate.label1.Text = "To change office's city and country";
            addRemoveUpdate.label2.Text = "Choose office";
            addRemoveUpdate.label3.Text = "Type new city and country for the office";
            addRemoveUpdate.label4.Visible = false;
            addRemoveUpdate.label5.Visible = false;
            addRemoveUpdate.label11.Visible = false;

            addRemoveUpdate.comboBox1.Visible = false;
            addRemoveUpdate.comboBox2.Visible = false;
            addRemoveUpdate.comboBox3.Visible = false;
            addRemoveUpdate.comboBox4.Visible = false;
            addRemoveUpdate.comboBox5.Visible = true;
            addRemoveUpdate.comboBox6.Visible = true;
            addRemoveUpdate.comboBox7.Visible = false;
            addRemoveUpdate.comboBox8.Visible = false;

            addRemoveUpdate.dateTimePicker1.Visible = false;
            addRemoveUpdate.richTextBox2.Visible = false;
            addRemoveUpdate.textBox1.Visible = false;
            addRemoveUpdate.textBox2.Visible = false;

            addRemoveUpdate.button1.Visible = false;
            addRemoveUpdate.button2.Visible = false;
            addRemoveUpdate.button1.Width = 500;
            addRemoveUpdate.button1.Text = "Change the city and country for office";
            addRemoveUpdate.button1.Width = 616;
            addRemoveUpdate.button1.Height = 63;

            //addRemoveUpdate.richTextBox1.Text += await controllerOffice.ShowAllOfficesCityCountry();
            addRemoveUpdate.Show();
        }

        private async void button23_Click(object sender, EventArgs e)
        {
            AddRemoveUpdate addRemoveUpdate = new AddRemoveUpdate();
            addRemoveUpdate.label1.Text = "For which one customer do you want to change his reservation/s:";
            addRemoveUpdate.label2.Text = "Choose customer";
            addRemoveUpdate.label3.Text = "His/Her reservations:";
            addRemoveUpdate.label4.Visible = false;
            addRemoveUpdate.label5.Visible = false;
            addRemoveUpdate.label11.Visible = false;

            addRemoveUpdate.comboBox1.Visible = false;
            addRemoveUpdate.comboBox2.Visible = false;
            addRemoveUpdate.comboBox3.Visible = false;
            addRemoveUpdate.comboBox4.Visible = false;
            addRemoveUpdate.comboBox5.Visible = true;
            addRemoveUpdate.comboBox6.Visible = false;
            addRemoveUpdate.comboBox7.Visible = true;
            addRemoveUpdate.comboBox8.Visible = false;

            addRemoveUpdate.richTextBox2.Visible = false;
            addRemoveUpdate.textBox1.Visible = false;
            addRemoveUpdate.textBox2.Visible = false;
            addRemoveUpdate.dateTimePicker1.Visible = false;

            addRemoveUpdate.button1.Visible = false;
            addRemoveUpdate.button2.Visible = false;
            addRemoveUpdate.button2.Text = "Change the start date";

           // addRemoveUpdate.richTextBox1.Text += await controllercustomer.ShowEveryCustomer();
            addRemoveUpdate.Show();
        }

        private async void button21_Click(object sender, EventArgs e)
        {
            AddRemoveUpdate addRemoveUpdate = new AddRemoveUpdate();
            addRemoveUpdate.label1.Text = "For which one customer do you want to change his reservation/s:";
            addRemoveUpdate.label2.Text = "Choose customer";
            addRemoveUpdate.label3.Text = "His/Her reservations:";
            addRemoveUpdate.label4.Visible = false;
            addRemoveUpdate.label5.Visible = false;
            addRemoveUpdate.label11.Visible = false;

            addRemoveUpdate.comboBox1.Visible = false;
            addRemoveUpdate.comboBox2.Visible = false;
            addRemoveUpdate.comboBox3.Visible = false;
            addRemoveUpdate.comboBox4.Visible = false;
            addRemoveUpdate.comboBox5.Visible = true;
            addRemoveUpdate.comboBox6.Visible = false;
            addRemoveUpdate.comboBox7.Visible = true;
            addRemoveUpdate.comboBox8.Visible = false;

            addRemoveUpdate.richTextBox2.Visible = false;
            addRemoveUpdate.textBox1.Visible = false;
            addRemoveUpdate.textBox2.Visible = false;
            addRemoveUpdate.dateTimePicker1.Visible = false;

            addRemoveUpdate.button1.Visible = false;
            addRemoveUpdate.button2.Visible = false;
            addRemoveUpdate.button2.Text = "Change the end date";

           // addRemoveUpdate.richTextBox1.Text += await controllercustomer.ShowEveryCustomer();
            addRemoveUpdate.Show();
        }

        public void LabelTextBoxRemover(AddForm addForm)
        {
            addForm.label2.Visible = false;
            addForm.label3.Visible = false;
            addForm.label4.Visible = false;
            addForm.label5.Visible = false;
            addForm.label6.Visible = false;
            addForm.label11.Visible = false;
            addForm.label12.Visible = false;
            addForm.label15.Visible = false;
            addForm.label13.Visible = false;
            addForm.label14.Visible = false;
            addForm.label15.Visible = false;

            addForm.textBox1.Visible = false;
            addForm.textBox2.Visible = false;
            addForm.textBox3.Visible = false;
            addForm.textBox4.Visible = false;
            addForm.textBox5.Visible = false;
            addForm.textBox6.Visible = false;
            addForm.textBox7.Visible = false;
            addForm.textBox8.Visible = false;
            addForm.textBox9.Visible = false;
            addForm.textBox10.Visible = false;
        }





        //REMOVE
        private async void button16_Click(object sender, EventArgs e)
        {
            //Car
            AddForm addForm = new AddForm();
            addForm.label1.Text = "To delete car choose car's id";
            addForm.button1.Location = new Point(39, 456);
            addForm.button1.Text = "Delete Car";
            addForm.button4.Visible = false;
            addForm.button2.Visible = false;

            addForm.comboBox2.Visible = false;
            addForm.comboBox3.Visible = false;
            addForm.comboBox6.Visible = false;
            addForm.comboBox8.Visible = false;

            addForm.richTextBox1.Visible = false;
            addForm.richTextBox3.Visible = false;
            addForm.richTextBox2.Text = await controllerCar.ShowAllCarFromAllOfficesId();
            LabelTextBoxRemover(addForm);
            addForm.Show();
        }

        private async void button15_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.label1.Text = "To delete type choose type's id";
            addForm.button1.Location = new Point(39, 456);
            addForm.comboBox2.Location = new Point(524, 203);
            addForm.comboBox1.Visible = false;
            addForm.comboBox3.Visible = false;
            addForm.comboBox6.Visible = false;
            addForm.comboBox8.Visible = false;
            addForm.richTextBox2.Text = await controllerCType.ShowTypes();
            addForm.richTextBox1.Visible = false;
            addForm.richTextBox3.Visible = false;
            addForm.button1.Text = "Delete Type";
            addForm.button4.Visible = false;
            addForm.button2.Visible = false;
            LabelTextBoxRemover(addForm);
            addForm.Show();
        }

        private async void button13_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.label1.Text = "To delete customer choose customer's id";
            addForm.button1.Location = new Point(39, 456);
            addForm.comboBox3.Location = new Point(524, 203);
            addForm.comboBox1.Visible = false;
            addForm.comboBox2.Visible = false;
            addForm.comboBox6.Visible = false;
            addForm.comboBox8.Visible = false;
            addForm.richTextBox2.Text = await controllercustomer.ShowEveryCustomer();
            addForm.richTextBox1.Visible = false;
            addForm.richTextBox3.Visible = false;
            addForm.button1.Text = "Delete Customer";
            addForm.button4.Visible = false;
            addForm.button2.Visible = false;
            LabelTextBoxRemover(addForm);
            addForm.Show();
        }

        private async void button12_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.label1.Text = "To delete office choose office's id";
            addForm.button1.Location = new Point(39, 456);
            addForm.comboBox6.Location = new Point(524, 203);
            addForm.comboBox1.Visible = false;
            addForm.comboBox2.Visible = false;
            addForm.comboBox3.Visible = false;
            addForm.comboBox8.Visible = false;
            addForm.richTextBox2.Text = await controllerOffice.ShowAllOffices();
            addForm.richTextBox1.Visible = false;
            addForm.richTextBox3.Visible = false;
            addForm.button1.Text = "Delete Office";
            addForm.button4.Visible = false;
            addForm.button2.Visible = false;
            LabelTextBoxRemover(addForm);
            addForm.Show();
        }

        private async void button11_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.label1.Text = "For which one customer do you want to delete his reservation/s:";
            addForm.label2.Text = "Choose customer";
            addForm.label3.Text = "His/Her reservations:";
            addForm.comboBox1.Visible = false;
            addForm.comboBox2.Visible = false;
            addForm.comboBox6.Visible = false;
            addForm.comboBox8.Visible = false;
            addForm.richTextBox1.Visible = false;
            addForm.comboBox3.Location = new Point(524, 203);
            addForm.richTextBox2.Text += await controllercustomer.ShowEveryCustomer();
            addForm.button1.Text = "Delete Reservation";
            addForm.button4.Visible = false;
            addForm.button2.Visible = false;
            LabelTextBoxRemover(addForm);
            addForm.Show();
        }










        //ADD
        private async void button6_Click(object sender, EventArgs e)
        {
            //Car
            AddForm addForm = new AddForm();
            addForm.richTextBox2.Visible = false;
            addForm.richTextBox3.Visible = false;
            addForm.richTextBox1.Text = await controllerOffice.ShowAllOffices();
            addForm.button1.Text = "Add Car";
            addForm.comboBox1.Visible = false;
            addForm.comboBox2.Visible = false;
            addForm.comboBox3.Visible = false;
            addForm.comboBox8.Visible = false;
            addForm.button4.Visible = false;
            addForm.button2.Visible = false;
            addForm.Show();
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            //Car to type
            AddForm addForm = new AddForm();
            addForm.richTextBox2.Text = await controllerCar.ShowBrandsAndModels();
            addForm.richTextBox1.Text = await controllerCType.ShowTypes();
            addForm.button1.Text = "Add Car to Type";
            addForm.comboBox2.Visible = false;
            addForm.textBox1.Visible = false;
            addForm.textBox2.Visible = false;
            addForm.textBox3.Visible = false;
            addForm.textBox4.Visible = false;
            addForm.textBox5.Visible = false;
            addForm.textBox6.Visible = false;
            addForm.textBox7.Visible = false;
            addForm.textBox8.Visible = false;
            addForm.textBox9.Visible = false;
            addForm.textBox10.Visible = false;
            addForm.label15.Visible = false;
            addForm.label2.Visible = false;
            addForm.richTextBox3.Visible = false;
            addForm.comboBox3.Visible = false;
            addForm.comboBox8.Visible = false;
            addForm.label3.Visible = false;
            addForm.label4.Visible = false;
            addForm.label5.Visible = false;
            addForm.label6.Visible = false;
            addForm.label11.Visible = false;
            addForm.label13.Visible = false;
            addForm.label14.Visible = false;
            addForm.label12.Visible = false;
            addForm.richTextBox1.Visible = false;
            addForm.comboBox6.Visible = false;
            addForm.button4.Visible = false;
            addForm.button2.Visible = false;
            addForm.Show();
        }
        private async void button26_Click(object sender, EventArgs e)
        {
            //Electric
            AddForm addForm = new AddForm();
            addForm.label1.Text = "To add electric car enter";
            addForm.richTextBox2.Visible = false;
            addForm.richTextBox1.Text = await controllerOffice.ShowAllOffices();
            addForm.label12.Visible = false;
            addForm.textBox7.Visible = false;
            addForm.comboBox1.Visible = false;
            addForm.comboBox2.Visible = false;
            addForm.richTextBox3.Visible = false;
            addForm.comboBox8.Visible = false;
            addForm.comboBox3.Visible = false;
            addForm.button4.Visible = false;
            addForm.button2.Visible = false;
            addForm.button1.Text = "Add Electric Car";
            addForm.Show();
        }
        private async void button8_Click(object sender, EventArgs e)
        {
            //Type
            AddForm addForm = new AddForm();
            addForm.label1.Text = "To add type enter:";
            addForm.textBox4.Visible = false;
            addForm.textBox5.Visible = false;
            addForm.textBox6.Visible = false;
            addForm.textBox7.Visible = false;
            addForm.textBox8.Visible = false;
            addForm.textBox9.Visible = false;
            addForm.textBox10.Visible = false;
            addForm.comboBox8.Visible = false;
            addForm.label15.Visible = false;
            addForm.richTextBox3.Visible = false;
            addForm.comboBox3.Visible = false;
            addForm.label5.Visible = false;
            addForm.label6.Visible = false;
            addForm.label11.Visible = false;
            addForm.label13.Visible = false;
            addForm.label14.Visible = false;
            addForm.label12.Visible = false;
            addForm.richTextBox1.Visible = false;
            addForm.comboBox6.Visible = false;
            addForm.comboBox2.Visible = false;
            addForm.comboBox1.Visible = false;
            addForm.richTextBox2.Visible = false;
            addForm.button4.Visible = false;
            addForm.button2.Visible = false;
            addForm.label2.Text = "Name";
            addForm.label3.Text = "Seats";
            addForm.label4.Text = "Luxury Level";
            addForm.button1.Text = "Add Type";
            addForm.Show();
        }

        private async void button7_Click(object sender, EventArgs e)
        {
            //Customer
            AddForm addForm = new AddForm();
            addForm.label1.Text = "To add customer enter:";
            addForm.label2.Text = "First Name";
            addForm.label3.Text = "Last Name";
            addForm.label4.Text = "EGN";
            addForm.label5.Text = "Credit card №";
            addForm.label6.Text = "Email";
            addForm.label11.Text = "Phone";
            addForm.label15.Text = "City";
            addForm.label13.Text = "Coutry";
            addForm.label14.Visible = false;
            addForm.label12.Visible = false;
            addForm.textBox7.Visible = false;
            addForm.textBox9.Visible = false;
            addForm.comboBox1.Visible = false;
            addForm.comboBox2.Visible = false;
            addForm.comboBox6.Visible = false;
            addForm.comboBox8.Visible = false;
            addForm.richTextBox1.Visible = false;
            addForm.richTextBox3.Visible = false;
            addForm.comboBox3.Visible = false;
            addForm.richTextBox2.Visible = false;
            addForm.button4.Visible = false;
            addForm.button2.Visible = false;
            addForm.button1.Text = "Add Customer";
            addForm.Show();
        }

        private async void button10_Click(object sender, EventArgs e)
        {
            //Office
            AddForm addForm = new AddForm();
            addForm.label1.Text = "To add office enter:";
            addForm.label2.Text = "Name";
            addForm.label3.Text = "Address";
            addForm.label4.Text = "City";
            addForm.label5.Text = "Country";
            addForm.label6.Visible = false;
            addForm.label11.Visible = false;
            addForm.label15.Visible = false;
            addForm.label13.Visible = false;
            addForm.label14.Visible = false;
            addForm.label12.Visible = false;
            addForm.textBox5.Visible = false;
            addForm.textBox6.Visible = false;
            addForm.textBox7.Visible = false;
            addForm.textBox8.Visible = false;
            addForm.textBox9.Visible = false;
            addForm.textBox10.Visible = false;
            addForm.comboBox1.Visible = false;
            addForm.comboBox2.Visible = false;
            addForm.comboBox6.Visible = false;
            addForm.comboBox8.Visible = false;
            addForm.richTextBox1.Visible = false;
            addForm.richTextBox2.Visible = false;
            addForm.richTextBox3.Visible = false;
            addForm.button4.Visible = false;
            addForm.button2.Visible = false;
            addForm.comboBox3.Visible = false;
            addForm.button1.Text = "Add Office";
            addForm.Show();
        }

        private async void button9_Click(object sender, EventArgs e)
        {
            //Reservation
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
            addForm.richTextBox3.Text = await controllercustomer.ALlCustomers();
            addForm.richTextBox2.Visible = false;
            addForm.richTextBox1.Location = new Point(39, 704);
            addForm.button1.Location = new Point(39, 965);
            addForm.button1.Width = 366;
            addForm.button1.Text = "Calculate the price";
            addForm.button4.Visible = false;
            addForm.button2.Visible = false;
            addForm.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

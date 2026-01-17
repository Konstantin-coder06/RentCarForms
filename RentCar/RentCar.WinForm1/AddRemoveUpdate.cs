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
    public partial class AddRemoveUpdate : Form
    {
        public AddRemoveUpdate()
        {
            InitializeComponent();
        }
        ControllerCar controllerCar;
        ControllerOffice controllerOffice;
        ControllerCustomer customer;
        ControllerReservation reservation;
        private async void AddRemoveUpdate_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
            comboBox2.Visible = false;
            richTextBox2.Visible = false;
            controllerCar = new ControllerCar();
            controllerOffice = new ControllerOffice();
            customer = new ControllerCustomer();
            reservation = new ControllerReservation();
            richTextBox1.ReadOnly = true;
            richTextBox2.ReadOnly = true;
            await LoadBrandsNamesIntoComboBox();
            await LoadOfficeIdIntoComboBox();
            LoadRatingIntoComboBox();
            await LoadCustomerIdIntoComboBox();
            if (button1.Text == "Change the phone number")
            {
                richTextBox1.Text = await customer.CustomerPhone();
            }
            if (button1.Text == "Change the city")
            {
                richTextBox1.Text = await customer.CustomerCityCountry();
            }
            if(button1.Text=="Change the city and country for customer")
            {
                richTextBox1.Text = await customer.CustomerCityCountry();
            }
            if(button1.Text == "Change the address of the office")
            {
                richTextBox1.Text += await controllerOffice.ShowAllOffices();
            }
            if (button1.Text== "Change the city of the office")
            {
                richTextBox1.Text += await controllerOffice.ShowAllOfficesCityCountry();
            }
            if(button1.Text== "Change the city and country for office")
            {
                richTextBox1.Text += await controllerOffice.ShowAllOfficesCityCountry();
            }
            if (button1.Text== "Change the start date")
            {
                richTextBox1.Text += await customer.ShowEveryCustomer();
            }
            if(button1.Text== "Change the end date")
            {
                richTextBox1.Text += await customer.ShowEveryCustomer();
            }
        }


        private async Task LoadBrandsNamesIntoComboBox()
        {
            List<int> officeIds = await controllerCar.FormShowCarsId();
            foreach (var id in officeIds)
            {
                comboBox1.Items.Add(id);
                comboBox3.Items.Add(id);
            }
        }

        private async Task LoadOfficeIdIntoComboBox()
        {
            List<int> officeIds = await controllerOffice.FormIdOffice();
            foreach (var id in officeIds)
            {
                comboBox2.Items.Add(id);
                comboBox6.Items.Add(id);
            }
        }

        private void LoadRatingIntoComboBox()
        {
            for (double i = 0.1; i <= 10; i += 0.1)
            {
                comboBox4.Items.Add(i.ToString("0.0"));
            }
        }

        private async Task LoadCustomerIdIntoComboBox()
        {
            List<int> officeIds = await customer.FormCustomerId();
            foreach (var id in officeIds)
            {
                comboBox5.Items.Add(id);
                comboBox7.Items.Add(id);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private async void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Change the phone number")
            {
                if (int.TryParse(comboBox5.SelectedItem.ToString(), out int customerId))
                {
                    string newPhone = textBox1.Text;
                    string inf = await customer.CustomerNewPhone(customerId, newPhone);
                    MessageBox.Show(inf);

                    richTextBox1.Clear();
                    richTextBox1.Text = await customer.CustomerPhone();


                }
                else
                {
                    MessageBox.Show("Selected item is not a valid office ID.");
                }
            }
            else if (button1.Text == "Change the city")
            {
                if (int.TryParse(comboBox5.SelectedItem.ToString(), out int customerId))
                {

                    string city = textBox1.Text;
                    string inf = await customer.CustomerNewCity(customerId, city);
                    MessageBox.Show(inf);
                    richTextBox1.Clear();
                    richTextBox1.Text += await customer.CustomerCityCountry();
                }
                else
                {
                    MessageBox.Show("Selected item is not a valid office ID.");
                }
            }
            else if (button1.Text == "Change the city and country for customer")
            {
                if (int.TryParse(comboBox5.SelectedItem.ToString(), out int customerId))
                {
                    string city = textBox1.Text;
                    string country = textBox2.Text;
                    string inf = await customer.CustomerNewCityCountry(customerId, city, country);
                    MessageBox.Show(inf);
                    richTextBox1.Clear();
                    richTextBox1.Text = await customer.CustomerCityCountry();
                }
                else
                {
                    MessageBox.Show("Selected item is not a valid office ID.");
                }
            }
            else if (button1.Text == "Change the address of the office")
            {
                if (int.TryParse(comboBox6.SelectedItem.ToString(), out int officeid))
                {
                    string address = textBox1.Text;
                    string inf = await controllerOffice.ChangeOfficeAddress(officeid, address);
                    MessageBox.Show(inf);
                    richTextBox1.Clear();
                    richTextBox1.Text += await controllerOffice.ShowAllOffices();
                }
                else
                {
                    MessageBox.Show("Selected item is not a valid office ID.");
                }
            }
            else if (button1.Text == "Change the city of the office")
            {
                if (int.TryParse(comboBox6.SelectedItem.ToString(), out int officeid))
                {
                    string city = textBox1.Text;
                    string inf = await controllerOffice.ChangeOfficeCity(officeid, city);
                    MessageBox.Show(inf);
                    richTextBox1.Clear();
                    richTextBox1.Text += await controllerOffice.ShowAllOfficesCityCountry();
                }
                else
                {
                    MessageBox.Show("Selected item is not a valid office ID.");
                }
            }
            else if (button1.Text == "Change the city and country for office")
            {
                if (int.TryParse(comboBox6.SelectedItem.ToString(), out int officeid))
                {
                    string city = textBox1.Text;
                    string country = textBox2.Text;
                    string inf = await controllerOffice.ChangeOfficeCityCountry(officeid, city, country);
                    MessageBox.Show(inf);
                    richTextBox1.Clear();
                    richTextBox1.Text += await controllerOffice.ShowAllOfficesCityCountry();
                }
                else
                {
                    MessageBox.Show("Selected item is not a valid office ID.");
                }
            }

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Change the start date")
            {
                DateTime start = DateTime.Parse(dateTimePicker1.Text);
                if (int.TryParse(comboBox7.SelectedItem.ToString(), out int idCust))
                {
                    if (int.TryParse(comboBox8.SelectedItem.ToString(), out int idReserv))
                    {
                        if (DateTime.TryParse(dateTimePicker1.Text.ToString(), out DateTime stea))
                        {
                            string inf = await reservation.ChangeStartDate(idReserv, stea);
                            MessageBox.Show(inf);
                            richTextBox2.Text = await reservation.ReservationsForCustomer(idCust);
                        }
                    }
                }
            }
            if (button2.Text == "Change the end date")
            {
                DateTime start = DateTime.Parse(dateTimePicker1.Text);
                if (int.TryParse(comboBox7.SelectedItem.ToString(), out int idCust))
                {
                    if (int.TryParse(comboBox8.SelectedItem.ToString(), out int idReserv))
                    {
                        if (DateTime.TryParse(dateTimePicker1.Text.ToString(), out DateTime end))
                        {
                            string inf = await reservation.ChangeEndDate(idReserv, end);
                            MessageBox.Show(inf);
                            richTextBox2.Text = await reservation.ReservationsForCustomer(idCust);
                        }
                    }
                }
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Visible = true;
            comboBox2.Visible = true;
            richTextBox2.Visible = true;
        }

        private async void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null)
            {
                richTextBox1.Clear();
                richTextBox1.Text = await controllerCar.CarsOFfice();

                if (int.TryParse(comboBox1.SelectedItem.ToString(), out int carId))
                {
                    if (int.TryParse(comboBox2.SelectedItem.ToString(), out int officeId))
                    {
                        string inf = await controllerCar.MoveCarOffice(carId, officeId);
                        MessageBox.Show(inf);
                        richTextBox1.Text = await controllerCar.CarsOFfice();
                    }
                    else
                    {
                        MessageBox.Show("Selected item is not a valid office ID.");
                    }
                }
            }
            else
            {
                MessageBox.Show("No item selected.");
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Visible = true;
            comboBox4.Visible = true;
        }

        private async void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedItem != null)
            {
                richTextBox1.Clear();
                richTextBox1.Text = await controllerCar.CarRating();

                if (int.TryParse(comboBox3.SelectedItem.ToString(), out int carId))
                {
                    if (double.TryParse(comboBox4.SelectedItem.ToString(), out double rating))
                    {


                        string inf = await controllerCar.CarUpdateRating(carId, rating);


                        MessageBox.Show(inf);
                        richTextBox1.Text = await controllerCar.CarRating();
                    }
                    else
                    {

                        MessageBox.Show("Selected item is not a valid office ID.");
                    }
                }
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Visible = true;
            textBox1.Visible = true;
            label4.Visible = true;
            if (button1.Text == "Change the city and country for customer")
            {

                label5.Visible = true;
                textBox2.Visible = true;
            }

            button1.Visible = true;
        }
        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Visible = true;
            textBox1.Visible = true;
            button1.Visible = true;
            if (button1.Text == "Change the city and country for office")
            {
                label4.Visible = true;
                label5.Visible = true;
                textBox2.Visible = true;
            }
            if (button1.Text == "Change the address of the office")
            {
                label4.Visible = true;
            }
            if (button1.Text == "Change the city of the office")
            {
                label4.Visible = true;
            }
        }

        private async void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox8.Items.Clear();
            label4.Visible = false; label5.Visible = false;
            textBox1.Visible = false; textBox2.Visible = false;
            label3.Visible = true;
            richTextBox2.Visible = true;

            comboBox8.Visible = true;
            if (int.TryParse(comboBox7.SelectedItem.ToString(), out int idCust))
            {
                string inf = await reservation.ReservationsForCustomer(idCust);
                if (inf == "This customer don't have reservation/s")
                {
                    richTextBox2.ForeColor = Color.Red;
                    richTextBox2.Text = inf;
                }
                else
                {
                    richTextBox2.ForeColor = Color.Black;
                    richTextBox2.Text = inf;
                    List<int> officeIds = await reservation.LoadReservationsForCustomer(idCust);
                    foreach (var id in officeIds)
                    {
                        comboBox8.Items.Add(id);
                    }
                }

            }

        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            label11.Visible = true;
            dateTimePicker1.Visible = true;
            button2.Visible = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

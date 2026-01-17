using Microsoft.EntityFrameworkCore.Query.Internal;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace RentCar.WinForm1
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }
        ControllerOffice controllerOffice;
        ControllerCar controllerCar;
        ControllerCType controllerCType;
        ControllerCar_Type controllerType;
        ControllerCustomer controllerCustomer;
        ControllerReservation controllerReservation;
        private async void AddForm_Load(object sender, EventArgs e)
        {
            controllerOffice = new ControllerOffice();
            controllerCar = new ControllerCar();
            controllerCType = new ControllerCType();
            controllerType = new ControllerCar_Type();
            controllerCustomer = new ControllerCustomer();
            controllerReservation = new ControllerReservation();
            await LoadOfficeIdIntoComboBox();
            await LoadCarsIdIntoComboBox();
            await LoadTypesIdIntoComboBox();
            await LoadCustomerIdIntoComboBox();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private async Task LoadOfficeIdIntoComboBox()
        {
            List<int> officeIds = await controllerOffice.FormIdOffice();
            foreach (var id in officeIds)
            {
                comboBox6.Items.Add(id);
            }
        }
        private async Task LoadCarsIdIntoComboBox()
        {
            List<int> officeIds = await controllerCar.FormShowCarsId();
            foreach (var id in officeIds)
            {
                comboBox1.Items.Add(id);
            }
        }
        private async Task LoadTypesIdIntoComboBox()
        {
            List<int> officeIds = await controllerCType.FormIdType();
            foreach (var id in officeIds)
            {
                comboBox2.Items.Add(id);
            }
        }
        private async Task LoadCustomerIdIntoComboBox()
        {
            List<int> officeIds = await controllerCustomer.FormCustomerId();
            foreach (var id in officeIds)
            {
                comboBox3.Items.Add(id);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Add Car")
            {
                if (!string.IsNullOrWhiteSpace(this.textBox1.Text))
                {
                    if (!string.IsNullOrWhiteSpace(this.textBox2.Text))
                    {
                        if (!string.IsNullOrWhiteSpace(this.textBox3.Text))
                        {

                            if (!string.IsNullOrWhiteSpace(this.textBox4.Text))
                            {

                                if (!string.IsNullOrWhiteSpace(this.textBox5.Text))
                                {

                                    if (!string.IsNullOrWhiteSpace(this.textBox6.Text))
                                    {

                                        if (!string.IsNullOrWhiteSpace(this.textBox7.Text))
                                        {

                                            if (!string.IsNullOrWhiteSpace(this.textBox8.Text))
                                            {

                                                if (!string.IsNullOrWhiteSpace(this.textBox9.Text))
                                                {

                                                    if (!string.IsNullOrWhiteSpace(this.textBox10.Text))
                                                    {

                                                        if (int.TryParse(comboBox6.SelectedItem.ToString(), out int officeid))
                                                        {


                                                            string inf = await controllerCar.AddCar(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text),
                                                                textBox4.Text, textBox5.Text, int.Parse(textBox6.Text), false,
                                                                double.Parse(textBox7.Text), int.Parse(textBox8.Text),
                                                                textBox9.Text, double.Parse(textBox10.Text), officeid);
                                                            MessageBox.Show(inf);
                                                        }

                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if (button1.Text == "Add Electric Car")
            {
                if (!string.IsNullOrWhiteSpace(this.textBox1.Text))
                {
                    if (!string.IsNullOrWhiteSpace(this.textBox2.Text))
                    {
                        if (!string.IsNullOrWhiteSpace(this.textBox3.Text))
                        {

                            if (!string.IsNullOrWhiteSpace(this.textBox4.Text))
                            {

                                if (!string.IsNullOrWhiteSpace(this.textBox5.Text))
                                {

                                    if (!string.IsNullOrWhiteSpace(this.textBox6.Text))
                                    {



                                        if (!string.IsNullOrWhiteSpace(this.textBox8.Text))
                                        {

                                            if (!string.IsNullOrWhiteSpace(this.textBox9.Text))
                                            {

                                                if (!string.IsNullOrWhiteSpace(this.textBox10.Text))
                                                {

                                                    if (int.TryParse(comboBox6.SelectedItem.ToString(), out int officeid))
                                                    {
                                                        string inf = await controllerCar.AddElectricCar(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text),
                                                            textBox4.Text, textBox5.Text, int.Parse(textBox6.Text),
                                                            true, int.Parse(textBox8.Text), textBox9.Text, double.Parse(textBox10.Text), officeid);
                                                        MessageBox.Show(inf);
                                                    }
                                                }
                                            }
                                        }

                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if (button1.Text == "Add Car to Type")
            {
                if (comboBox2.SelectedItem != null)
                {

                    if (int.TryParse(comboBox1.SelectedItem.ToString(), out int carId))
                    {
                        if (int.TryParse(comboBox2.SelectedItem.ToString(), out int typeId))
                        {
                            string inf = await controllerType.AddCarType(carId, typeId);
                            MessageBox.Show(inf);
                        }
                        else
                        {
                            MessageBox.Show("Selected item is not a valid office ID.");
                        }
                    }
                }
            }
            else if (button1.Text == "Add Type")
            {
                if (!string.IsNullOrWhiteSpace(this.textBox1.Text))
                {
                    if (!string.IsNullOrWhiteSpace(this.textBox2.Text))
                    {
                        if (!string.IsNullOrWhiteSpace(this.textBox3.Text))
                        {
                            string inf = await controllerCType.AddType(textBox1.Text, int.Parse(textBox2.Text), textBox3.Text);
                            MessageBox.Show(inf);
                        }
                    }
                }
            }
            else if (button1.Text == "Add Customer")
            {
                if (!string.IsNullOrWhiteSpace(this.textBox1.Text))
                {
                    if (!string.IsNullOrWhiteSpace(this.textBox2.Text))
                    {
                        if (!string.IsNullOrWhiteSpace(this.textBox3.Text))
                        {

                            if (!string.IsNullOrWhiteSpace(this.textBox4.Text))
                            {

                                if (!string.IsNullOrWhiteSpace(this.textBox5.Text))
                                {

                                    if (!string.IsNullOrWhiteSpace(this.textBox6.Text))
                                    {
                                        if (!string.IsNullOrWhiteSpace(this.textBox10.Text))
                                        {
                                            if (!string.IsNullOrWhiteSpace(this.textBox8.Text))
                                            {
                                                string inf = await controllerCustomer.AddCustomer(textBox1.Text, textBox2.Text,
                                                    textBox3.Text, textBox4.Text, textBox5.Text,
                                                    textBox6.Text, textBox10.Text, textBox8.Text);
                                                MessageBox.Show(inf);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if (button1.Text == "Add Office")
            {
                if (!string.IsNullOrWhiteSpace(this.textBox1.Text))
                {
                    if (!string.IsNullOrWhiteSpace(this.textBox2.Text))
                    {
                        if (!string.IsNullOrWhiteSpace(this.textBox3.Text))
                        {

                            if (!string.IsNullOrWhiteSpace(this.textBox4.Text))
                            {
                                string inf = await controllerOffice.AddOffice(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
                                MessageBox.Show(inf);
                            }
                        }
                    }
                }
            }
            else if (button1.Text == "Calculate the price")
            {
                if (!string.IsNullOrWhiteSpace(this.textBox1.Text))
                {
                    if (!string.IsNullOrWhiteSpace(this.textBox2.Text))
                    {
                        if (!string.IsNullOrWhiteSpace(this.textBox3.Text))
                        {

                            if (!string.IsNullOrWhiteSpace(this.textBox4.Text))
                            {

                                if (!string.IsNullOrWhiteSpace(this.textBox5.Text))
                                {

                                    if (!string.IsNullOrWhiteSpace(this.textBox6.Text))
                                    {
                                        if (int.TryParse(comboBox1.SelectedItem.ToString(), out int carid))
                                        {
                                            if (int.TryParse(comboBox3.SelectedItem.ToString(), out int custid))
                                            {
                                                double price = await controllerCar.PricePerOneDayCarId(carid);
                                                DateTime start= DateTime.Parse(textBox1.Text);
                                                DateTime end= DateTime.Parse(textBox2.Text);
                                                if (start >= end)
                                                {
                                                    MessageBox.Show($"Start date is as end date or greater. Please remake it to ");
                                                }
                                                else
                                                {


                                                    int days = CalculateDays(DateTime.Parse(textBox1.Text), DateTime.Parse(textBox2.Text));
                                                    double total = price * days;

                                                    MessageBox.Show($"It will cost {total}$. \n Do you want to make the reservation? \n Choose yes or no");
                                                    button2.Visible = true;
                                                    button4.Visible = true;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if (button1.Text == "Delete Car")
            {
                if (int.TryParse(comboBox1.SelectedItem.ToString(), out int carid))
                {
                    string inf = await controllerCar.RemoveCar(carid);
                    comboBox1.Items.Clear();
                    MessageBox.Show(inf);
                    await LoadCarsIdIntoComboBox();
                }

            }
            else if (button1.Text == "Delete Type")
            {
                if (int.TryParse(comboBox2.SelectedItem.ToString(), out int typeid))
                {
                    string inf = await controllerCType.RemoveType(typeid);
                    MessageBox.Show(inf);
                    comboBox2.Items.Clear();
                    await LoadTypesIdIntoComboBox();
                    richTextBox2.Text = await controllerCType.ShowTypes();
                }

            }
            else if (button1.Text == "Delete Customer")
            {
                if (int.TryParse(comboBox3.SelectedItem.ToString(), out int customerid))
                {
                    string inf = await controllerCustomer.RemoveCustomer(customerid);
                    MessageBox.Show(inf);
                    comboBox3.Items.Clear();
                    await LoadCustomerIdIntoComboBox();
                    richTextBox2.Text = await controllerCustomer.ShowEveryCustomer();
                }

            }
            else if (button1.Text == "Delete Office")
            {
                if (int.TryParse(comboBox6.SelectedItem.ToString(), out int officeid))
                {
                    string inf = await controllerOffice.RemoveOffice(officeid);
                    MessageBox.Show(inf);
                    comboBox6.Items.Clear();
                    await LoadOfficeIdIntoComboBox();
                    richTextBox2.Text = await controllerOffice.ShowAllOffices();
                }

            }
            else if (button1.Text == "Delete Reservation")
            {
                if (int.TryParse(comboBox3.SelectedItem.ToString(), out int custid))
                {
                    if (int.TryParse(comboBox8.SelectedItem.ToString(), out int resid))
                    {
                        string inf = await controllerReservation.RemoveReservation(resid);
                        MessageBox.Show(inf);
                    }
                }

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            if (int.TryParse(comboBox1.SelectedItem.ToString(), out int carid))
            {
                if (int.TryParse(comboBox3.SelectedItem.ToString(), out int custid))
                {
                    string inf = await controllerReservation.AddReservation
                    (DateTime.Parse(textBox1.Text),
                    DateTime.Parse(textBox2.Text), textBox3.Text, textBox4.Text,
                    textBox5.Text, textBox6.Text, carid, custid);
                    MessageBox.Show(inf);
                }
            }
            button4.Visible = false;
            button2.Visible = false;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (button1.Text == "Calculate the price")
            {
                comboBox2.Visible = false;
                richTextBox1.Visible = true;
            }
            else
            {
                comboBox2.Visible = true;
                richTextBox1.Visible = true;
            }
        }

        public int CalculateDays(DateTime start, DateTime end)
        {
            TimeSpan difference = end - start;
            return difference.Days;
        }
        private async void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (button1.Text == "Delete Reservation")
            {
                comboBox8.Items.Clear();
                richTextBox1.Visible = true;
                comboBox8.Visible = true;
                if (int.TryParse(comboBox3.Text, out int cutsid))
                {
                    string inf = await controllerReservation.ReservationsForCustomer(cutsid);
                    if (inf == "This customer don't have reservation/s")
                    {
                        richTextBox1.ForeColor = Color.Red;
                        richTextBox1.Text = inf;
                    }
                    else
                    {
                        richTextBox1.ForeColor = Color.Black;
                        richTextBox1.Text = inf;
                        List<int> officeIds = await controllerReservation.LoadReservationsForCustomer(cutsid);
                        foreach (var id in officeIds)
                        {
                            comboBox8.Items.Add(id);
                        }
                    }
                }
            }
        }
        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

using RentCar.Core;
using RentCar.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCar.WinForm1
{
    public partial class OptionsOfYes : Form
    {
        public OptionsOfYes()
        {
            InitializeComponent();
            InitializeTextBox1();
            InitializeTextBox2();
            richTextBox1.ReadOnly = true;
        }
        ControllerOffice controllerOffice;
        ControllerCar controllerCar;
        private async void OptionsOfYes_Load(object sender, EventArgs e)
        {

            controllerOffice = new ControllerOffice();
            controllerCar = new ControllerCar();
            await LoadOfficeIdsIntoComboBox();
            await LoadOfficeNamesIntoComboBox();
            await LoadBrandsNamesIntoComboBox();
        }
        private async Task LoadOfficeIdsIntoComboBox()
        {
            List<int> officeIds = await controllerOffice.FormIdOffice();
            foreach (var id in officeIds)
            {
                comboBox1.Items.Add(id);
            }
        }
        private async Task LoadOfficeNamesIntoComboBox()
        {
            List<string> officeIds = await controllerOffice.FormNameOffice();
            foreach (var id in officeIds)
            {
                comboBox2.Items.Add(id);
            }
        }
        private async Task LoadBrandsNamesIntoComboBox()
        {
            List<string> officeIds = await controllerCar.FormShowBrands();
            foreach (var id in officeIds)
            {
                comboBox3.Items.Add(id);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                richTextBox1.Clear();

                if (int.TryParse(comboBox1.SelectedItem.ToString(), out int officeId))
                {
                    string inf = await controllerOffice.ShowAllOffices();
                    richTextBox1.Text += "--Offices--\n\n";
                    richTextBox1.Text += inf;
                    richTextBox1.Text += "--Cars--\n\n";
                    string infCars = await controllerCar.ShowAllCarFromOneOffice(officeId);


                    richTextBox1.Text += infCars;
                }
                else
                {

                    MessageBox.Show("Selected item is not a valid office ID.");
                }

            }
            else
            {

                MessageBox.Show("No item selected.");
            }


        }

        private async void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null)
            {
                richTextBox1.Clear();


                string officeName = comboBox2.SelectedItem.ToString();


                string inf = await controllerOffice.ShowOfficesDistinct();
                richTextBox1.Text += "--Offices--\n\n";
                richTextBox1.Text += $"{inf}";
                richTextBox1.Text += "\n--Cars--\n\n";

                richTextBox1.Text += await controllerCar.ShowAllCarFromOffices(officeName);
            }
            else
            {
                MessageBox.Show("No item selected.");
            }


        }

        private async void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem != null)
            {
                richTextBox1.Clear();


                string brandName = comboBox3.SelectedItem.ToString();


                string inf = await controllerCar.ShowBrands();
                richTextBox1.Text += "--Brands--\n\n";
                richTextBox1.Text += $"{inf}";
                richTextBox1.Text += "\n--Cars--\n\n";

                richTextBox1.Text += await controllerCar.ShowOneBrand(brandName);
            }
            else
            {
                MessageBox.Show("No item selected.");
            }

        }
        private void InitializeTextBox1()
        {
            textBox1.Text = "Min Price";
            textBox1.ForeColor = Color.Gray;

            textBox1.Enter += new EventHandler(RemoveText1);
            textBox1.Leave += new EventHandler(AddText1);
        }

        public void RemoveText1(object sender, EventArgs e)
        {
            if (textBox1.Text == "Min Price")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        public void AddText1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Min Price";
                textBox1.ForeColor = Color.Gray;
            }
        }
        private void InitializeTextBox2()
        {
            textBox2.Text = "Max Price";
            textBox2.ForeColor = Color.Gray;

            textBox2.Enter += new EventHandler(RemoveText2);
            textBox2.Leave += new EventHandler(AddText2);
        }

        public void RemoveText2(object sender, EventArgs e)
        {
            if (textBox2.Text == "Max Price")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        public void AddText2(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.Text = "Max Price";
                textBox2.ForeColor = Color.Gray;
            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.Text = "0";
            }
            if (richTextBox1.Text == "There is no cars")
            {
                richTextBox1.ForeColor = Color.Red;
            }
            else
            {
                richTextBox1.ForeColor = Color.Black;
            }

        }

        public void MaxMin(object sender, EventArgs e)
        {
            MessageBox.Show("Max value must be more than min!", "Eror!");
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = await controllerCar.ShowSpecifiedPrice(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
        }
    }
}

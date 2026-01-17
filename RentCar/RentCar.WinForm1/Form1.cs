namespace RentCar.WinForm1
{
    public partial class Form1 : Form
    {
        private Yescs yes;
        private No no;
        public Form1()
        {
            InitializeComponent();
            RoundPanel roundPanel = new RoundPanel();
            roundPanel.Size = new Size(200, 200);
            roundPanel.Location = new Point(50, 50);
            roundPanel.CornerRadius = 50;
            roundPanel.BackColor = Color.Coral;

            this.Controls.Add(roundPanel);
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
            //no = new No();
            // no.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            yes = new Yescs();
            yes.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}

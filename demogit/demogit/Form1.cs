namespace demogit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
if (txtUserName.Text == "Admin1" && txtPassword.Text == "Admin1") {
    MessageBox.Show("Login OK!");
}
        }
    }
}

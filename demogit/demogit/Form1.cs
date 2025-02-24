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
            if (txtUserName.Text == "Admin12345" && txtPassword.Text == "Admin123456") {
                MessageBox.Show("Login sucess!asdfghjkl");
            }

        }
    }
}

using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Virtual_ATM
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }

        private SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mafte\Documents\ATM.mdf;Integrated Security=True;Connect Timeout=30");

        private void login_btn_Click(object sender, EventArgs e)
        {
            int balance = 0;

            if (accNum_txt.Text == "" || name_txt.Text == "" || phone_txt.Text == "" || adress_txt.Text == "" || pin_txt.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into AccountTbl values('" + accNum_txt.Text + "', '" + name_txt + "', '" + dateOfBirth.Value.Date + "', '" + phone_txt.Text + "', '" + adress_txt.Text + "', '" + occupation_txt.SelectedItem.ToString() + "', " + pin_txt.Text + ", " + balance + ")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account created successfully");
                    Con.Close();
                    Login log = new Login();
                    log.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}
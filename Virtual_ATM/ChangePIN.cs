using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Virtual_ATM
{
    public partial class ChangePIN : Form
    {
        public ChangePIN()
        {
            InitializeComponent();
        }

        private SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mafte\Documents\ATM.mdf;Integrated Security=True;Connect Timeout=30");
        private string AccNum = Login.AccNumber;

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void changePin_btn_Click(object sender, EventArgs e)
        {
            int newPIN;

            if (enterPIn_txt.Text == "" || confirmPIN_txt.Text == "")
            {
                MessageBox.Show("Please enter and confirm new PIN");
            }
            else if (enterPIn_txt.Text != confirmPIN_txt.Text)
            {
                MessageBox.Show("PINs don't match");
            }
            else
            {
                newPIN = Convert.ToInt32(enterPIn_txt.Text);

                try
                {
                    Con.Open();
                    string query = "update AccountTbl set PIN = " + newPIN + " where AccNum = '" + AccNum + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Password updated successfully");
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
    }
}
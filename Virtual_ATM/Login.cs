using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Virtual_ATM
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public static String AccNumber;
        private SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mafte\Documents\ATM.mdf;Integrated Security=True;Connect Timeout=30");

        private void signUp_btn_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.Show();
            this.Hide();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from AccountTbl where AccNum = '" + accountNr_txt.Text + "' and PIN = " + PIN_txt.Text + "", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                AccNumber = accountNr_txt.Text;
                Transactions t = new Transactions();
                t.Show();
                this.Hide();
                Con.Close();
            }
            else
            {
                MessageBox.Show("Wrong account number/PIN code");
            }

            Con.Close();
        }
    }
}
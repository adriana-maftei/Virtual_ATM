using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Virtual_ATM
{
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }

        private SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mafte\Documents\ATM.mdf;Integrated Security=True;Connect Timeout=30");
        private string AccNum = Login.AccNumber;

        private void back_btn_Click(object sender, EventArgs e)
        {
            Transactions t = new Transactions();
            t.Show();
            this.Hide();
        }

        private void deposit_btn_Click(object sender, EventArgs e)
        {
            if (amountMoney_txt.Text == "" || Convert.ToUInt32(amountMoney_txt.Text) <= 0)
            {
                MessageBox.Show("Please enter amount of money");
            }
            else
            {
                newBalance = oldBalance + Convert.ToInt32(amountMoney_txt.Text);

                try
                {
                    Con.Open();
                    string query = "update AccountTbl set Balance = " + newBalance + " where AccNum = '" + AccNum + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Money deposit successful");
                    Con.Close();
                    AddTransaction();

                    Transactions t = new Transactions();
                    t.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private int oldBalance, newBalance;

        private void GetBalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(" select Balance from AccountTbl where AccNum='" + AccNum + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            oldBalance = Convert.ToInt32(dt.Rows[0][0].ToString());
            Con.Close();
        }

        private void Deposit_Load(object sender, EventArgs e)
        {
            GetBalance();
        }

        private void AddTransaction()
        {
            string transactionType = "Deposit";

            try
            {
                Con.Open();
                string query = "insert into TransactionTbl values('" + AccNum + "', '" + transactionType + "', '" + amountMoney_txt.Text + "', '" + DateTime.Today.Date.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
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
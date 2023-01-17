using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Virtual_ATM
{
    public partial class FastCash : Form
    {
        public FastCash()
        {
            InitializeComponent();
        }

        private SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mafte\Documents\ATM.mdf;Integrated Security=True;Connect Timeout=30");
        private string AccNum = Login.AccNumber;
        private int oldBalance, newBalance, moneyAmount;

        private void btn_back_Click(object sender, EventArgs e)
        {
            Transactions t = new Transactions();
            t.Show();
            this.Hide();
        }

        private void GetBalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(" select Balance from AccountTbl where AccNum='" + AccNum + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            oldBalance = Convert.ToInt32(dt.Rows[0][0].ToString());
            availableBalance_lbl.Text = "Available money: " + dt.Rows[0][0].ToString() + " $";
            Con.Close();
        }

        private void FastCash_Load(object sender, EventArgs e)
        {
            GetBalance();
        }

        private void AddTransaction()
        {
            string transactionType = "Fast Cash";

            try
            {
                Con.Open();
                string query = "insert into TransactionTbl values('" + AccNum + "', '" + transactionType + "', '" + moneyAmount + "', '" + DateTime.Today.Date.ToString() + "')";
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

        #region Fast Cash Options

        private void btn1000_Click(object sender, EventArgs e)
        {
            if (oldBalance < 1000)
                MessageBox.Show("Insufficient funds!");
            else
            {
                newBalance = oldBalance - 1000;
                moneyAmount = 1000;

                try
                {
                    Con.Open();
                    string query = "update AccountTbl set Balance = " + newBalance + " where AccNum = '" + AccNum + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Money withdraw successful");
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

        private void btn5000_Click(object sender, EventArgs e)
        {
            if (oldBalance < 5000)
                MessageBox.Show("Insufficient funds!");
            else
            {
                newBalance = oldBalance - 5000;
                moneyAmount = 5000;

                try
                {
                    Con.Open();
                    string query = "update AccountTbl set Balance = " + newBalance + " where AccNum = '" + AccNum + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Money withdraw successful");
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

        private void btn500_Click(object sender, EventArgs e)
        {
            if (oldBalance < 500)
                MessageBox.Show("Insufficient funds!");
            else
            {
                newBalance = oldBalance - 500;
                moneyAmount = 500;

                try
                {
                    Con.Open();
                    string query = "update AccountTbl set Balance = " + newBalance + " where AccNum = '" + AccNum + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Money withdraw successful");
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

        private void btn2500_Click(object sender, EventArgs e)
        {
            if (oldBalance < 2500)
                MessageBox.Show("Insufficient funds!");
            else
            {
                newBalance = oldBalance - 2500;
                moneyAmount = 2500;

                try
                {
                    Con.Open();
                    string query = "update AccountTbl set Balance = " + newBalance + " where AccNum = '" + AccNum + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Money withdraw successful");
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

        private void btn10000_Click(object sender, EventArgs e)
        {
            if (oldBalance < 10000)
                MessageBox.Show("Insufficient funds!");
            else
            {
                newBalance = oldBalance - 10000;
                moneyAmount = 10000;

                try
                {
                    Con.Open();
                    string query = "update AccountTbl set Balance = " + newBalance + " where AccNum = '" + AccNum + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Money withdraw successful");
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

        private void btn100_Click(object sender, EventArgs e)
        {
            if (oldBalance < 100)
                MessageBox.Show("Insufficient funds!");
            else
            {
                newBalance = oldBalance - 100;
                moneyAmount = 100;

                try
                {
                    Con.Open();
                    string query = "update AccountTbl set Balance = " + newBalance + " where AccNum = '" + AccNum + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Money withdraw successful");
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

        #endregion Fast Cash Options
    }
}
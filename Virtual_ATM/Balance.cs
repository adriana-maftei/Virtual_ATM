using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Virtual_ATM
{
    public partial class Balance : Form
    {
        public Balance()
        {
            InitializeComponent();
        }

        private SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mafte\Documents\ATM.mdf;Integrated Security=True;Connect Timeout=30");

        private void back_btn_Click(object sender, EventArgs e)
        {
            Transactions t = new Transactions();
            t.Show();
            this.Hide();
        }

        private void GetBalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(" select Balance from AccountTbl where AccNum='" + account_lbl.Text + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            balance_lbl.Text = dt.Rows[0][0].ToString() + " $";
            Con.Close();
        }

        private void Balance_Load(object sender, EventArgs e)
        {
            account_lbl.Text = Login.AccNumber;
            GetBalance();
        }
    }
}
using System;
using System.Windows.Forms;

namespace Virtual_ATM
{
    public partial class Transactions : Form
    {
        public Transactions()
        {
            InitializeComponent();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void deposit_btn_Click(object sender, EventArgs e)
        {
            Deposit d = new Deposit();
            d.Show();
            this.Hide();
        }

        private void cash_btn_Click(object sender, EventArgs e)
        {
            FastCash cash = new FastCash();
            cash.Show();
            this.Hide();
        }

        private void changePIN_btn_Click(object sender, EventArgs e)
        {
            ChangePIN cp = new ChangePIN();
            cp.Show();
            this.Hide();
        }

        private void withdraw_btn_Click(object sender, EventArgs e)
        {
            Withdraw w = new Withdraw();
            w.Show();
            this.Hide();
        }

        private void statement_btn_Click(object sender, EventArgs e)
        {
            Statement s = new Statement();
            s.Show();
            this.Hide();
        }

        private void balance_btn_Click(object sender, EventArgs e)
        {
            Balance b = new Balance();
            b.Show();
            this.Hide();
        }

        private void Transactions_Load(object sender, EventArgs e)
        {
            loggedAccount_lbl.Text = "Logged as: " + Login.AccNumber;
        }
    }
}
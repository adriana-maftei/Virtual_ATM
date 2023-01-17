using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Virtual_ATM
{
    public partial class Statement : Form
    {
        public Statement()
        {
            InitializeComponent();
        }

        private SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mafte\Documents\ATM.mdf;Integrated Security=True;Connect Timeout=30");
        private string AccNum = Login.AccNumber;

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Transactions t = new Transactions();
            t.Show();
            this.Hide();
        }

        private void populateDGV()
        {
            Con.Open();
            string query = "select * from TransactionTbl where AccNum='"+AccNum+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            statementDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Statement_Load(object sender, EventArgs e)
        {
            populateDGV();
        }
    }
}
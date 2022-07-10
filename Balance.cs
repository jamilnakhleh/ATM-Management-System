using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ATM_Management_System
{
    public partial class Balance : Form
    {
        public Balance()
        {
            InitializeComponent();
        }
        static string temp_String = @"C:\Users\Jamil H.Nakhleh\Documents\ATMDB.mdf";
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + temp_String.ToString() + ";Integrated Security=True;Connect Timeout=30");
        private void getBalance()
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from AccountTbl where AccNum = '"+AccountNumber_Lbl.Text+"'",conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            BalanceinRs_Lbl.Text = "$ " + dt.Rows[0][0].ToString();
            conn.Close();
        }

        private void LogOut_Label_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void AccountNumber_Lbl_Click(object sender, EventArgs e)
        {

        }

        private void Balance_Load(object sender, EventArgs e)
        {
            AccountNumber_Lbl.Text = Main.accnum;
            getBalance();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
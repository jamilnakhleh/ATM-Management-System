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
    public partial class Withdraw : Form
    {
        public Withdraw()
        {
            InitializeComponent();
        }

        static string temp_String = @"C:\Users\Jamil H.Nakhleh\Documents\ATMDB.mdf";
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + temp_String.ToString() + ";Integrated Security=True;Connect Timeout=30");
        string Acc = Login.AccNum;
        int balance = 0;
        Main main = new Main();
        private void getBalance()
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from AccountTbl where AccNum = '" + Acc + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            balance = Convert.ToInt32(dt.Rows[0][0].ToString());
            AvailableBalanceLBL.Text += " $ " + dt.Rows[0][0].ToString();
            conn.Close();
        }

        public void addtransaction()
        {
            try
            {
                conn.Open();
                string query = "insert into TransationTbl values('" + Acc + "','" + "Withdraw" + "','" + acc_Num_Txtbox.Text + "','" + DateTime.Today.Date.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Account Created Successfully!");
                conn.Close();
                main.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void Withdraw_Button_Click(object sender, EventArgs e)
        {
            if (acc_Num_Txtbox.Text == "")
                MessageBox.Show("Missing Information!");
            else if (Convert.ToInt32(acc_Num_Txtbox.Text) <= 0)
                MessageBox.Show("Enter a Valid Amount!");
            else if (Convert.ToInt32(acc_Num_Txtbox.Text) > balance)
                MessageBox.Show("Balance cannot be negative!");
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("update AccountTbl set Balance ='" + (balance - Convert.ToInt32(acc_Num_Txtbox.Text)) + "' where AccNum = '" + Acc + "'", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Success Withdraw!");
                    conn.Close();
                    addtransaction();
                    main.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void Withdraw_Load(object sender, EventArgs e)
        {
            getBalance();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_label_Click(object sender, EventArgs e)
        {
            main.Show();
            this.Hide();
        }
    }
}
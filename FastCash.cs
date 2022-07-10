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
    public partial class FastCash : Form
    {
        public FastCash()
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
            AvBalanceLabel.Text += "\n      $ " + dt.Rows[0][0].ToString();
            conn.Close();
        }

        private void LogOut_Label_Click(object sender, EventArgs e)
        {
            main.Show();
            this.Hide();
        }

        private void FastCash_Load(object sender, EventArgs e)
        {
            getBalance();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Dispose();
        }

        private void button100_Click(object sender, EventArgs e)
        {
            fast_cash(balance, button100, Acc);
            addtransaction(button100);
        }
        public int index = 0;
        public void fast_cash(int balance, Button button, string account_number)
        {
            int fast_withdraw;
            Int32.TryParse(string.Concat(button.Text.Where(char.IsDigit)), out fast_withdraw);
            if (balance < fast_withdraw)
            {
                MessageBox.Show("Balance cannot be negative!");
                index = 1;
            }
            else
            {
                index = 0;
                try
                {
                    //MessageBox.Show(balance.ToString());
                    //MessageBox.Show(fast_withdraw.ToString());
                    //MessageBox.Show(button.Text);
                    //MessageBox.Show(string.Concat(button.Text.Where(char.IsDigit)));
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("update AccountTbl set Balance ='" + (balance - fast_withdraw) + "' where AccNum = '" + account_number + "'", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Success Withdraw!");
                    conn.Close();

                    main.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

        }
        public void addtransaction(Button button)
        {

            try
            {
                if (index == 0)
                {
                    conn.Open();
                    string query = "insert into TransationTbl values('" + Acc + "','" + "Withdraw" + "','" + string.Concat(button.Text.Where(char.IsDigit)) + "','" + DateTime.Today.Date.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("Account Created Successfully!");
                    conn.Close();
                    main.Show();
                    this.Hide();
                }
                else index = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void button1000_Click(object sender, EventArgs e)
        {
            fast_cash(balance, button1000, Acc);
            addtransaction(button1000);
        }

        private void button5000_Click(object sender, EventArgs e)
        {
            fast_cash(balance, button5000, Acc);
            addtransaction(button5000);
        }

        private void button500_Click(object sender, EventArgs e)
        {
            fast_cash(balance, button500, Acc);
            addtransaction(button500);
        }

        private void button2000_Click(object sender, EventArgs e)
        {
            fast_cash(balance, button2000, Acc);
            addtransaction(button2000);
        }

        private void button10000_Click(object sender, EventArgs e)
        {
            fast_cash(balance, button10000, Acc);
            addtransaction(button10000);
        }
    }
}
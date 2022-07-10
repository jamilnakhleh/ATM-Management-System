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
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }
        static string temp_String = @"C:\Users\Jamil H.Nakhleh\Documents\ATMDB.mdf";
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + temp_String.ToString() + ";Integrated Security=True;Connect Timeout=30");
        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        string AccNum = Login.AccNum;
        Main main = new Main();
        public void addtransaction()
        {
            try
            {
                conn.Open();
                string query = "insert into TransationTbl values('" + AccNum + "','" + "Deposit" + "','" + acc_Num_Txtbox.Text + "','" + DateTime.Today.Date.ToString() + "')";
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
        private void Deposit_Button_Click(object sender, EventArgs e)
        {
            if (acc_Num_Txtbox.Text == "" || Convert.ToDouble(acc_Num_Txtbox.Text) <= 0)
            {
                MessageBox.Show("Enter amount to deposit!");
            }
            // try catch ; we try to deposit amount so we do use UPDATE.
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("update AccountTbl set Balance ='"+Convert.ToDouble(acc_Num_Txtbox.Text)+"'+Balance where AccNum = '"+AccNum+"'", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Success Deposit!");
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

        private void LogOut_Label_Click(object sender, EventArgs e)
        {
            main.Show();
            this.Hide();
        }
    }
}
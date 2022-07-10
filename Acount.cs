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
    public partial class Acount : Form
    {
        public Acount()
        {
            InitializeComponent();
        }
        static string temp_String = @"C:\Users\Jamil H.Nakhleh\Documents\ATMDB.mdf";
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+ temp_String.ToString() +";Integrated Security=True;Connect Timeout=30");

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Acount_Load(object sender, EventArgs e)
        {
            
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            int bal = 0;
            if (acc_Num_Txtbox.Text == "" || Name_Txtbox.Text == "" || FName_Txtbox.Text == "" || Address_Txtbox.Text == "" || PIN_Txtbox.Text == "" || Occupation_Txt.Text == "" || Phone_Txtbox.Text == "")
            {
                MessageBox.Show("Missing Information!");
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "insert into AccountTbl values('"+acc_Num_Txtbox.Text+ "','" + Name_Txtbox.Text + "','" + FName_Txtbox.Text + "','" + DOB_DATEPICKER.Value.Date + "','" + Phone_Txtbox.Text + "','" + Address_Txtbox.Text + "','" + Education_Combobox.SelectedItem.ToString() + "', '"+ Occupation_Txt.Text + "', '" + bal + "','" + PIN_Txtbox.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Created Successfully!");
                    conn.Close();
                    Login login = new Login();
                    login.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void SignUp_Label_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
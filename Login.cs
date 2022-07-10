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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public static string AccNum;

        static string temp_String = @"C:\Users\Jamil H.Nakhleh\Documents\ATMDB.mdf";
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + temp_String.ToString() + ";Integrated Security=True;Connect Timeout=30");

        private void SignUp_Label_Click(object sender, EventArgs e)
        {
            Acount account = new Acount();
            account.Show();
            this.Hide();
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from AccountTbl where AccNum = '" + accNum_textBox.Text+"' and Pin = '"+PinCode_textBox.Text+"'",conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                AccNum = accNum_textBox.Text;
                Main main = new Main();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong account number/PIN code");
            }           
            conn.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
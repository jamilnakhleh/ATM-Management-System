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
    public partial class ChangePin : Form
    {
        public ChangePin()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ChangePin_Load(object sender, EventArgs e)
        {

        }
        static string temp_String = @"C:\Users\Jamil H.Nakhleh\Documents\ATMDB.mdf";
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + temp_String.ToString() + ";Integrated Security=True;Connect Timeout=30");
        string Acc = Login.AccNum;
        Login login = new Login();
        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (newpintxt.Text == "" || confirmpintxt.Text == "")
            {
                MessageBox.Show("Enter And Confirm The New PIN!");
            }
            else if (confirmpintxt.Text != newpintxt.Text)
                MessageBox.Show("First & Second PIN are different!");
            else
            {
                try
                {
                    conn.Open();
                    MessageBox.Show(Acc);
                    MessageBox.Show(newpintxt.Text);
                    SqlCommand cmd = new SqlCommand("update AccountTbl set PIN ='" + newpintxt.Text + "' where AccNum = '" + Acc + "'", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("PIN Successfully Updated!");
                    conn.Close();
                    login.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Management_System
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void LogOut_Label_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Balance_Button_Click(object sender, EventArgs e)
        {
            Balance balance = new Balance();
            balance.Show();
            this.Hide();
        }
        public static string accnum = Login.AccNum;
        private void Main_Load(object sender, EventArgs e)
        {
            
            label2.Text += " : " + accnum;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Deposit_Button_Click(object sender, EventArgs e)
        {
            Deposit deposit = new Deposit();
            deposit.Show();
            this.Hide();
        }

        private void Withdraw_Button_Click(object sender, EventArgs e)
        {
            Withdraw withdraw = new Withdraw();
            withdraw.Show();
            this.Hide();
        }

        private void ChangePIN_Button_Click(object sender, EventArgs e)
        {
            ChangePin changePin = new ChangePin();
            changePin.Show();
            this.Hide();
        }

        private void FastCash_Button_Click(object sender, EventArgs e)
        {
            FastCash fastCash = new FastCash();
            fastCash.Show();
            this.Hide();
        }

        private void MiniSta_Button_Click(object sender, EventArgs e)
        {
            MiniStatement miniStatement = new MiniStatement();
            miniStatement.Show();
            this.Hide();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Planen
{
    public partial class LoginForm : Form
    {
        public NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=124578;Database=planen";
        public static NpgsqlCommand cmd;
        //public static NpgsqlCommand cmd2;
        private string sql = "";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            conn.Open();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            sql = "select account_id from account where username=:_email and password=:_password";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("_password", tbPassword.Text);
            cmd.Parameters.AddWithValue("_email", tbEmail.Text);

            if ((int)cmd.ExecuteScalar() > 0)
            {
                MessageBox.Show("Selamat Datang!", "well done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Account account = new Account();
                account.UserID = (int)cmd.ExecuteScalar();
                MainForm mainForm = new MainForm(account);
                mainForm.Show();
                this.Hide();
            }

            //MainForm mainForm = new MainForm();
            //mainForm.Show();
            //this.Hide();
        }
    }
}

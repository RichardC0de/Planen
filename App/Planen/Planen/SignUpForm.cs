using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Npgsql;

namespace Planen
{

    public partial class SignUpForm : Form
    {
        public NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=psqlf;Database=planen";
        public static NpgsqlCommand cmd;
        public static NpgsqlCommand cmd2;
        private string sql = null;
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void FormNew_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            conn.Open();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            try 
            {
                //sql = "select account_id from account where email=:_email";
                //cmd = new NpgsqlCommand(sql, conn);
                //cmd.Parameters.AddWithValue("_email", tbEmail.Text);
                //if ((int)cmd.ExecuteScalar() > 0)
                //{
                //    MessageBox.Show("Email sudah didaftarkan. Silahkan log in.", "!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //sql = null;
                sql = "select * from account_insert(:_username, :_password, :_email)";
                cmd2 = new NpgsqlCommand(sql, conn);
                cmd2.Parameters.AddWithValue("_username", tbUsername.Text);
                cmd2.Parameters.AddWithValue("_password", tbPassword.Text);
                cmd2.Parameters.AddWithValue("_email", tbEmail.Text);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Selamat! akun anda berhasil dibuat.", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Fail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //kemudian buka
            //MainForm mainForm = new MainForm();
            //mainForm.Show();
            //this.Hide();
        }
    }
}

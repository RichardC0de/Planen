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
    public partial class UserControlDays : UserControl
    {
        public static string static_day;
        public string cobadays;
        public NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=124578;Database=planen";
        public static NpgsqlCommand cmd;
        private string sql = "";

        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {
            displayEvent();
        }

        public void days(int numday)
        {
            lbdays.Text = numday + "";
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day = lbdays.Text;
            timer1.Start();
            AddEventForm addEventForm = new AddEventForm();
            addEventForm.Show();

        }
        public void displayEvent()
        {
            conn = new NpgsqlConnection(connstring);
            conn.Open();
            //cmd.CommandText = string.Format("SELECT * FROM event WHERE tanggal_event = ?");
            sql = "select nama_event from event where tanggal_event = :_tanggal_event and account_id = :_account_id";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("_tanggal_event", MainForm.static_month + "/" + lbdays.Text + "/" + MainForm.static_year);
            cmd.Parameters.AddWithValue("_account_id", Account.UserID);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                lb_event.Text = reader["nama_event"].ToString();
            }
            reader.Dispose();
            conn.Dispose();
            conn.Close();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            displayEvent();
        }
    }
}

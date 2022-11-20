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
        private void displayEvent()
        {
         
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            displayEvent();
        }
    }
}

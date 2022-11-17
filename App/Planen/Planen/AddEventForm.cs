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
    public partial class AddEventForm : Form
    {
        public NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=psqlf;Database=planen";
        public static NpgsqlCommand cmd;
        private string sql = null;
        public AddEventForm()
        {
            InitializeComponent();
        }

        private void AddEventForm_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new NpgsqlConnection(connstring);
                conn.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Fail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "select * from event_insert(:_tanggal_event,:_waktu,:_nama_event,:_deskripsi)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_tanggal_event", dtpTanggal.Value);
                cmd.Parameters.AddWithValue("_waktu", dtpWaktu.Value);
                cmd.Parameters.AddWithValue("_nama_event", tbName.Text);
                cmd.Parameters.AddWithValue("_deskripsi", tbDeskripsi.Text);
                if((int)cmd.ExecuteScalar()==1)
                {
                    MessageBox.Show("Data Event berhasil diinputkan!", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Fail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
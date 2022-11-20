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
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=124578;Database=planen";
        public static NpgsqlCommand cmd;
        private string sql = null;
        Event selectedEvent = new Event();
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
                sql = "select * from event where tanggal_event = :_tanggal_event";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_tanggal_event", MainForm.static_month + "/" + UserControlDays.static_day + "/" + MainForm.static_year);
                NpgsqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    //lb_event.Text = reader["nama_event"].ToString();
                    tbName.Text = reader["nama_event"].ToString();
                    tbDeskripsi.Text = reader["deskripsi"].ToString();
                    selectedEvent.EventID = Int32.Parse(reader["event_id"].ToString());
                    btnSave.Enabled = false;
                    btnSave.Visible = false;
                    btnDelete.Enabled = true;
                    btnDelete.Visible = true;
                    btnUpdate.Enabled = true;
                    btnUpdate.Visible = true;
                }
                else
                {
                    btnSave.Enabled = true;
                    btnSave.Visible = true;
                    btnDelete.Enabled = false;
                    btnDelete.Visible = false;
                    btnUpdate.Enabled = false;
                    btnUpdate.Visible = false;
                }
                reader.Dispose();
                conn.Dispose();
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Fail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tbDate.Text = MainForm.static_month + "/" + UserControlDays.static_day + "/" + MainForm.static_year;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //MainForm mainForm = new MainForm();
            //mainForm.Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                conn = new NpgsqlConnection(connstring);
                conn.Open();
                sql = "select * from event_insert(:_account_id,:_tanggal_event,:_nama_event,:_deskripsi)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_tanggal_event", tbDate.Text);
                //cmd.Parameters.AddWithValue("_waktu", dtpWaktu.Value);
                cmd.Parameters.AddWithValue("_nama_event", tbName.Text);
                cmd.Parameters.AddWithValue("_deskripsi", tbDeskripsi.Text);
                cmd.Parameters.AddWithValue("_account_id", Account.UserID);
                if ((int)cmd.ExecuteScalar() > 0)
                {
                    MessageBox.Show("Data Event berhasil diinputkan!", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                cmd.Dispose();
                conn.Close();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Fail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new NpgsqlConnection(connstring);
                conn.Open();
                //sql = "UPDATE event SET nama_event=:_nama_event, tanggal_event=:_tanggal_event, deskripsi=:_deskripsi, WHERE event_id=:_event_id";
                sql = "select * from event_update(:_event_id,:_nama_event,:_deskripsi,:_tanggal_event)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_event_id", selectedEvent.EventID);
                cmd.Parameters.AddWithValue("_tanggal_event", tbDate.Text);
                //cmd.Parameters.AddWithValue("_waktu", dtpWaktu.Value);
                cmd.Parameters.AddWithValue("_nama_event", tbName.Text);
                cmd.Parameters.AddWithValue("_deskripsi", tbDeskripsi.Text);
                if ((int)cmd.ExecuteScalar() > 0)
                {
                    MessageBox.Show("Data Event berhasil diUpdate!", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Fail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Refresh()
        {
            MainForm mainform = new MainForm();
            mainform.Show();
            this.Hide();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new NpgsqlConnection(connstring);
                conn.Open();
                //sql = "UPDATE event SET nama_event=:_nama_event, tanggal_event=:_tanggal_event, deskripsi=:_deskripsi, WHERE event_id=:_event_id";
                sql = "select * from event_delete(:_event_id)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_event_id", selectedEvent.EventID);
                if ((int)cmd.ExecuteScalar() > 0)
                {
                    MessageBox.Show("Data Event berhasil diHapus!", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Fail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Refresh();
        }


    }
}
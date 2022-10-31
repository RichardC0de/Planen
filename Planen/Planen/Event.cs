using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planen
{
    class Event
    {
        private int eventID;
        private DateTime tanggalEvent;
        private TimeOnly waktu;
        private string namaEvent;
        private string deskripsi;
        public int EventID { get { return eventID; } }
        public DateTime TanggalEvent { get { return tanggalEvent; } set { tanggalEvent = value; } }
        public TimeOnly Waktu { get { return waktu; } set { waktu = value; } }
        public string NamaEvent { get { return namaEvent; } set { namaEvent = value; } }
        public string Deskripsi { get { return deskripsi; } set { deskripsi = value; } }
        public void getEvent() { }
        public void saveEvent() { }
        public void editEvent() { }
    }
}

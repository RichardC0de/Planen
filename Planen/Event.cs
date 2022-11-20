using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planen
{
    public class Event
    {
        private int _eventID;
        private DateTime _tanggalEvent;
        private TimeOnly _waktu;
        private string _namaEvent;
        private string _deskripsi;
        public int EventID { get { return _eventID; } set { EventID = value; } }
        public DateTime TanggalEvent { get { return _tanggalEvent; } set { _tanggalEvent = value; } }
        public TimeOnly Waktu { get { return _waktu; } set { _waktu = value; } }
        public string NamaEvent { get { return _namaEvent; } set { _namaEvent = value; } }
        public string Deskripsi { get { return _deskripsi; } set { _deskripsi = value; } }
        public Event(int eventID, DateTime tanggalEvent, TimeOnly waktu, string namaEvent, string deskripsi)
        {
            this._eventID = eventID;
            TanggalEvent = tanggalEvent;
            Waktu = waktu;
            NamaEvent = namaEvent;
            Deskripsi = deskripsi;
            TanggalEvent = tanggalEvent;
            Waktu = waktu;
            NamaEvent = namaEvent;
            Deskripsi = deskripsi;
        }

        public void getEvent() { }
        public void saveEvent()
        {

        }
        public void editEvent() { }
    }
}
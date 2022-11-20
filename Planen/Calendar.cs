using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planen
{
    class Calendar
    {
        private int calendarID;
        private DateTime tanggal;
        private string notes;
        private int noTanggal;
        private string hari;
        public int CalendarID { get { return calendarID; } }    
        public DateTime Tanggal { get { return tanggal; } set { tanggal = value; } }
        public string Notes { get { return notes; } set { notes = value; } }
        public int NoTanggal { get { return noTanggal; } set { noTanggal = value; } }
        public string Hari { get { return hari; } set { hari = value; } }
        public void showCalendar() { }
        public void showEvent() { }
        public void reminder() { }
    }
}

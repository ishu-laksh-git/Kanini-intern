using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HsopitalModelLib
{
    public class Appointment
    {
        public int id { get; set; }
        public int d_id { get; set; }
        public int p_id { get; set; }
        public DateTime date { get; set; }
        public int slot { get; set; }
        public override string ToString()
        {
            string message = "";
            message += "Appointment Id : " + id;
            message += "\nDoctor Id : " + d_id;
            message += "\nPatient Id : " + p_id;
            message += "\nDate : " + date;
            return message;
        }
    }

}

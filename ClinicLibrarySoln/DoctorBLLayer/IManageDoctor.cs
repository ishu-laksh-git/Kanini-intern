using DoctorModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorBLLayer
{
    public interface IManageDoctor
    {
        Doctor[] GetDoctors();
        Doctor BookOppointment(int Id, out bool status);
        Doctor CancelOppointment(int Id, out bool status);
    
}
}

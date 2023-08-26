using DoctorDALLibrary;
using DoctorModelLibrary;

namespace DoctorBLLayer
{
    public class ManageDoctor : IManageDoctor
    {
        Doctor[] MyOpp;
        static int OppCount = 0;
        IRepo _repo;
        public ManageDoctor()
        {
            MyOpp = new Doctor[10];
        }
        public ManageDoctor(IRepo repo) : this()
        {
            _repo = repo;
        }


        public Doctor BookOppointment(int Id, out bool status)
        {
            status = false;
            bool result;
            Doctor doctor = DoctorPresent(Id, out result);
            if (doctor.OppointmentCount < 5)
            {
                if (result)
                {
                    if (OppCount < 10)
                    {
                        MyOpp[OppCount++] = doctor;
                        status = true;
                        doctor.OppointmentCount++;
                        return doctor;
                    }
                    else
                    {
                        for (int i = 0; i < MyOpp.Length; i++)
                        {
                            if (MyOpp[i] == null)
                            {
                                MyOpp[i] = doctor;
                                status = true;
                                doctor.OppointmentCount++;
                                return doctor;
                            }
                        }
                    }
                }
            }
            return null;
        }

        protected Doctor DoctorPresent(int Id, out bool result)
        {
            result = false;
            Doctor[] doctors = _repo.GetAll();
            for (int i = 0; i < doctors.Length; i++)
            {
                if (doctors[i] != null)
                {
                    if (doctors[i].Id == Id)
                    {
                        result = true;
                        return doctors[i];
                    }
                }

            }
            return null;
        }
        public Doctor CancelOppointment(int Id, out bool status)
        {
            Doctor doctor;
            status = false;
            for (int i = 0; i < MyOpp.Length; i++)
            {
                if (MyOpp[i] != null)
                {
                    if (MyOpp[i].Id == Id)
                    {
                        doctor = MyOpp[i];
                        MyOpp[i] = null;
                        status = true;
                        doctor.OppointmentCount--;
                        return doctor;
                    }
                }
            }
            return null;
        }

        public Doctor[] GetDoctors()
        {
            return _repo.GetAll();
        }
    }
}





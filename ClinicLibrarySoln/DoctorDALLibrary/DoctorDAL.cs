using DoctorModelLibrary;

namespace DoctorDALLibrary
{
    public class DoctorRepository : IRepo
    {
        static Doctor[] doctors;
        static int Currentlength;
        public DoctorRepository()
        {
            Currentlength = 0;
            Console.WriteLine("Enter the number of doctors that your clinic contains");
            int count;
            while (!int.TryParse(Console.ReadLine(), out count))
            {
                Console.WriteLine("Enter a valid count");
            }
            doctors = new Doctor[count];
        }
        public Doctor Add(Doctor doctor, out bool status)
        {
            status = false;
            if (Currentlength < doctors.Length)
            {
                doctors[Currentlength] = doctor;
                Currentlength++;
                status = true;
                return doctor;
            }
            bool _isEmptyPostion = false;
            int _position = -1;
            for (int i = 0; i < doctors.Length; i++)
            {
                if (doctors[i] == null)
                {
                    _isEmptyPostion = true;
                    _position = i;
                    break;
                }
            }
            if (_isEmptyPostion)
            {
                doctors[_position] = doctor;
                status = true;
                return doctor;
            }
            return null;
        }
        int GetDoctorIndex(int id)
        {
            int idx = -1;
            for (int i = 0; i < doctors.Length; i++)
            {
                if (doctors[i] != null)
                {
                    if (doctors[i].Id == id)
                    {
                        idx = i;
                        break;
                    }
                }
            }
            return idx;
        }
        public Doctor Delete(int id, out bool status)
        {
            Doctor doctor = null;
            status = false;
            int position = GetDoctorIndex(id);
            if (position >= 0)
            {
                doctor = doctors[position];
                doctors[position] = null;
                status = true;
            }
            return doctor;
        }

        public Doctor Get(int id)
        {
            Doctor doctor = null;
            int _position = GetDoctorIndex(id);
            if (_position >= 0)
                doctor = doctors[_position];
            return doctor;
        }

        public Doctor[] GetAll()
        {
            if (doctors.Length > 0)
            {
                return doctors;
            }
            return null;
        }

        public Doctor Update(Doctor doctor, out bool status)
        {
            status = false;
            int _position = GetDoctorIndex(doctor.Id);
            if (_position >= 0)
            {
                doctors[_position] = doctor;
                status = true;
                return doctor;
            }
            return null;
        }
    }
}


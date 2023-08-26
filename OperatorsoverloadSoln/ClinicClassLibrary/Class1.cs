using DoctorClassLibrary;
namespace ClinicClassLibrary
{
    public class Clinic
    {
        Doctor[] doctors;
        public string this[int index]
        {
            get { return doctors[index].speciality[index,0]; }
            set { doctors[index].speciality[index,0] = value; }
        }

        //adding splty
        public int this[int index,string splty]
        {
            get {
                for (int i = 0 ; i < doctors.Length;i++)
                    {
                    if (doctors[i].speciality[index, 0] == splty)
                        return 1;
                }
                return -1;                
            }
        }


        public Clinic()
        {
            Console.WriteLine("Welcome to our clinic!");
            Console.WriteLine("How many doctors are available?");
            int count = Convert.ToInt32(Console.ReadLine());
            doctors = new Doctor[count];
        }

        public void PrintDocDetails()
        {
            for (int i = 0; i < doctors.Length; i++)
            {
                doctors[i].PrintDoctorDetails();
            }
        }
        public void IncludeDoctor()
        {
            for (int i = 0; i < doctors.Length; i++)
            {
                doctors[i] = new Doctor();
                doctors[i].TakeDoctorDetails();
            }
        }

    }
}

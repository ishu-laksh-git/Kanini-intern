//3) Add functionality to the clinic class to add or remove specialization of a doctor. Add or remove a doctor.
//her based on their years of experience and specialization


namespace DoctorClassLibrary
{
    public class Doctor
    {
      
        public string[,] speciality = new string[5,2];
        public string this[int row]
        {
            get { return speciality[row,1]; }
            set { speciality[row,1] = value; }
        }

        //public Doctor(int spltyCount)
        //{
        //    speciality = new string[spltyCount];
        //}
        public int this[string name]
        {
            get
            {
                for (int i = 0; i < speciality.GetLength(0); i++)
                {
                    if (speciality[i,0].ToUpper() == name.ToUpper())
                    {
                        return Convert.ToInt32(speciality[i,1]);
                    }
                }
                return -1;
            }
        }
        public Doctor()
        {
            speciality = new string[5,2];
        }

        public Doctor(int specialityCount)
        {
            speciality = new string[specialityCount,0];
        }

        public Doctor(int id, string? name, int experience) : this()
        {
            Id = id;
            Name = name;
            Experience = experience;
        }

        public Doctor(int id, string? name, int experience, int spltyCount) : this(id, name, experience)
        {
            string[,] speciality = new string[spltyCount, 2];
        }

        public int Id { get; set; }

        public string? Name { get; set; }

        public int Experience { get; set; }


        public void TakeDetails()
        {
            //Console.WriteLine("Please enter the doctor's Id");
            //Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the doctor's Name");
            Name = Console.ReadLine();
            Console.WriteLine("Please enter the doctor's experience in years:");
            Experience = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many specialities do they have?");
            int splty = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < splty; i++)
            {
                    Console.WriteLine($"Please enter speaciality{i + 1} :");
                    speciality[i, 0] = Console.ReadLine();
                    Console.WriteLine($"Please enter the experience(in years) in this speciality:");
                    speciality[i, 1] = Console.ReadLine();
            }
            Console.WriteLine("-----------------------------------------------------------");
        }
        public void PrintDoctorDetails()
        {
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Doctor Details");
            Console.WriteLine($"Doctor Id : {Id}");
            Console.WriteLine($"Doctor name : {Name}");
            Console.WriteLine($"Doctor experience in years : {Experience}");
            int count = 0;
            while (speciality[count,0] != null)
            {
                Console.WriteLine($"Speciality{count + 1} : {speciality[count,0]}\nExperience:{speciality[count,1]}");
                count++;
            }
            Console.WriteLine("-----------------------------------------------------------");
        }
        public void TakeDoctorDetails()
        {
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Please enter the Doctor's Id");
            Id = Convert.ToInt32(Console.ReadLine());
            TakeDetails();
        }

        public void TakeDoctorDetails(int id)
        {
            Id = id;
            TakeDetails();
        }
        public static int operator ==(Doctor left, Doctor right)
        {

            if (left.Experience == right.Experience && left.speciality.GetLength(0) == right.speciality.GetLength(0))
                return 1;
            else
                if (left.Experience > right.Experience && left.speciality.GetLength(0) > right.speciality.GetLength(0))
                return 2;
            else
                if (left.Experience < right.Experience && left.speciality.GetLength(0) < right.speciality.GetLength(0))
                return 3;
            else
                if (left.Experience > right.Experience && left.speciality.GetLength(0) < right.speciality.GetLength(0))
                return 4;
            else
                if (left.Experience < right.Experience && left.speciality.GetLength(0) > right.speciality.GetLength(0))
                return 5;
            else
                if (left.Experience == right.Experience && left.speciality.GetLength(0) > right.speciality.GetLength(0))
                return 6;
            else
                if(left.Experience > right.Experience && left.speciality.GetLength(0) == right.speciality.GetLength(0))
                return 7;
            else
                if (left.Experience == right.Experience && left.speciality.GetLength(0) < right.speciality.GetLength(0))
                return 8;
            else
                if (left.Experience < right.Experience && left.speciality.GetLength(0) == right.speciality.GetLength(0))
                return 9;
        }
        public static int operator !=(Doctor left, Doctor right)
        {
            int result = 1;
            if (left.Experience == right.Experience && left.speciality.GetLength(0) == right.speciality.GetLength(0))
                result = 0;
            return result;
        }
    }
}
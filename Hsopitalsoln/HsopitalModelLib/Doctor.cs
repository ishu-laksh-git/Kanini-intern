namespace HsopitalModelLib
{
    public class Doctor
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public int experience { get; set; }
        public float consultationfee { get; set; }

        public void TakeDoctorDetails()
        {
            Console.WriteLine("Enter the doctor name ");
            name = Console.ReadLine();
            int Age;
            Console.WriteLine("Enter the age of the doctor ");
            while (!Int32.TryParse(Console.ReadLine(), out Age))
            {
                Console.WriteLine("Enter a valid age ");
            }
            age = Age;
            int Experience;
            Console.WriteLine("Enter the experience of the doctor ");
            while (!Int32.TryParse(Console.ReadLine(), out Experience))
            {
                Console.WriteLine("Enter a valid experience ");
            }
            experience = Experience;
            float consultationFee;
            Console.WriteLine("Enter the consultation fee of the doctor ");
            while (!float.TryParse(Console.ReadLine(), out consultationFee))
            {
                Console.WriteLine("Enter a valid consultation fee ");
            }
            consultationfee = consultationFee;
        }
        public override string ToString()
        {
            string message = "";
            message += "Doctor ID : " + id;
            message += "\nDoctor Name : " + name;
            message += "\nDoctor Age : " + age;
            message += "\nDoctor Experience : " + experience;
            message += "\nDoctor Consultation fee : " + consultationfee;
            return message;
        }
    }

}
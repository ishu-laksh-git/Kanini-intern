namespace DoctorModelLibrary
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double ConsultationFee { get; set; }
        public string[,]? Specialization { get; set; }
        public int SpecializationCount { get; set; }
        public int OppointmentCount { get; set; }


        public void TakeDoctorDetails()
        {
            Console.WriteLine("Enter the doctor ID");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Enter a valid doctor ID");
            }
            Id = id;
            Console.WriteLine("Enter the name of the doctor");
            Name = Console.ReadLine();
            if (String.IsNullOrEmpty(Name))
            {
                throw new EmptyStringException();
            }
            Console.WriteLine("Enter the Consultation fee of the doctor");
            double CF;
            while (!Double.TryParse(Console.ReadLine(), out CF))
            {
                Console.WriteLine("Enter a valid consultation fee");
            }
            if (CF < 0)
            {
                throw new MinusValueNotAcceptedException();
            }
            ConsultationFee = CF;
            int SC;
            Console.WriteLine("Enter the number of specialization that the 			doctor have");
            while (!int.TryParse(Console.ReadLine(), out SC))
            {
                Console.WriteLine("Enter a valid doctor's specialization 				count");
            }
            SpecializationCount = SC;
            if (SC <= 0)
            {
                throw new MinusValueAndZeroNotAcceptedException();
            }
            Specialization = new string[SC, 2];
            for (int i = 0; i < SpecializationCount; i++)
            {
                Console.WriteLine("Enter the specialization field of the 					doctor");
                Specialization[i, 0] = Console.ReadLine();
                Console.WriteLine("Enter the success rate for that 					specialization out of 10");
                int sr;
                if (!int.TryParse(Console.ReadLine(), out sr))
                {
                    throw new NotAnIntegerException();
                }
                if (sr < 0 || sr >= 10)
                {
                    throw new InputRangeException();
                }
                Specialization[i, 1] = sr.ToString();
            }
            OppointmentCount = 0;
        }

        public override string ToString()
        {
            string message = "";

            message += "Doctor Details";
            message += $"\nDoctor Id : {Id}";
            message += $"\nDoctor name : {Name}";
            message += $"\nConsultation Fee : Rs.{ConsultationFee}";
            message += "\nSpecialization detais of the doctors";
            for (int i = 0; i < SpecializationCount; i++)
            {
                message += "\n" + "Field Name: " + Specialization[i, 0] + "   			" + "Rating: " + Specialization[i, 1];

            }
            message += "\n****************************************";
            return message;
        }

    }
}
namespace DocApp
{
    internal class Program
    {
        Clinic clinic;
        public Program()
        {
            clinic = new Clinic();
        }
        public void ManageClinic()
        {
            clinic.IncludeDoctor();
            clinic.PrintDocDetails();
        }
        static void Main(string[] args)
        {
            //Doctor dharani = new Doctor();
            //dharani.speciality[0] = "Cardio";
            //Console.WriteLine(dharani[0]);
            // new Program().ManageClinic();
            Clinic Medplus = new Clinic();
            Medplus.IncludeDoctor();
            Medplus.PrintDocDetails();
        }
    }
}

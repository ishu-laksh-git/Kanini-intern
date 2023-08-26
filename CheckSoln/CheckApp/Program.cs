//5) Create a application that will take username and password from user.
//check if username is "ABC" and passwod is "123". 
//Print error message if username or password is wrong
//Allow user 3 attemts.
//After 3rd attempt if user enters invalid credentials then print msg to
//intimate user taht he/she has exceeded teh number of attempts and stop

namespace CheckApp
{
    internal class Program
    {
        static string UserName, Password;
        static void GetCredentials()
        {
            Console.WriteLine("Please enter the username:");
            UserName = Console.ReadLine();
            Console.WriteLine("Please enter the password:");
            Password = Console.ReadLine();
        }
        static int CheckCredentials()
        {
            if(UserName == "ABC" && Password == "123")
                return 1;
            else
                return -1;
        }
        static void Main(string[] args)
        {
            int count = 1,check;
            Console.WriteLine("Welcome!");
            while (count <= 3)
            {
                GetCredentials();
                check = CheckCredentials();
                if (check == 1)
                {
                    Console.WriteLine("Success!");
                    Environment.Exit(0);
                }
                else
                {
                    if (count < 3)
                        Console.WriteLine("Wrong!Try again...");
                    else
                        Console.WriteLine("Wrong!");
                    count++;
                    continue;
                }
            }
            Console.WriteLine("Sorry you have exceeded three attempts!Bye!");
            Environment.Exit(0);
        }
    }
}
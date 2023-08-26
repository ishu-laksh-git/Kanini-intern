using System.Numerics;
using UnderstandingOOs;

namespace UnderstandingOOApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("In th emain method");
            //Phone p1 = new Phone();
            //p1.Colour = "Black";
            //p1.PhoneCalling();
            //Console.ReadKey();
            //Cycle bsa, ladybird, hercules;
            //bsa=new Cycle(2, 12, "B.S.A");
            ////Cycle ladybird = new Cycle(2, 15, "Ladybird");
            ////Cycle hercules = new Cycle(2, 14, "Hercules");
            ////bsa.Pedal();
            ////bsa.Horn();
            ////bsa.Run();
            ////bsa.Stop();
            //ladybird = bsa;
            //hercules = ladybird;
            //bsa.Run();
            //ladybird.Run(); 
            //hercules.Run();
            MotorCycle hero=new MotorCycle();
            hero.Make = "hero honda";
            hero.NumberofWheels = 2;
            hero.Run();
            Console.ReadKey();
        }
    }
}
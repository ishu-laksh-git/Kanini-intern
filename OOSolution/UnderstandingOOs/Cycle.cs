using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingOOs
{
    internal class Cycle
    {
        public int NumberofWheels { get; set; }
        public float Speed { get; set; }
        public string Make { get; set; }

        public Cycle()
        {
            Console.WriteLine("this is cycle");
        }
        public Cycle(int numberofWheels, float speed, string make)
        {
            NumberofWheels = numberofWheels;
            Speed = speed;
            Make = make;
        }
        public void Horn()
        {
            Console.WriteLine("Tring tring");
        }
        public void Pedal()
        {
            Speed = 20;
            Console.WriteLine("Press and go.. repead");
        }
        public void Run()
        {
            Console.WriteLine(Make+" Runs in the speed of " + Speed);
        }
        public void Stop()
        {
            Console.WriteLine("kreech.... Stoped");
            Speed = 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingOverridingApp
{
    internal class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Munch munch");
        }
        public void Sleep()
        {
            Console.WriteLine("zzzzzzzzzzz");
        }
        public virtual void Move()
        {
            Console.WriteLine("Animals do go from one place to another");
        }
    }
    internal class Monkey : Animal
    {
        public override void Move()
        {
            //base.Move();
            Console.WriteLine("jump jump");
        }
        public void MonkeyMoves()
        {
            Console.WriteLine("jump jump");
        }
    }
    internal class Snake : Animal
    {
        public override void Move()
        {
            //base.Move();
            Console.WriteLine("crawls....:''''''");
        }
        public void SnakeMoves()
        {
            Console.WriteLine("jump jump");
        }
    }
    internal class Urangkottan : Monkey
    {
        public override void Move()
        {
            //base.Move();
            Console.WriteLine("Walk and jump jump");
        }
    }
}

using PizzaModelLibrary;
namespace PizzaApp
{
    internal class Program
    {
        Pizza pizza = new Pizza();
        void UnderstandingOperatorOverloading()
        {
            Pizza p1, p2, p3;
            p1 = new Pizza(345, "ABC", 101, 3);
            p2 = new Pizza(345, "ABC", 102, 2);
            p3 = p1 + p2;
            if (p1 == p2)
            {
                Console.WriteLine("They are the same pizzas. DOnt you anything new???");
            }
            else
                Console.WriteLine("Well done you know Italian ");
            p3.PrintPizzaDetails();
        }
        void UnderstandingIndexerOverloading()
        {
            Pizza p1;
            p1 = new Pizza(345, "ABC", 101, 3);
            p1[0] = "Onion";
            p1[1] = "Capsicum";
            p1[2] = "Mushroom";
            Console.WriteLine("The index of the topping Olives is " + p1["Olives"]);
            Console.WriteLine("The index of the topping Mushroom is " + p1["Mushroom"]);
        }


        private void UnderstandingErrorHandling()
        {
            Pizza pizza = new Pizza();
            pizza.TakePizzaDetails();
            pizza.PrintPizzaDetails();
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello!");
            //Pizza p1, p2, p3;
            //p1 = new Pizza(345, "ABC", 101, 3);
            //p2 = new Pizza(450.6f, "BBB", 102, 2);
            //p3 = p1 + p2;
            //p3.PrintPizzaDetails();
            //new Program().UnderstandingOperatorOverloading();
            //new Program().UnderstandingIndexerOverloading();
            //int number = 0;
            //Console.WriteLine("Pease enter a number");
            //bool parseResult = Int32.TryParse(Console.ReadLine(), out number);
            //if (parseResult)
            //    Console.WriteLine("Success. The incremented number is " + (++number));
            //else
            //    Console.WriteLine("Parselam panna mudiyadhu. po po.---Parse not possible, Get Lost");
            new Program().UnderstandingErrorHandling();
        }
    }
}
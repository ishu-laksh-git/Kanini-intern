namespace UnderstandingIndexerApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Pizza pizza = new Pizza();
            ////pizza.toppings[0] = "Olives";
            //pizza[0] = "Onions";
            //Console.WriteLine(pizza[0]);

            Store dominos = new Store();
            dominos[0] = new Pizza(234,"vegg",101,2);
            //dominos[0][0] = "Capsicum";
            //dominos.AddPizzas();
            dominos.PrintPizzas();
        }
    }
}
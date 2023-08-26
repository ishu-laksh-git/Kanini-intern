using PizzaModelLibrary;

namespace OverridingApp2
{
    internal class Program
    {
        static void CustomerBanking(ICustomerManager manager)
        {
            manager.ApproveLoan();
            manager.SolveCustomerIssues();

        }
        static void EmployeeWork(IEmployeeManager manager)
        {
            manager.ConductMeetings();
            manager.AssignWork();
        }
        static void Bankingactivity(IBanking Banking)
        {
            Banking.ApproveLoan();
            Banking.SolveCustomerIssues();
            Banking.AssignWork();
            Banking.ConductMeetings();
        }
        static void Main(string[] args)
        {
            //Pizza pizza = new Pizza(233.4f,"ABC",101);
            //Console.WriteLine(pizza);
            Manager manager = new BranchManager();
            Bankingactivity(manager);
            //Bankingactivity(manager);
            Console.WriteLine("Hello, World!");
        }
    }
}
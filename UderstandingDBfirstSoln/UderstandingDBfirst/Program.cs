using Microsoft.EntityFrameworkCore;
using System.Linq;
using UderstandingDBfirst.Models;

namespace UderstandingDBfirst
{
    internal class Program
    {
        pubsContext context = new pubsContext();
        void GetPublishers()
        {
            //var publishers = context.Publishers.Where(p => p.Country == "USA");
            var publishers = (from p in context.Publishers where p.Country == "USA" select p).ToList();
            foreach (var publisher in publishers)
            {
                Console.WriteLine(publisher.PubName);
            }
        }
        void CountLINQ()
        {
            var publishersCount = context.Publishers.Where(p => p.Country == "USA").Count();
            Console.WriteLine(publishersCount);
        }
        void OrderData()
        {

            //var publishers = context.Publishers.OrderBy(pub => pub.Country);
            var publishers = context.Publishers.OrderByDescending(pub => pub.Country);
            foreach (var publisher in publishers)
            {
                Console.WriteLine(publisher.PubName + " " + publisher.Country);
            }
        }
        void GroupByCheck()
        {
            var publishers = context.Publishers.ToList();
            var pubs = publishers.GroupBy(p => p.Country);

            foreach (var item in pubs)
            {
                Console.WriteLine(item.Key);
                foreach (var data in item)
                {
                    Console.WriteLine("\t" + data.PubName);
                }
            }
        }
        void JoinExample()
        {
            List<Product> products = new List<Product>
            {
            new Product { Name = "Cola", CategoryId = 0 },
            new Product { Name = "Tea", CategoryId = 0 },
            new Product { Name = "Apple", CategoryId = 1 },
            new Product { Name = "Kiwi", CategoryId = 1 },
            new Product { Name = "Carrot", CategoryId = 2 },
            };

            List<Category> categories = new List<Category>
            {
            new Category { Id = 0, CategoryName = "Beverage" },
            new Category { Id = 1, CategoryName = "Fruit" },
            new Category { Id = 2, CategoryName = "Vegetable" }
            };
            //var query = from product in products
            //            join category in categories on product.CategoryId equals category.Id
            //            select new { ProductName = product.Name, category.CategoryName };
            var query = products.Join(categories,
                (p) => p.CategoryId,
                (c) => c.Id,
                (p, c) => new { ProductName = p.Name, CategoryName = c.CategoryName });

            foreach (var item in query)
            {
                Console.WriteLine($"{item.ProductName} - {item.CategoryName}");
            }
        }
        void UnderstandingInclude()
        {
            var publishers = context.Publishers.Include(p => p.Titles);
            foreach (var publisher in publishers)
            {
                Console.WriteLine(publisher.PubName);
                foreach (var title in publisher.Titles)
                {
                    Console.WriteLine("\t" + title.Title1);
                }
            }
        }

        void question1()
        {
            Console.WriteLine("Enter the publisher's name:");
            var pname = Console.ReadLine();
            //titles and publishers using pub_id
            var publishers = context.Publishers.Include(p => p.Titles);
            foreach(var publisher in publishers)
            {
                if (publisher.PubName == pname)
                {
                    Console.WriteLine(publisher.PubName);
                    foreach (var title in publisher.Titles)
                    {
                        Console.WriteLine("\t" + title.Title1);
                    }
                }
            }
        }

        void question2()
        {
            Console.WriteLine("Enter the author's id:");
            var id = Console.ReadLine();
            var details = context.Authors.Where(p => p.AuId == id);
            foreach (var publisher in details)
            {
                Console.WriteLine("Id:"+publisher.AuId+"\nFirst name:"+publisher.AuFname+"\nlast Name:"+publisher.AuLname+"\nPhone:"+publisher.Phone
                                  +"\nAddress:"+publisher.Address + "\nCity:" +publisher.City + "\nZip:" +publisher.Zip + "\nContract:" +
                                  publisher.Contract);
            }
        }

        void question3()
        {
            Console.WriteLine("Enter the title name:");
            var tname = Console.ReadLine();
            var salesd = (from t in context.Titles
                          join s in context.Sales
                        on t.TitleId equals s.TitleId
                          select new
                          {
                              t.Title1,
                              s.StorId,
                              s.OrdNum,
                              s.OrdDate,
                              s.Qty,
                              s.Payterms,
                              s.TitleId,  
                              t.Price
                          });
            foreach(var s in salesd)
            {
                if(s.Title1 == tname)
                {
                    Console.WriteLine("Title: " + s.Title1 + "\nStore id: " + s.StorId + "\nOrder number: " + s.OrdNum + "\nOrder Date:" +
                                      s.OrdDate + "\nQuantity: " + s.Qty + "\nPayterms: " + s.Payterms + "\nTotal Sales: " + s.Qty * s.Price);
                }
            }


        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.question3();
            
        }
    }

    class Product
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
    }

    class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
    }
}

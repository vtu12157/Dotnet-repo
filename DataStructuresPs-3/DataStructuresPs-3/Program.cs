using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPs_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            //Console.WriteLine("Enter your option");
            ////var option = Convert.ToInt32(Console.ReadLine());
            //var product = new Product()
            //{
            //    Name = "watch",
            //    Description = "blue watch",
            //    id = 76
            //};
            //var product2 = new Product()
            //{
            //    Name = "laptop",
            //    Description = "gaming laptop",
            //    id = 86
            //};

            //var product3 = new Product()
            //{
            //    Name = "phone",
            //    Description = "apple iphone",
            //    id = 33
            //};
            //list.Add(product);
            //list.Add(product2);
            //list.Add(product3);


            for (int i = 0; i < 2; i++)
            {
                var p = new Product();
                Console.WriteLine("ID");
                p.id = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Name");
                p.Name = Console.ReadLine();

                Console.WriteLine("Description");
                p.Description = Console.ReadLine();

                list.Add(p);

            }

            Console.WriteLine("Enter ID to be deleted");

            int deleteID = Convert.ToInt32(Console.ReadLine());

            list.Remove(list.First( x => x.id == deleteID));

            Console.WriteLine("Deleted");
            Console.ReadLine();

        }
    }
}

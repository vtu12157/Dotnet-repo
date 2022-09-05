using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRLibrary;
using HRLib;

namespace OOPSConcept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Category c = new Category();

            c.CatId = 10;
            c.CatName = "Fanta";
            c.Description = "Liquid";

            Category c1 = new Category();
            c1.Addcategory();

            List<Category> l1 = new List<Category>();
            l1.Add(c);
            l1.Add(c1);

            Product p1 = new Product();
            p1.ProId = 15;
            p1.ProName = "EnergyDrink";
            p1.UnitPrice = 200;
            p1.QtySold = 150;
            p1.UnitOfMeasurement = "liter";
            p1.QtyInHand = 4;
            p1.RecorderLevel = 8;

            Product p2 = new Product();
            p2.ProId = 20;
            p2.ProName = "Waterbottles";
            p2.UnitPrice = 25;
            p2.QtySold = 30;
            p2.UnitOfMeasurement = "liter";
            p2.QtyInHand = 200;
            p2.RecorderLevel = 50;

            Product p3 = new Product();
            p3.Addproduct();


            List<Product> list = new List<Product>();
            list.Add(p1);
            list.Add(p2);
            list.Add(p3);

            foreach (var item in l1)
            {

                Console.WriteLine("----Category Details----");
                Console.WriteLine("Category ID=" + item.CatId);
                Console.WriteLine("Category Name=" + item.CatName);
                Console.WriteLine("Description=" + item.Description);

            }

            Console.WriteLine("==================================================================");


            foreach (var item in list)
            {
                Console.WriteLine("----------Product Details------------");
                Console.WriteLine("Product ID=" + item.ProId);
                Console.WriteLine("Product Name=" + item.ProName);
                Console.WriteLine("Unit Price=" + item.UnitPrice);
                Console.WriteLine("Quantity Sold=" + item.QtySold);
                Console.WriteLine("Unit Of Measurement=" + item.UnitOfMeasurement);
                Console.WriteLine("Quantity in Hand=" + item.QtyInHand);
                Console.WriteLine("RecorderLevel=" + item.RecorderLevel);

            }

            Console.WriteLine("==Count==");
            c.Addcount();

            Console.ReadLine();
        }
    }
}




        
    


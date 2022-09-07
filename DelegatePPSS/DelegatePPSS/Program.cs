using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePPSS
{
    public delegate void delegatepointer(int pid,string pname);
    public class product
    {
        public int productid { get; set; }
        public string productname { get; set; }
        static void Main(string[] args)
        {
            delegatepointer del1 = new delegatepointer(Prodclass);
            product p = new product();
            p.productid=1;
            p.productname = "bike";
            del1(125, "car");
        }

        public static void Prodclass(int id,string name)
        {
            Console.WriteLine("id is {0} and product is {1}",id,name);

            Console.ReadLine();
        }
    }
}

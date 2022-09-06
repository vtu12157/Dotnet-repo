using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library1;
using Library2;
namespace InheritenceAndPolymorphism
{
     public class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book(12,"tony",54,"Stanlee");
            //book1.Bookid = 119;
            //book1.Bookname = "ShawshankRedemption";
            //book1.Bookprice = 150;
            //book1.Author = "StanLee";



            //book1.Bookid;
            //book1.Bookname;
            //book1.Bookprice;
            //book1.Author;



            Console.WriteLine("Bid : {0},\nBname: {1},\nBprice : {2},\nBAuthor:{3}", book1.Bookid, book1.Bookname, book1.Bookprice, book1.Author);

            BookCategory bc1 = new BookCategory(15,"horror", "Tale of Different heroes");

            bc1.catid = 15;
            bc1.catname = "Horror";
            bc1.Description = "Tale of Different heroes";

            Console.WriteLine("catid: {0},\ncatname:{1},\nDescription:{2}", bc1.catid,bc1.catname,bc1.Description);




            Console.ReadLine();





        }
    }
}

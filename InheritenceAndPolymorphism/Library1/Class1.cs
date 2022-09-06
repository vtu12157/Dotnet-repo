using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Library1.Book;

namespace Library1
{
    public class Book
    {
        public int Bookid { get; set; }
        public string Bookname { get; set; }
        public int Bookprice { get; set; }

        public string Author { get; set; }

        public int numberofpages { get; set; }

       public void InsertData(int bid, string bname, int bprice)
        {
            this.Bookid = bid;
            this.Bookname = bname;
            this.Bookprice = bprice;
        }

        public void InsertData1(int bid1, string bname1)
        {
            this.Bookid = bid1;
            this.Bookname = bname1;
        }

       
        //public int IdofBook
        //{
        //    set { Bookid = value; }
        //    get { return Bookid; }
        //}

        //public string NameofBook
        //{
        //    set { Bookname = value; }
        //    get { return Bookname; }
        //}

        //public int PriceofBook
        //{
        //    set { PriceofBook = value; }
        //    get { return PriceofBook; }
        //}

        //public string AuthorofBook
        //{
        //    set { Author = value; }
        //    get { return Author;  }
        //}

        public Book()
        {
            Bookid = 10;
            Bookname = "Evolution of hulk";
            Bookprice = 5000;
            Author = "TonyStark";
        }
        public Book(int _Bookid, string _Bookname, int _Bookprice, string _Author)
        {
          
            Bookid = _Bookid;
            Bookname = _Bookname;
            Bookprice = _Bookprice;
            Author = _Author;
        }

        public void Insertbook(int bbid, string bbname, int bbprice)
        {
            this.Bookid = bbid;
            this.Bookname = bbname;
            this.Bookprice = bbprice;
            

        }

        public void Insertbook(int bbid, string bbname)
        {
            this.Bookid = bbid;
            this.Bookname = bbname;
           

        }

        public class Novel : Book
        {
            public void insertBook(int bbid, string bbname, int bbprice, int numberofpages)
            {
                this.Bookid=bbid;
                this.Bookname=bbname;
                this.Bookprice=bbprice;
                this.numberofpages=numberofpages;
            }
           

        }

         public class cart : Book
        {
            private int _customerid;

            public int CustomerId
            {
                get { return _customerid; }
                set { _customerid = value; }
            }

            private string _bookingid;

            public string BookingId
            {
                get { return _bookingid; }
                set { _bookingid = value; }
            }
            private List<cart> _booklist;

            public List<cart> ListofCart
            {
                get { return _booklist; }
                set { _booklist = value; }
            }

            public void Addbook(int bbid, string bbname, int bbprice, int numberofpages)
            {
                this.Bookid= bbid;
                this.Bookname= bbname;
                this.Bookprice= bbprice;
                this.numberofpages= numberofpages;
            }

            static int bookcount = 0;
            public void Addcount()

            {
                bookcount += 1;
                Console.WriteLine("You added {0} books ", bookcount);
            }

            public void Displaydetails()
            {
                Console.WriteLine("books added to cart");
                Console.WriteLine("details of added books");

                foreach(var item in ListofCart)
                {
                    Console.WriteLine("id of book"+item.Bookid);
                    Console.WriteLine("name of book"+item.Bookname);
                    Console.WriteLine("price of book"+item.Bookprice);
                    Console.WriteLine("author of book"+item.Author);
                    Console.WriteLine("no of pgs"+item.numberofpages);
                }
            }
        }



    }
}

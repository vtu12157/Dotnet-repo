using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library2
{
    public class BookCategory
    {
        public int catid { get; set; }
        public string catname { get; set; }

        public string Description { get; set; }

        public BookCategory()
        {
            catid = 169;
            catname = "Horror";
            Description = "Tale of Different heroes";
        }

        public BookCategory(int _catid,string _catname, string _Description)
        {
            catid = _catid;
            catname = _catname;
            Description = _Description;
        }
    }
   
}

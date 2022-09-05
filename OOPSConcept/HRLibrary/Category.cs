using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    public class Category
    {
        private int _catid;

        public int CatId
        {
            get { return _catid; }
            set { _catid = value; }
        }

        private string _catname;

        public string CatName
        {
            get { return _catname; }
            set { _catname = value; }
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }


        static int Pcnt = 0;
        public void Addcount()
        {
            Pcnt = 1;
            Console.WriteLine("added product=" + Pcnt);
        }

        public void Addcategory()
        {
            _catid = 20;
            _catname = "Beverages";
            _description = "Diff types of drinks";

        }

    }
}

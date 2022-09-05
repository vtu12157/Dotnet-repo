using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    public class Product
    {
        private int _proid;

        public int ProId
        {
            get { return _proid; }
            set { _proid = value; }
        }

        private string _proname;

        public string ProName
        {
            get { return _proname; }
            set { _proname = value; }
        }

        private int _qtysold;

        public int QtySold
        {
            get { return _qtysold; }
            set { _qtysold = value; }
        }

        private int _unitprice;

        public int UnitPrice
        {
            get { return _unitprice; }
            set { _unitprice = value; }
        }

        private string _unitofmeasurement;

        public string UnitOfMeasurement
        {
            get { return _unitofmeasurement; }
            set { _unitofmeasurement = value; }
        }

        private int _qtyinhand;

        public int QtyInHand
        {
            get { return _qtyinhand; }
            set { _qtyinhand = value; }
        }

        private int _recorderlevel;

        public int RecorderLevel
        {
            get { return _recorderlevel; }
            set { _recorderlevel = value; }
        }



        private List<Product> listcat;

        public List<Product> Listcat
        {
            get { return listcat; }
            set { listcat = value; }
        }

        public void Addproduct()
        {
            _proid = 30;
            _proname = "Thumsup";
            _qtysold = 100;
            _unitprice = 35;
            _unitofmeasurement = "litre";
            _qtyinhand = 150;
            _recorderlevel = 50;




        }






    }
}

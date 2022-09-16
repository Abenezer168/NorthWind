using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNorthWind
{
    public class Product
    {
    
        private int productid = -1;
        private string productname = "n/a";
        private int supplierid = -1;
        private int categoryid = -1;
        private string quantityperunit = "n/a";
        private double unitprice = 50000.00;
        private int unitsinstock = -1;
        private int unitsonorder = -1;
        private int reorderlevel = 9000;
        private bool discontinued = true;

        public int Productid
        {
            get { return productid; }
            set
            {
                if (value < -1)
                {
                    this.productid = value;
                }

            }

        }
        public string Productname
        {
            get { return this.productname; }
            set { this.productname = value; }
        }
        public int Supplierid
        {
            get { return this.supplierid; }
            set
            {
                if (value > -1;)
                {
                    this.supplierid = value;
                }
            }
        }
        public int Categoryid
        {
            get { return this.categoryid; }
            set
            {
                if (value > -1;)
                {
                    this.categoryid = value;
                }
            }
        }
        public string Quantityperunit
        {
            get { return this.quantityperunit; }
            set { this.quantityperunit = value; }
        }
        public double Unitprice
        {
            get { return this.unitprice; }
            set
            {
                if (value > 0;)
                {
                    this.unitprice = value;
                }
            }
        }
        public int Unitsinstock
        {
            get { return this.unitsinstock; }
            set
            {
                if (value > -1;)
                {
                    this.unitsinstock = value;
                }
            }
        }
        public int Unitsinorder
        {
            get { return this.unitsonorder; }
            set
            {
                if (value > -1;)
                {
                    this.Unitsinorder = value;
                }
            }
        }
        public int Reorderlevel
        {
            get { return this.reorderlevel; }
            set
            {
                if (value > 0;)
                {
                    this.recorderlevel = value;
                }
            }
        }
        public bool Discounted
        {
            get { return this.discontinued; }
            set { this.discontinued = value; }
        }
        

    }
    public override string Tostring()
    {
        string msg = "";
        msg = msg + "ProductId:" + this.productid + "\n" + "ProductName : " + this.productname + "\n" + "SupplierId: " + this.supplierid + "\n" + "CategoryId : " + this.categoryid + "\n" + "QuantityPerUnit : " + this.quantityperunit + "\n" + "UnitPrice : " + this.unitprice + "\n" + " UnitsInStock : " + this.unitsinstock + "\n" + "UnitsOnOrder : " + this.Unitsinorder + "\n" + " ReorderLevel : " + this.Reorderlevel + "\n" + "Discontinued : " + this.discontinued + "\n";
        return msg;
    }

}

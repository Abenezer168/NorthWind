using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind
{
    public class OrderDetail
    {
        private int orderid = -1;
        private int productid = -1;
        private double unitprice = 0.00;
        private int quantity = 0;
        private double discount = 0;

        public int OrderId
        {
            get { return this.orderid; }
            set
            {
                if (value > -1)
                {
                    this.orderid = value
                }
                else
                {
                    this.orderid = "*"
                }

            }
        }
        public int Productid
        {
            get { return this.productid; }
            set
            {
                if (value > -1;)
                {
                    this.productid = -1;
                }
                else
                {
                    this.productid = *;
                }

            }
        }
        public double Unitprice
        {
            get { return this.unitprice; }
            set
            {
                if (value > 0.00;)
                {
                    this.unitprice = 0.00
                }
                else
                {
                    this.unitprice = "*"
                }
            }
        }
        public int Quantity
        {
            get { return this.quantity; }
            set
            {
                if (value > 0;)
                {
                    this.Quantity = 0
                }
                else
                {
                    this.quantity = "*"
                }

            }
        }
        public double Discount
        {
            get { return this.discount; }
            set
            {
                if (value > 0;)
                {
                    this.discount = 0
                }
                else
                {
                    this.discount = "*"
                }
            }

        }

        



    }
    public override string Tostring()
    {
        string msg = "";
        msg = msg + "OrderId:" + this.orderid + "\n" + "productId : " + this.Productid + "\n" + "UnitPrice : " + this.Unitprice + "\n" + "Qunatity : " + this.Quantity + "\n" + " Discount : " + this.Discount + "\n";
        return msg;
    }
}
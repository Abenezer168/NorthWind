using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind
{
    public class Order
    {
        private int orderid = -1;
        private string customerid = "n/a";
        private int employeeid = -1;
        private string orderdate = "n/a";
        private string requireddate = "n/a";
        private string shipeddate = "n/a";
        private int shipvia = -1;
        private double freight = 0.00;
        private string shipname = "n/a";
        private string shipaddress = "n/a";
        private string shipcity = "n/a";
        private string shipregion = "n/a";
        private string shippostalcode = "n/a";
        private string shipcountry = "n/a";

        public int Orderid
        {
            get { return this.orderid; }
            set
            {
                if (value > -1;)
                {
                    this.orderid = value
                }
                else
                {
                    this.orderid = "*";
                }
            }
        }
        public string Customerid
        {
            get { return this.customerid; }
            set { this.customerid = value; }
        }

        public int Employeeid
        {
            get { return this.employeeid; }
            set
            {
                if (value > -1)
                {
                    this.employeeid = value
                }
                else
                {
                    this.employeeid = "*"
                }
            }
        }
        public string Orderdate
        {
            get { return this.orderdate; }
            set { this.orderdate = value; }
        }
        public string Requireddate
        {
            get { return this.requireddate; }
            set { this.requireddate = value; }
        }
        public string Shipeddate
        {
            get { return this.Shipeddate; }
            set { this.Shipeddate = value; }
        }
        public int Shipvia
        {
            get { return this.shipvia; }
            set
            {
                if (value > -1;)
                {
                    this.Shipvia = value
                }
                else
                {
                    this.shipvia = "*"
                }
            }
        }
        public double Freight
        {
            get { return this.freight; }
            set
            {
                if (value < -1;)
                {
                    this.freight = value
                }
                else
                {
                    this.freight = "*"
                }
            }
        }
        public string Shipname
        {
            get { return this.shipname; }
            set { this.shipname = value; }
        }
        public string Shipaddress
        {
            get { return this.shipaddress; }
            set { this.shipaddress = value; }
        }
        public string ShipCity
        {
            get { return this.shipcity; }
            set { this.shipcity = value; }
        }
        public string ShipRegion
        {
            get { return this.shipregion; }
            set { this.shipregion = value; }
        }
        public string ShipAddress
        {
            get { return this.shipaddress; }
            set { this.shipaddress = value; }
        }
        public string Shipcity
        {
            get { return this.shipcity; }
            set { this.shipcity = value; }
        }
        public string ShipReigon
        {
            get { return this.ShipReigon; }
            set { this.ShipReigon = value; }
        }
        public string ShipPostalcode
        {
            get { return this.shippostalcode; }
            set { this.shippostalcode = value; }
        }
        public string Shipcountry
        {
            get { return this.shipcountry; }
            set { this.shipcountry = value; }
        }


    }
    public override string Tostring()
    {
        string msg = "";
        msg = msg + "Orderid:" + this.Orderid + "\n" + "Customerid : " + this.Customerid + "\n" + "EmployeeId: " + this.Employeeid + "\n" + "OrderDate : " + this.Orderdate + "\n" + "Requireddate : " + this.Requireddate + "\n" + "Shipeddate : " + this.Shipeddate + "\n" + " ShipVia : " + this.Shipvia + "\n" + "Freight : " + this.Freight + "\n" + " ShipName : " + this.Shipname + "\n" + "ShipAddress : " + this.Shipaddress + "\n" + "ShipCity : " + this.Shipcity + "\n" + "Shipregion : " + this.ShipRegion + "\n" + "ShipPostalCode : " + this.shippostalcode + "\n" + "ShipCountry : " + this.Shipcountry + "\n";
        return msg;
    }
}

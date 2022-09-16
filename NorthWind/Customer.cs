using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNorthWind
{


    public class Customer
    {
        private string customerID = "*";
        private string customerName = "n/a";
        private string companyname = "n/a";
        private string contactName = "n/a";
        private string contactId = "n/a";
        private string contactTitle = "n/a";
        private string address = "n/a";
        private string city = "n/a";
        private string region = "n/a";
        private string postalcode = "n/a";
        private string country = "n/a";
        private string phone = "n/a";
        private string fax = "n/a";

        public string CustomerID
        {
            get { return this.customerID; }
            set
            {
                if (value != null)
                {
                    this.customerID = value;

                }
                else
                {
                    this.customerID = "*";

                }
            }
        }
        public string CustomerName
        {
            get { return this.customerName; }
            set { this.customerName = value; }
        }
        public string CompanyName
        {
            get { return this.companyname; }
            set { this.companyname = value; }
        }
        public string ContactID
        {
            get { return this.contactId; }
            set { this.contactId = value; }
        }
        public string Contacttitle
        {
            get { return this.contactTitle; }
            set { this.contactTitle = value; }
        }
        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }
        public string City
        {
            get { return this.City; }
            set { this.city = value; }
        }
        public string Reigon
        {
            get { return this.region; }
            set { this.region = value; }
        }
        public string Postalcode
        {
            get { return this.postalcode; }
            set { this.postalcode = value; }
        }
        public string Phone
        {
            get { return this.phone; }
            set { return this.phone = value; }
        }
        public string Fax
        {
            get { return this.fax; }
            set { this.fax = value; }
        }


    }
    public override string Tostring()
    {
        string msg = "";
        msg = msg + "customerID:" + this.customerID + "\n" + "companyName : " + this.companyname + "\n" + "contactName: " + this.contactName + "\n" + "contactTitle : " + this.contactTitle + "\n" + "Address : " + this.Address + "\n" + "city : " + this.city + "\n" + "region : " + this.region + "\n" + "postalcode : " + postalcode + "\n" + " country : " + this.country + "\n" + "phone : " + this.phone + "\n" + "fax : " + this.fax + "\n";
        return msg;
    }



}

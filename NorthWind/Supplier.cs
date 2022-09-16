﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNorthWind
{
    public class Supplier
    {
        private int supplierId = -1;
        private string companyName = "n/a";
        private string contactName = "n/a";
        private string contactTitle = "n/a";
        private string address = "n/a";
        private string city = "n/a";
        private string region = "n/a";
        private string postalCode = "n/a";
        private string country = "n/a";
        private string phone = "n/a";
        private string fax = "n/a";
        private string homePage = "n/a";

        public int SupplierId
        {
            get { return this.supplierId; }
            set
            {
                if (value > -1)
                {
                    this.supplierId = value;
                }
                else
                {
                    this.supplierId = -1;
                }
            }
        }

        public string CompanyName
        {
            get { return this.companyName; }
            set { this.companyName = value; }
        }

        public string ContactName
        {
            get { return this.contactName; }
            set { this.contactName = value; }
        }

        public string ContactTitle
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
            get { return this.city; }
            set { this.city = value; }
        }

        public string Region
        {
            get { return this.region; }
            set { this.region = value; }
        }

        public string PostalCode
        {
            get { return this.postalCode; }
            set { this.postalCode = value; }
        }

        public string Country
        {
            get { return this.country; }
            set { this.country = value; }
        }

        public string Phone
        {
            get { return this.phone; }
            set { this.phone = value; }
        }

        public string Fax
        {
            get { return this.fax; }
            set { this.fax = value; }
        }

        public string HomePage
        {
            get { return this.homePage; }
            set { this.homePage = value; }
        }
    }
    public override string Tostring()
    {
        string msg = "";
        msg = msg + "SupplierId:" + this.supplierId + "\n" + "CompanyName : " + this.companyName + "\n" + "ContactName: " + this.ContactName + "\n" + "ContactTitle : " + this.contactTitle + "\n" + "Address : " + this.Address + "\n" + "City : " + this.City + "\n" + " Region : " + this.Region + "\n" + "PostalCode : " + this.PostalCode + "\n" + " Country : " + this.Country + "\n" + "Phone: " + this.Phone + "\n" + "Fax : " + this.Fax + "\n" + "HomePage: " + this.HomePage;
        return msg;
    }

}

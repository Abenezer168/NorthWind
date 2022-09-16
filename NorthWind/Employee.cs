using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNorthWind
{
    public class Employee
    {
        private int employeeId = -1;
        private string lastname = "n/a";
        private string firstname ="n/a";
        private string title = "n/a";
        private string titleofcourtesy = "n/a";
        private string birthdate = "n/a";
        private string hiredate = "n/a";
        private string address = "n/a";
        private string city = "n/a";
        private string region = "n/a";
        private string postalcode = "n/a";
        private string country = "n/a";
        private string homephone = "n/a";
        private string extension = "n/a";
        private string notes = "n/a";
        private int reportsTo = -1;

        public int EmployeeId
        {
            get { return this.employeeId; }
            set
            {
                if (value > -1)
                {
                    this.employeeId = value;
                }
                else
                {
                    this.employeeId = 0;
                }



            }

        }
        public string Lastname
        {
            get { return this.lastname; }
            set { this.lastname = value; }
        }
        public string Firstname
        {
            get { return this.firstname; }
            set { this.firstname = value; }

        }
        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }
        public string Titleofcourtesy
        {
            get { return this.titleofcourtesy; }
            set { this.titleofcourtesy = value; }
        }
        public string Birthdate
        {
            get { return this.birthdate; }
            set { this.birthdate = value; }
        }
        public string Hiredate
        {
            get { return this.hiredate; }
            set { this.hiredate = value; }
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
        public string Homephone
        {
            get { return this.homephone; }
            set { this.homephone = value; }
        }
        public string Extension
        {
            get { return this.extension; }
            set { this.extension = value; }
        }
        public string Notes
        {
            get { return this.notes; }
            set { this.notes = value; }
        }
        public int ReportsTo
        {
            get { return this.reportsTo; }
            set
            {
                if (value > -1)
                {
                    this.reportsTo = value;
                }
                else
                {
                    this.reportsTo = 0;
                }
            }
        }
        

    }
    public override string Tostring()
    {
        string msg = "";
        msg = msg + "EmployeeID:" + this.EmployeeId + "\n" + "LastName : " + this.Lastname + "\n" + "FirstName: " + this.Firstname + "\n" + "Title : " + this.Title + "\n" + "TitleOfCourtesy : " + this.Titleofcourtesy + "\n" + "Birthdate : " + this.Birthdate + "\n" + " HireDate : " + this.Hiredate + "\n" + "Address : " + this.Address + "\n" + " city : " + this.city + "\n" + "Region : " + this.region + "\n" + "PostalCode : " + this.postalcode + "\n" + "Country : " + this.country + "\n" + "HomePhone : " + this.homephone + "\n" + "Extension : " + this.extension + "\n" + "Notes : " + this.notes + "\n" + "ReportsTo : " + this.reportsTo + "\n";
        return msg;
    }




}

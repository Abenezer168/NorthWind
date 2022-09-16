using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNorthWind
{
    public class shipper
    {
        private int shiperid = -1;
        private string companyname = "n/a";
        private string phone = "n/a";

        public string Shiperid
        {
            get { return this.shiperid}
            set
            {
                if (value > -1;)
                {
                    this.shiperid = value;
                }
            }
        }
        public string Companyname
        {
            get { return this.companyname; }
            set { this.companyname = value; }
        }
        public string Phone
        {
            get { return this.phone; }
            set { this.phone = value; }
        }

    }
    public override string Tostring()
    {
        string msg = "";
        msg = msg + "ShipperId:" + this.ShipperId + "\n" + "companyName: " + this.companyName + "\n" + "phone: " + this.phone + "\n";
        return msg;
    }
}

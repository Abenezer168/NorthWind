using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind
{
    public class category
    {
        private int categoryId = -1;
        private string categoryName = "n/a";
        private string description = "n/a";

        public int CategoryId
        {
            get { return this.categoryId; }
            set
            {
                //must be greater than -1
                if (value > -1)
                {
                    this.categoryId = value;
                }
                else
                {
                    this.categoryId = 0;
                }

            }
        }
        public string CategoryName
        {
            get { return this.categoryName; }
            set { this.categoryName = value; }
        }
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }
        public override string Tostring()
        {
            string msg = "";
            msg = msg + "CategoryId:" + this.categoryId + "\n";
            msg = msg + "categoryName: " + this.CategoryName + "\n" 
            msg =msg +  "Description: " + this.Description + "\n";
            return msg;
        }
    }

}

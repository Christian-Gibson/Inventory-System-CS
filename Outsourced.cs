using System;
using System.Collections.Generic;
using System.Text;

namespace InventorySystem
{
    class Outsourced : Part
    {

        private string companyName;


        public Outsourced ()
        {



            this.PartID = partID++;


        }

        public Outsourced(string name, int inStock, int price, int max, int min, string companyName)
        {


            this.Name = name;
            this.InStock = inStock;
            this.Price = price;
            this.Max = max;
            this.Min = min;
            this.CompanyName = companyName;




            this.PartID = ++partID; //Increment the static variable partID (in abstract  ---- Part.cs)






        }




        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }


        

    }
}

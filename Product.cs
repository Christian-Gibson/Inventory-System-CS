using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;

namespace InventorySystem
{
    class Product
    {

        public BindingList<Part> associatedParts = new BindingList<Part>();

        public DataGridView productPartView = new DataGridView();

        

        static private int productID = 0;

        private string name;

        private decimal price;

        private int inStock;

        private int max;

        private int min;
    



        public Product()
        {


            this.ProductID = ++productID;
        }

        public Product (string name, decimal price, int inStock, int max, int min)
        {


            this.ProductID = productID++;
            this.Name = name;
            this.Price = price;
            this.InStock = inStock;
            this.Max = max;
            this.Min = min;



        }




        
       public BindingList<Part> AssociatedParts {

            get {return associatedParts;}
            set { associatedParts = value;} 

        }

        public int ProductID { get; set; }
        
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int InStock { get; set; }

        public int Max { get; set; }

        public int Min { get; set; }




        public void addAssociatedPart(Part partToAdd)
        {


            this.AssociatedParts.Add(partToAdd);

        }

        public bool removeAssociatedPart (int numToRemove)
        {

            foreach(Part part in AssociatedParts)
            {

                if (part.PartID == numToRemove)
                {
                    
                    return true;



                }



            }
            return true;

           


        }

        

       static public Part lookupAssociatedPart (int numToLookup)
        {



            foreach(Product product in Inventory.Products)
            {


                foreach (Part part in product.AssociatedParts)
                {


                    if (part.PartID==numToLookup)
                    {

                        return part;



                    }





                }





            }


            InHouse dummypart = new InHouse();
            return dummypart;



        }


        



    }
}

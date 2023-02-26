using System;
using System.Collections.Generic;
using System.Text;

namespace InventorySystem
{
    public abstract class Part
    {


        static public int partID = 100;

        private int name;

        private decimal price;

        private int inStock;


        private int min;

        private int max;

       








         public int PartID
        {
            get;
            set;
        }
         
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int InStock { get; set; }


        public int Min { get; set; }

        public int Max { get; set; }

       









    }





}

using System;
using System.Collections.Generic;
using System.Text;

namespace InventorySystem
{
    class InHouse : Part
    {

        private int machineID;

        public InHouse()
        {


            this.PartID = partID++;


        }

        public InHouse(string name, int inStock, int price, int max, int min, int machineID)
        {

            
            this.Name = name;
            this.InStock = inStock;
            this.Price = price;
            this.Max = max;
            this.Min = min;
            this.MachineID = machineID;




            this.PartID = ++partID; //Increment the static variable partID (in abstract Part.cs)


           



        }
      

        public void Increment()
        {


            // Testing



        }


        public int MachineID
        {
            get { return machineID; }
            set { machineID = value; }
        }
        






        


    }

}

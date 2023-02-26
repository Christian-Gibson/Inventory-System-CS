using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;

namespace InventorySystem
{
    class Inventory
    {

        

        public static BindingList<Product> products = new BindingList<Product>();
       public static BindingList<Part> allParts = new BindingList<Part>();
        public static InHouse inHouseCompare = new InHouse();
        public static Outsourced outsourcedCompare = new Outsourced();
        public static Outsourced dummyPart;
        static public InHouse inHouse = new InHouse(); //
        static public Outsourced outSourced = new Outsourced(); //
        public static BindingList<Part> transferParts;

        //
        public static BindingList<Part> TransferParts
        {
            get; set;


        }


        public static BindingList<Product> Products
        {

            get { return products; }
            set { products = value; }


        }

        public static BindingList<Part> AllParts
        {

            get { return allParts; }
            set { allParts = value; }



        }





       static public void addProduct(Product prodToAdd) {


            Products.Add(prodToAdd);
        
        
        
        }

       static public bool removeProduct (int numToRemove )
        {

            foreach(Product product in Products)
            {

                if(numToRemove == product.ProductID)
                {


                    bool hasPart = product.AssociatedParts.Count != 0 ? true : false;
                    
                    if (hasPart == false)
                    {

                        Products.Remove(product);
                        return true;


                    }
                    else
                    {


                        MessageBox.Show("Can't remove product with associated parts!", "Product Delete Failure");
                        return false;

                    }




                }






            }

            return true;


        }

       static public Product lookUpProduct(int numToLookup)
        {

            Product myProd = new Product();

            foreach (Product product in Products)
            {

                if (numToLookup == product.ProductID)
                {

                    return product;


                }






            }

            return myProd;


        }

        static public void updateProduct (int numToUpdate, Product prodToUpdate)
        {

            foreach(Product product in Products)
            {

                if (product.ProductID == numToUpdate)
                {

                    product.Name = prodToUpdate.Name;
                    product.InStock = prodToUpdate.InStock;
                    product.Price = prodToUpdate.Price;
                    product.Min = prodToUpdate.Min;
                    product.Max = prodToUpdate.Max;
                    product.AssociatedParts = prodToUpdate.AssociatedParts;




                }




            }




        }


        public static void addPart(Part partToAdd)
        {


            if (partToAdd is InHouse) { 


            allParts.Add((InHouse)partToAdd);



            }
            else if(partToAdd is Outsourced)
            {



                allParts.Add((Outsourced)partToAdd);

            }



        }

       static public bool deletePart (Part partToDelete)
        {

            /*
            if (Inventory.AllParts.Contains(partToDelete))
            {


                Inventory.AllParts.Remove(partToDelete);
                return true;






            }
            else
            {

                return false;

            }*/

            foreach(Product product in Products)
            {


                if (product.AssociatedParts.Contains(partToDelete))
                {


                    MessageBox.Show("Part currently belongs to product(s)!", "Part Delete Failure");
                    return false;


                }

               









            }

            Inventory.AllParts.Remove(partToDelete);
            return true;









        }

       public static Part lookUpPart (int numToSearch)
       {


            foreach(Part part in AllParts)
            {

                if (numToSearch == part.PartID)
                {

                    return part;


                }





            }






            dummyPart = new Outsourced();
            return dummyPart;



        } 

        public static void updatePart (int numUpdate, Part partToUpdate)
        {


            /*
            if (partToUpdate is InHouse) { 


                foreach (Part part in allParts)
                {

                        if (numUpdate == part.PartID)
                        {

                            part.InStock = partToUpdate.InStock;
                            part.Name = partToUpdate.Name;
                            part.Price = partToUpdate.Price;
                            part.Min = partToUpdate.Min;
                            part.Max = partToUpdate.Max;
                             //   Inventory.GetMachineID((InHouse)partToUpdate);
                             ((InHouse)part).MachineID = Inventory.GetMachineID((InHouse)partToUpdate);






                    }








                    }

            }
            else if (partToUpdate is Outsourced)
            {



                foreach (Part part in allParts)
                {

                    if (numUpdate == part.PartID)
                    {

                        part.InStock = partToUpdate.InStock;
                        part.Name = partToUpdate.Name;
                        part.Price = partToUpdate.Price;
                        part.Min = partToUpdate.Min;
                        part.Max = partToUpdate.Max;
                        ((Outsourced)part).CompanyName = Inventory.GetCompanyName((Outsourced)partToUpdate);





                    }








                }






            }
            */


            foreach(Part part in AllParts)
            {

                if (numUpdate == part.PartID)
                {


                    if(part.GetType() == inHouseCompare.GetType())
                    {

                        part.PartID = partToUpdate.PartID;
                        part.InStock = partToUpdate.InStock;
                        part.Name = partToUpdate.Name;
                        part.Price = partToUpdate.Price;
                        part.Min = partToUpdate.Min;
                        part.Max = partToUpdate.Max;
                        //   Inventory.GetMachineID((InHouse)partToUpdate);
                        ((InHouse)part).MachineID = Inventory.GetMachineID((InHouse)partToUpdate);





                    }
                    else if(part.GetType() == outsourcedCompare.GetType())
                    {
                        part.PartID = partToUpdate.PartID;
                        part.InStock = partToUpdate.InStock;
                        part.Name = partToUpdate.Name;
                        part.Price = partToUpdate.Price;
                        part.Min = partToUpdate.Min;
                        part.Max = partToUpdate.Max;
                        ((Outsourced)part).CompanyName = Inventory.GetCompanyName((Outsourced)partToUpdate);






                    }









                }







            }















        }




       static public int GetMachineID(InHouse partToSearch)
        {




            return partToSearch.MachineID;



        }

        static public string GetCompanyName(Outsourced partToSearch)
        {



            return partToSearch.CompanyName;


        }

        //
        static public void ConvertToInHouse (Outsourced inputOutsourced, int newMachineID)
        {

            
           // InHouse inHouse = new InHouse();
            inHouse.Name = inputOutsourced.Name;
            inHouse.InStock = inputOutsourced.InStock;
            inHouse.Price = inputOutsourced.Price;
            inHouse.Min = inputOutsourced.Min;
            inHouse.Max = inputOutsourced.Max;
            inHouse.PartID = inputOutsourced.PartID;

            inHouse.MachineID = newMachineID;





            /*
            // newest
            foreach (Product product in Products)
            {

                for (int i = 0; i < product.AssociatedParts.Count; ++i)
                {

                    if (product.AssociatedParts[i].PartID == outSourced.PartID)
                    {

                      //  product.AssociatedParts.RemoveAt(i);
                        product.AssociatedParts.Add(inHouse); //
                        break;

                    }




                }






            }
            //
            */





            
            foreach (Part part in AllParts)
            {

                if (part.PartID == inputOutsourced.PartID)
                {


                    AllParts.Remove(part);
                    break;


                }





            }
            



            //
            AllParts.Add(inHouse);
            //
           







        }

        static public void ConvertToOutsourced(InHouse inputInHouse, string newCompanyName)
        {


           // Outsourced outSourced = new Outsourced();
            outSourced.Name = inputInHouse.Name;
            outSourced.InStock = inputInHouse.InStock;
            outSourced.Price = inputInHouse.Price;
            outSourced.Min = inputInHouse.Min;
            outSourced.Max = inputInHouse.Max;
            outSourced.PartID = inputInHouse.PartID;
            

            outSourced.CompanyName = newCompanyName;



            /*
            // newest
            foreach(Product product in Products)
            {

                for (int i = 0; i < product.AssociatedParts.Count; ++i)
                {

                    if(product.AssociatedParts[i].PartID == outSourced.PartID)
                    {

                      //  product.AssociatedParts.RemoveAt(i);
                        product.AssociatedParts.Add(outSourced); //
                        break; //
                    }




                }


                



            }
            // newest
            */





           





            
            foreach (Part part in AllParts)
            {






                if (part.PartID == inputInHouse.PartID)
                {


                    AllParts.Remove(part);
                    break;


                }





            }
            


            
           





            //
            AllParts.Add(outSourced);
            //

            







        }
        




    }
}

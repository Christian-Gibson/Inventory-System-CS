using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem
{

    

    public partial class MainForm : Form
    {

        AddPartForm partForm = new AddPartForm();
       ModifyPartForm modifyPartForm = new ModifyPartForm();
        AddProductForm addProductForm = new AddProductForm();
        ModifyProductForm modifyProductForm = new ModifyProductForm();


        public static DataGridViewSelectedRowCollection mainPartRows;
        public static DataGridViewSelectedRowCollection mainProductRows;
        
        

        public MainForm()
        {
            InitializeComponent();

            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {



            partDataGridViewMain.DataSource = Inventory.AllParts;
            productDataGridViewMain.DataSource = Inventory.Products;

            




        }

      

        private void exitBtn_Click(object sender, EventArgs e)
        {
            


            Close();

            


        }

     

        private void addProductBtn_Click(object sender, EventArgs e)
        {


            addProductForm.ShowDialog();
           
            

            



        }

        private void addPartBtn_Click(object sender, EventArgs e)
        {



             
              partForm.ShowDialog();
            



        }

        private void deleteProductBtn_Click(object sender, EventArgs e)
        {
            /*
            DataGridViewSelectedRowCollection rowsToBeDeleted = productDataGridViewMain.SelectedRows;


            foreach (DataGridViewRow row in rowsToBeDeleted)
            {

                productDataGridViewMain.Rows.Remove(row);


            }
            */

            bool goodToDelete = false;

            DataGridViewSelectedRowCollection rowsToBeDeleted = productDataGridViewMain.SelectedRows;


            var result = MessageBox.Show("Selected product will be deleted. Continue?", "Deleting Product...", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {

                foreach (DataGridViewRow row in rowsToBeDeleted)
                {




                    /*
                    if (!Inventory.removeProduct(((Product)row.DataBoundItem).ProductID))
                    {

                        productDataGridViewMain.Rows.Remove(row);




                    }
                    */

                    goodToDelete = Inventory.removeProduct(((Product)row.DataBoundItem).ProductID);







                }




            }








        }

        private void searchProductBtn_Click(object sender, EventArgs e)
        {



            int parsedProductID;

            try //Try to parse the input Part ID. Non ints are caught (FormatException).
            {

                parsedProductID = int.Parse(textBoxProductSearch.Text);




                foreach (DataGridViewRow row in productDataGridViewMain.Rows)
                {



                    if (((Product)row.DataBoundItem == Inventory.lookUpProduct(parsedProductID))) //Checks every part for matching ID,
                    {                                                                  // else if the part with the ID part does not exist, throw Not Found.



                        row.Selected = true;



                    }
                    else if (!Inventory.Products.Contains(Inventory.lookUpProduct(parsedProductID)))
                    {




                        throw new Exception("Product ID not found!");





                    }




                }
            }
            catch (FormatException excpt)
            {
                MessageBox.Show(excpt.Message);
                MessageBox.Show("Check Product ID number and retry input.");


            }


            catch (Exception excpt)
            {
                MessageBox.Show(excpt.Message);


            }









        }

        private void searchPartBtn_Click(object sender, EventArgs e)
        {


            int parsedPartID;

            try //Try to parse the input Part ID. Non ints are caught (FormatException).
            {

                parsedPartID = int.Parse(textBoxPartSearch.Text);
               
                
           

            foreach (DataGridViewRow row in partDataGridViewMain.Rows)
            {
                
                
                
               if(((Part)row.DataBoundItem == Inventory.lookUpPart(parsedPartID))) //Checks every part for matching ID,
                {                                                                  // else if the part with the ID part does not exist, throw Not Found.



                    row.Selected = true;



                }
               else if(!Inventory.AllParts.Contains(Inventory.lookUpPart(parsedPartID)))
                {




                        throw new Exception("Part ID not found!");
                    
                    



                }

               


            }
             }
            catch(FormatException excpt)
            {
                MessageBox.Show(excpt.Message);
                MessageBox.Show("Check Part ID number and try again.");

            }


            catch (Exception excpt)
            {
                MessageBox.Show(excpt.Message);


            }
            




        }





        private void deletePartBtn_Click(object sender, EventArgs e)
        {


            bool goodToDelete = false;
            

            DataGridViewSelectedRowCollection rowsToBeDeleted = partDataGridViewMain.SelectedRows;

            var deletePartResult = MessageBox.Show("This will delete any selected part. Continue?", "Deleting Part...", MessageBoxButtons.YesNo);


            if (deletePartResult == DialogResult.Yes) {  //

                foreach (DataGridViewRow row in rowsToBeDeleted)
                {
               

                     goodToDelete = Inventory.deletePart((Part)row.DataBoundItem);

              

                    


                }

            } //


        }

        private void modifyPartBtn_Click(object sender, EventArgs e)
        {

             

            mainPartRows = partDataGridViewMain.SelectedRows;

            //Test this soon
           // DataGridViewRowCollection collections = partDataGridViewMain.Rows;

            DataGridViewSelectedRowCollection tlkj = partDataGridViewMain.SelectedRows;

            try { 

                if (tlkj.Count > 1 || tlkj.Count == 0)
                {

                    throw new Exception("Select only one part to modify.");


                }

               

                foreach (DataGridViewRow row in tlkj)
                {


                    




                }

                modifyPartForm.ShowDialog();

            }

            
            catch (Exception excpt)
            {


                MessageBox.Show(excpt.Message);



            }

           




        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            partForm.Refresh();

            partDataGridViewMain.Refresh();

            modifyPartForm.Refresh();

            productDataGridViewMain.Refresh();

            modifyProductForm.Refresh();

            



        }

        private void modifyProductBtn_Click(object sender, EventArgs e)
        {

            mainProductRows = productDataGridViewMain.SelectedRows;

            // mainRows = partDataGridViewMain.SelectedRows;



            DataGridViewSelectedRowCollection selectedProductCollection = productDataGridViewMain.SelectedRows;

            try
            {

                if (selectedProductCollection.Count > 1 || selectedProductCollection.Count == 0)
                {

                    throw new Exception("Select only one product to modify.");


                }



                foreach (DataGridViewRow row in selectedProductCollection)
                {







                }

                modifyProductForm.ShowDialog();

            }


            catch (Exception excpt)
            {


                MessageBox.Show(excpt.Message);



            }





        }
    }





    



}

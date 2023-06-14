using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventorySystem
{
    public partial class AddProductForm : Form
    {

        BindingList<Part> partsAdded = new BindingList<Part>();


        public BindingList<Part> PartsAdded
        {
            get { return partsAdded; } 
            set { partsAdded = value; }



        }


        public AddProductForm()
        {
            InitializeComponent();
        }

        private void buttonAddProductCancel_Click(object sender, EventArgs e)
        {

            Close();



        }

        private void buttonAddProductSaveProduct_Click(object sender, EventArgs e)
        {



            try
            {


                if ((int.Parse(textBoxAddProductMin.Text) > int.Parse(textBoxAddProductMax.Text)))
                {


                    throw new Exception("Min value must be smaller than max. Check input and try again.");



                }


                if (!(int.Parse(textBoxAddProductInStock.Text) > int.Parse(textBoxAddProductMin.Text) && int.Parse(textBoxAddProductInStock.Text) < int.Parse(textBoxAddProductMax.Text)))
                {


                    throw new Exception("Fix InStock Value. InStock must be between Min and Max.");



                }



                Product newProduct = new Product();





                newProduct.Name = textBoxAddProductName.Text;
                newProduct.InStock = int.Parse(textBoxAddProductInStock.Text);
                newProduct.Price = (decimal)double.Parse(textBoxAddProductPrice.Text);
                newProduct.Max = int.Parse(textBoxAddProductMax.Text);
                newProduct.Min = int.Parse(textBoxAddProductMin.Text);






                foreach(Part part in PartsAdded)
                {

                    newProduct.addAssociatedPart(part);



                }



                Inventory.addProduct(newProduct);
                PartsAdded.Clear();


            }
            catch (FormatException excpt)
            {

                MessageBox.Show("One or more input field(s) contains invalid data. Re-check entry.", "Modify Part Error- Part Not Saved!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                PartsAdded.Clear();
                Close();



            }
            catch (Exception excpt)
            {

                MessageBox.Show(excpt.Message, "Add Product Error - Product Not Saved!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                PartsAdded.Clear();
                Close();


            }

            Close();




        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {

            addProductAllCandidatePartsDataGridView.DataSource = Inventory.AllParts;
           addProductAssociatedPartsDataGridView.DataSource = PartsAdded;
           



        }

        private void buttonAddProductAddPart_Click(object sender, EventArgs e)
        {

            DataGridViewSelectedRowCollection test1 = addProductAllCandidatePartsDataGridView.SelectedRows;

            

           

            foreach (DataGridViewRow row in test1)
            {

                PartsAdded.Add((Part)row.DataBoundItem);
                

                


            }







        }

        private void buttonAddProductDeletePart_Click(object sender, EventArgs e)
        {



            DataGridViewSelectedRowCollection test1 = addProductAssociatedPartsDataGridView.SelectedRows;





            foreach (DataGridViewRow row in test1)
            {

                PartsAdded.Remove((Part)row.DataBoundItem);

                //



            }





        }

        private void buttonAddProductSearch_Click(object sender, EventArgs e)
        {



            int parsedPartID;

            try //Try to parse the input Part ID. Non ints are caught (FormatException).
            {

                parsedPartID = int.Parse(textBoxAddProductSearch.Text);




                foreach (DataGridViewRow row in addProductAllCandidatePartsDataGridView.Rows)
                {



                    if (((Part)row.DataBoundItem == Inventory.lookUpPart(parsedPartID))) //Checks every part for matching ID,
                    {                                                                  // else if the part with the ID part does not exist, throw Not Found.



                        row.Selected = true;



                    }
                    else if (!Inventory.AllParts.Contains(Inventory.lookUpPart(parsedPartID)))
                    {




                        throw new Exception("Part ID not found!");





                    }




                }
            }
            catch (FormatException excpt)
            {
                MessageBox.Show(excpt.Message);
                MessageBox.Show("Check Part ID number and try again.");

            }


            catch (Exception excpt)
            {
                MessageBox.Show(excpt.Message);


            }





        }
    }
    
}

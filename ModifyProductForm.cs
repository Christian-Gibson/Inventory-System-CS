using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventorySystem
{
    public partial class ModifyProductForm : Form
    {
        BindingSource mySource = new BindingSource();

        BindingList<Part> partsModifyAdded = new BindingList<Part>();
        public DataGridViewSelectedRowCollection modifyProductSelections;

        public BindingList<Part> PartsModifyAdded
        {
            get { return partsModifyAdded; }
            set { partsModifyAdded = value; }



        }

        public ModifyProductForm()
        {
            InitializeComponent();
        }

        private void ModifyProductForm_Load(object sender, EventArgs e)
        {

            modifyProductSelections = MainForm.mainProductRows;

           
           


            foreach (DataGridViewRow row in modifyProductSelections)
            {

                textBoxModifyProductID.Text = ((Product)row.DataBoundItem).ProductID.ToString();
                textBoxModifyProductName.Text = ((Product)row.DataBoundItem).Name.ToString();
                textBoxModifyProductInStock.Text = ((Product)row.DataBoundItem).InStock.ToString();
                textBoxModifyProductPrice.Text = ((Product)row.DataBoundItem).Price.ToString();
                textBoxModifyProductMin.Text = ((Product)row.DataBoundItem).Min.ToString();
                textBoxModifyProductMax.Text = ((Product)row.DataBoundItem).Max.ToString();

               

                modifyProductAllCandidatePartsDataGridView.DataSource = Inventory.AllParts;
                modifyProductAssociatedPartsDataGridView.DataSource = ((Product)row.DataBoundItem).AssociatedParts;
                
                // del
                PartsModifyAdded = ((Product)row.DataBoundItem).AssociatedParts;


            }








        }

        private void buttonModifyProductCancel_Click(object sender, EventArgs e)
        {


            Close();


        }

        private void buttonModifyProductAddPart_Click(object sender, EventArgs e)
        {



            DataGridViewSelectedRowCollection test1 = modifyProductAllCandidatePartsDataGridView.SelectedRows;





            foreach (DataGridViewRow row in test1)
            {

              //  AddProductForm.PartsAdded.Add((Part)row.DataBoundItem);

                PartsModifyAdded.Add((Part)row.DataBoundItem);


               

            }




            modifyProductAssociatedPartsDataGridView.Refresh();
            modifyProductAssociatedPartsDataGridView.Update();
        


        }

        private void buttonModifyProductDeletePart_Click(object sender, EventArgs e)
        {



            DataGridViewSelectedRowCollection test1 = modifyProductAssociatedPartsDataGridView.SelectedRows;





            foreach (DataGridViewRow row in test1)
            {

                PartsModifyAdded.Remove((Part)row.DataBoundItem);





            }

            modifyProductAssociatedPartsDataGridView.Refresh();


        }

        private void buttonModifyProductSaveProduct_Click(object sender, EventArgs e)
        {

            try
            {
                if (int.Parse(textBoxModifyProductMin.Text) > int.Parse(textBoxModifyProductMax.Text))
                {


                    throw new Exception("Check input. Min value must be lower than Max.");



                }
                if (!(int.Parse(textBoxModifyProductInStock.Text) > int.Parse(textBoxModifyProductMin.Text) && int.Parse(textBoxModifyProductInStock.Text) < int.Parse(textBoxModifyProductMax.Text)))
                {


                    throw new Exception("Check input. InStock value must be between Min and Max.");



                }



                Product updateProd = new Product();


                updateProd.Name = textBoxModifyProductName.Text;
                updateProd.InStock = int.Parse(textBoxModifyProductInStock.Text);
                updateProd.Price = (decimal)double.Parse(textBoxModifyProductPrice.Text);
                updateProd.Min = int.Parse(textBoxModifyProductMin.Text);
                updateProd.Max = int.Parse(textBoxModifyProductMax.Text);


                foreach (Part part in PartsModifyAdded)
                {


                    updateProd.addAssociatedPart(part);



                }




                Inventory.updateProduct(int.Parse(textBoxModifyProductID.Text), updateProd);
                // PartsModifyAdded.Clear();


                Close();
            }
            catch (FormatException excpt)
            {

                MessageBox.Show("One or more input field(s) contains invalid data. Re-check entry.", "Modify Product Error- Product Not Saved!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);




            }
            catch (Exception excpt)
            {
                MessageBox.Show(excpt.Message, "Modify Product Error - Product Not Saved!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                Close();
            }



        }

        private void buttonModifyProductSearch_Click(object sender, EventArgs e)
        {



            int parsedPartID;

            try //Try to parse the input Part ID. Non ints are caught (FormatException).
            {

                parsedPartID = int.Parse(textBoxModifyProductSearch.Text);




                foreach (DataGridViewRow row in modifyProductAllCandidatePartsDataGridView.Rows)
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

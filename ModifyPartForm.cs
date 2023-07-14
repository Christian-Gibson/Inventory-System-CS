using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventorySystem
{
    public partial class ModifyPartForm : Form
    {

        static Outsourced outsourcedExample = new Outsourced();
        static InHouse inHouseExample = new InHouse();
        public DataGridViewSelectedRowCollection modifyPartSelections;

        public ModifyPartForm()
        {
            InitializeComponent();
        }

        private void ModifyPartForm_Load(object sender, EventArgs e)
        {

          //  outsourcedExample = new Outsourced();
          //  inHouseExample = new InHouse();

            // modifyPartSelections = MainForm.mainRows;
             modifyPartSelections = MainForm.mainPartRows;



            foreach (DataGridViewRow row in modifyPartSelections)
            {
                
                textBoxModifyPartPartID.Text = ((Part)row.DataBoundItem).PartID.ToString();
                textBoxModifyPartName.Text = ((Part)row.DataBoundItem).Name;
                textBoxModifyPartInStock.Text = ((Part)row.DataBoundItem).InStock.ToString();
                textBoxModifyPartPrice.Text = ((Part)row.DataBoundItem).Price.ToString();
                textBoxModifyPartMin.Text = ((Part)row.DataBoundItem).Min.ToString();
                textBoxModifyPartMax.Text = ((Part)row.DataBoundItem).Max.ToString();

                if (row.DataBoundItem is InHouse)
                {

                    textBoxModifyPartMachineID_CompanyName.Text = ((InHouse)row.DataBoundItem).MachineID.ToString();
                    radioButtonModifyPartInHouse.Select();


                }
                else if(row.DataBoundItem is Outsourced)
                {



                     textBoxModifyPartMachineID_CompanyName.Text = ((Outsourced)row.DataBoundItem).CompanyName;
                    radioButtonModifyPartOutsourced.Select();

                }






            }
         }

            
            





        

        private void radioButtonModifyPartOutsourced_CheckedChanged(object sender, EventArgs e)
        {



            labelModifyPartMachineID_CompanyName.Text = "Company Name:";


        }

        private void radioButtonModifyPartInHouse_CheckedChanged(object sender, EventArgs e)
        {



            labelModifyPartMachineID_CompanyName.Text = "Machine ID:";


        }

        private void cancelModifyPartBtn_Click(object sender, EventArgs e)
        {



            Close();


        }

        private void saveModifyPartBtn_Click(object sender, EventArgs e)
        {



          //  outsourcedExample = new Outsourced();
          //  inHouseExample = new InHouse();



            modifyPartSelections = MainForm.mainPartRows;


            foreach(DataGridViewRow row in modifyPartSelections)
            {

                if(row.DataBoundItem is Outsourced)
                {

                    if (radioButtonModifyPartInHouse.Checked)
                    {

                     


                        try {



                            if (int.Parse(textBoxModifyPartMin.Text) > int.Parse(textBoxModifyPartMax.Text))
                            {


                                throw new Exception("Check input. Min value must be lower than Max.");



                            }
                            if (!(int.Parse(textBoxModifyPartInStock.Text) > int.Parse(textBoxModifyPartMin.Text) && int.Parse(textBoxModifyPartInStock.Text) < int.Parse(textBoxModifyPartMax.Text)))
                            {


                                throw new Exception("Check input. InStock value must be between Min and Max.");



                            }



                            //
                            outsourcedExample.PartID = int.Parse(textBoxModifyPartPartID.Text);
                            //
                            outsourcedExample.Name = textBoxModifyPartName.Text;
                            outsourcedExample.InStock = int.Parse(textBoxModifyPartInStock.Text);
                            outsourcedExample.Price = (decimal)double.Parse(textBoxModifyPartPrice.Text);
                            outsourcedExample.Min = int.Parse(textBoxModifyPartMin.Text);
                            outsourcedExample.Max = int.Parse(textBoxModifyPartMax.Text);
                            outsourcedExample.CompanyName = textBoxModifyPartMachineID_CompanyName.Text;

                           




                            Inventory.ConvertToInHouse(outsourcedExample, int.Parse(textBoxModifyPartMachineID_CompanyName.Text));


                         //   Inventory.updatePart(int.Parse(textBoxModifyPartPartID.Text), Inventory.ConvertToInHouse(outsourcedExample,int.Parse(textBoxModifyPartMachineID_CompanyName.Text)));




                            textBoxModifyPartName.Text = " ";
                            textBoxModifyPartInStock.Text = " ";
                            textBoxModifyPartPrice.Text = " ";
                            textBoxModifyPartMin.Text = " ";
                            textBoxModifyPartMax.Text = " ";
                            textBoxModifyPartMachineID_CompanyName.Text = " ";

                           // radioButtonModifyPartInHouse.Refresh();
                            Close();
                        }
                        catch (FormatException excpt)
                        {

                            MessageBox.Show("One or more input field(s) contains invalid data. Re-check entry.", "Modify Part Error - Part Not Saved!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            Close();



                        }
                        catch (Exception excpt)
                        {

                            MessageBox.Show(excpt.Message, "Modify Part Error - Part Not Saved!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            Close();



                        }

                        Close();



                    }
                    else if (radioButtonModifyPartOutsourced.Checked) 
                    {
                        try {



                            if (int.Parse(textBoxModifyPartMin.Text) > int.Parse(textBoxModifyPartMax.Text))
                            {


                                throw new Exception("Check input. Min value must be lower than Max.");



                            }
                            if (!(int.Parse(textBoxModifyPartInStock.Text) > int.Parse(textBoxModifyPartMin.Text) && int.Parse(textBoxModifyPartInStock.Text) < int.Parse(textBoxModifyPartMax.Text)))
                            {


                                throw new Exception("Check input. InStock value must be between Min and Max.");



                            }


                            outsourcedExample.PartID = int.Parse(textBoxModifyPartPartID.Text);
                        outsourcedExample.Name = textBoxModifyPartName.Text;
                        outsourcedExample.InStock = int.Parse(textBoxModifyPartInStock.Text);
                        outsourcedExample.Price = (decimal)double.Parse(textBoxModifyPartPrice.Text);
                        outsourcedExample.Min = int.Parse(textBoxModifyPartMin.Text);
                        outsourcedExample.Max = int.Parse(textBoxModifyPartMax.Text);
                        outsourcedExample.CompanyName = textBoxModifyPartMachineID_CompanyName.Text;


                    



                            Inventory.updatePart(int.Parse(textBoxModifyPartPartID.Text), outsourcedExample);

                        textBoxModifyPartName.Text = " ";
                        textBoxModifyPartInStock.Text = " ";
                        textBoxModifyPartPrice.Text = " ";
                        textBoxModifyPartMin.Text = " ";
                        textBoxModifyPartMax.Text = " ";
                        textBoxModifyPartMachineID_CompanyName.Text = " ";


                      //  radioButtonModifyPartOutsourced.Refresh();
                        Close();


                        }
                        catch (FormatException excpt)
                        {

                            MessageBox.Show("One or more input field(s) contains invalid data. Re-check entry.", "Modify Part Error- Part Not Saved!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            Close();



                        }
                        catch (Exception excpt)
                        {


                            MessageBox.Show(excpt.Message, "Modify Part Error- Part Not Saved!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            Close();



                        }








                    }






                }
                else if (row.DataBoundItem is InHouse)
                {


                    if (radioButtonModifyPartInHouse.Checked)
                    {

                        try
                        {


                            if (int.Parse(textBoxModifyPartMin.Text) > int.Parse(textBoxModifyPartMax.Text))
                            {


                                throw new Exception("Check input. Min value must be lower than Max.");



                            }
                            if (!(int.Parse(textBoxModifyPartInStock.Text) > int.Parse(textBoxModifyPartMin.Text) && int.Parse(textBoxModifyPartInStock.Text) < int.Parse(textBoxModifyPartMax.Text)))
                            {


                                throw new Exception("Check input. InStock value must be between Min and Max.");



                            }


                            inHouseExample.PartID = int.Parse(textBoxModifyPartPartID.Text);
                            inHouseExample.Name = textBoxModifyPartName.Text;
                            inHouseExample.InStock = int.Parse(textBoxModifyPartInStock.Text);
                            inHouseExample.Price = (decimal)double.Parse(textBoxModifyPartPrice.Text);
                            inHouseExample.Min = int.Parse(textBoxModifyPartMin.Text);
                            inHouseExample.Max = int.Parse(textBoxModifyPartMax.Text);
                            inHouseExample.MachineID = int.Parse(textBoxModifyPartMachineID_CompanyName.Text);

           




                            Inventory.updatePart(int.Parse(textBoxModifyPartPartID.Text), inHouseExample);




                            textBoxModifyPartName.Text = " ";
                            textBoxModifyPartInStock.Text = " ";
                            textBoxModifyPartPrice.Text = " ";
                            textBoxModifyPartMin.Text = " ";
                            textBoxModifyPartMax.Text = " ";
                            textBoxModifyPartMachineID_CompanyName.Text = " ";

                            //  radioButtonModifyPartInHouse.Refresh();
                            Close();
                        }
                        catch (FormatException excpt)
                        {

                            MessageBox.Show("One or more input field(s) contains invalid data. Re-check entry.", "Modify Part Error- Part Not Saved!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            Close();



                        }
                        catch (Exception excpt)
                        {


                            MessageBox.Show(excpt.Message, "Modify Part Error- Part Not Saved!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            Close();


                        }




                    }
                    else if (radioButtonModifyPartOutsourced.Checked)
                    {



                        try
                        {


                            if (int.Parse(textBoxModifyPartMin.Text) > int.Parse(textBoxModifyPartMax.Text))
                            {


                                throw new Exception("Check input. Min value must be lower than Max.");



                            }
                            if (!(int.Parse(textBoxModifyPartInStock.Text) > int.Parse(textBoxModifyPartMin.Text) && int.Parse(textBoxModifyPartInStock.Text) < int.Parse(textBoxModifyPartMax.Text)))
                            {


                                throw new Exception("Check input. InStock value must be between Min and Max.");



                            }


                            inHouseExample.PartID = int.Parse(textBoxModifyPartPartID.Text);
                            inHouseExample.Name = textBoxModifyPartName.Text;
                            inHouseExample.InStock = int.Parse(textBoxModifyPartInStock.Text);
                            inHouseExample.Price = (decimal)double.Parse(textBoxModifyPartPrice.Text);
                            inHouseExample.Min = int.Parse(textBoxModifyPartMin.Text);
                            inHouseExample.Max = int.Parse(textBoxModifyPartMax.Text);
                            //   inHouseExample.MachineID = int.Parse(textBoxModifyPartMachineID_CompanyName.Text);


    


                            Inventory.ConvertToOutsourced(inHouseExample, textBoxModifyPartMachineID_CompanyName.Text);

                            

                            textBoxModifyPartName.Text = " ";
                            textBoxModifyPartInStock.Text = " ";
                            textBoxModifyPartPrice.Text = " ";
                            textBoxModifyPartMin.Text = " ";
                            textBoxModifyPartMax.Text = " ";
                            textBoxModifyPartMachineID_CompanyName.Text = " ";


                            Close();
                        }
                        catch (FormatException excpt)
                        {

                            MessageBox.Show("One or more input field(s) contains invalid data. Re-check entry.", "Modify Part Error- Part Not Saved!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            Close();



                        }
                        catch (Exception excpt)
                        {


                            MessageBox.Show(excpt.Message, "Modify Part Error- Part Not Saved!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            Close();


                        }











                    }


















                }








            }



            
            




            



        }

        private void ModifyPartForm_Leave(object sender, EventArgs e)
        {








        }
    }
}

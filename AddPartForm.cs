using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventorySystem
{
    public partial class AddPartForm : Form
    {
        Inventory inv2 = new Inventory();
        
        
        

        public AddPartForm()
        {
            InitializeComponent();
        }

        private void radioButtonPartInHouse_CheckedChanged(object sender, EventArgs e)
        {



            labelPartMachineID_CompanyName.Text = "Machine ID:";
            labelPartMachineID_CompanyName.Location = new Point(252, 258);




        }

        private void radioButtonPartOutsourced_CheckedChanged(object sender, EventArgs e)
        {



                
            labelPartMachineID_CompanyName.Text = "Company Name:";
            labelPartMachineID_CompanyName.Location = new Point(220, 258); //Adjust label position to compensate for text change




        }

        private void savePartBtn_Click(object sender, EventArgs e)
        {



            if (radioButtonAddPartInHouse.Checked)
            {


                try
                {


                    InHouse inHousePart = new InHouse();


                    


                    
                    inHousePart.Name = textBoxPartName.Text;
                    inHousePart.InStock = int.Parse(textBoxPartInStock.Text);
                    inHousePart.Price = (decimal) double.Parse(textBoxPartPrice.Text);
                    inHousePart.Max = int.Parse(textBoxPartMax.Text);
                    inHousePart.Min = int.Parse(textBoxPartMin.Text);
                    inHousePart.MachineID = int.Parse(textBoxPartMachineID_CompanyName.Text);

                    if ((inHousePart.Min > inHousePart.Max))
                    {


                        throw new Exception("Min value must be smaller than max. Check input and try again.");



                    }

                    if (!(inHousePart.InStock > inHousePart.Min && inHousePart.InStock < inHousePart.Max))
                    {


                        throw new Exception("Check InStock Value. Must be between Min and Max.");
                       


                    }
                    


                    /* textBoxPartName.Text,int.Parse(textBoxPartMin.Text), int.Parse(textBoxPartMachineID_CompanyName.Text))*/






                    Inventory.addPart(inHousePart);

                }
                catch (FormatException excpt)
                {

                    MessageBox.Show("One or more input field(s) contains invalid data. Re-check entry.", "Add Part Error- Part Not Saved!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);




                }
                catch (Exception excpt)
                {

                    MessageBox.Show(excpt.Message, "Add Part Error- Part Not Saved!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);




                }
                

                Close();




            }
            else if (radioButtonAddPartOutsourced.Checked)
            {


                try { 

                Outsourced outSourcedPart = new Outsourced();


                outSourcedPart.Name = textBoxPartName.Text;
                outSourcedPart.Max = int.Parse(textBoxPartMax.Text);
                outSourcedPart.Min = int.Parse(textBoxPartMin.Text);

                   


                    outSourcedPart.InStock = int.Parse(textBoxPartInStock.Text);
                outSourcedPart.Price = (decimal) double.Parse(textBoxPartPrice.Text);
                outSourcedPart.CompanyName = textBoxPartMachineID_CompanyName.Text;


                    if ((outSourcedPart.Min > outSourcedPart.Max))
                    {


                        throw new Exception("Min value must be smaller than max. Check input and try again.");



                    }



                    if (!(outSourcedPart.InStock > outSourcedPart.Min && outSourcedPart.InStock < outSourcedPart.Max)) 
                    {


                        throw new Exception("Fix InStock Value. Must be between Min and Max.");



                    }
                   




                    Inventory.addPart(outSourcedPart);

                }
                catch (FormatException excpt)
                {
                    
                    MessageBox.Show("One or more input field(s) contains invalid data. Re-check entry.", "Add Part Error- Part Not Saved!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);




                }
                catch (Exception excpt)
                {



                    
                    MessageBox.Show(excpt.Message, "Add Part Error - Part Not Saved!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);



                }
              

                Close();


            }
            else if(!radioButtonAddPartInHouse.Checked && !radioButtonAddPartOutsourced.Checked)
            {

                MessageBox.Show("Please select In House or Outsourced.", "Select an Option", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1); ;


            }



            
            


            

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            
            

            Close();


        }
    }
}

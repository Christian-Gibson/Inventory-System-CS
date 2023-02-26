
namespace InventorySystem
{
    partial class AddPartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.savePartBtn = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxPartName = new System.Windows.Forms.TextBox();
            this.textBoxPartInStock = new System.Windows.Forms.TextBox();
            this.textBoxPartPrice = new System.Windows.Forms.TextBox();
            this.textBoxPartMax = new System.Windows.Forms.TextBox();
            this.textBoxPartMin = new System.Windows.Forms.TextBox();
            this.textBoxPartMachineID_CompanyName = new System.Windows.Forms.TextBox();
            this.labelPartID = new System.Windows.Forms.Label();
            this.labelPartName = new System.Windows.Forms.Label();
            this.labelPartInStock = new System.Windows.Forms.Label();
            this.labelPartPrice = new System.Windows.Forms.Label();
            this.labelPartMax = new System.Windows.Forms.Label();
            this.labelPartMin = new System.Windows.Forms.Label();
            this.labelPartMachineID_CompanyName = new System.Windows.Forms.Label();
            this.radioButtonAddPartInHouse = new System.Windows.Forms.RadioButton();
            this.radioButtonAddPartOutsourced = new System.Windows.Forms.RadioButton();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // savePartBtn
            // 
            this.savePartBtn.Location = new System.Drawing.Point(252, 376);
            this.savePartBtn.Name = "savePartBtn";
            this.savePartBtn.Size = new System.Drawing.Size(94, 29);
            this.savePartBtn.TabIndex = 0;
            this.savePartBtn.Text = "Save";
            this.savePartBtn.UseVisualStyleBackColor = true;
            this.savePartBtn.Click += new System.EventHandler(this.savePartBtn_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(118, 69);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(125, 22);
            this.textBoxID.TabIndex = 1;
            // 
            // textBoxPartName
            // 
            this.textBoxPartName.Location = new System.Drawing.Point(335, 69);
            this.textBoxPartName.Name = "textBoxPartName";
            this.textBoxPartName.PlaceholderText = "Enter Name";
            this.textBoxPartName.Size = new System.Drawing.Size(125, 22);
            this.textBoxPartName.TabIndex = 2;
            // 
            // textBoxPartInStock
            // 
            this.textBoxPartInStock.Location = new System.Drawing.Point(554, 69);
            this.textBoxPartInStock.Name = "textBoxPartInStock";
            this.textBoxPartInStock.PlaceholderText = "Enter Amount";
            this.textBoxPartInStock.Size = new System.Drawing.Size(125, 22);
            this.textBoxPartInStock.TabIndex = 3;
            // 
            // textBoxPartPrice
            // 
            this.textBoxPartPrice.Location = new System.Drawing.Point(118, 170);
            this.textBoxPartPrice.Name = "textBoxPartPrice";
            this.textBoxPartPrice.Size = new System.Drawing.Size(125, 22);
            this.textBoxPartPrice.TabIndex = 4;
            // 
            // textBoxPartMax
            // 
            this.textBoxPartMax.Location = new System.Drawing.Point(631, 164);
            this.textBoxPartMax.Name = "textBoxPartMax";
            this.textBoxPartMax.Size = new System.Drawing.Size(38, 22);
            this.textBoxPartMax.TabIndex = 5;
            // 
            // textBoxPartMin
            // 
            this.textBoxPartMin.Location = new System.Drawing.Point(525, 164);
            this.textBoxPartMin.Name = "textBoxPartMin";
            this.textBoxPartMin.Size = new System.Drawing.Size(35, 22);
            this.textBoxPartMin.TabIndex = 6;
            // 
            // textBoxPartMachineID_CompanyName
            // 
            this.textBoxPartMachineID_CompanyName.Location = new System.Drawing.Point(335, 255);
            this.textBoxPartMachineID_CompanyName.Name = "textBoxPartMachineID_CompanyName";
            this.textBoxPartMachineID_CompanyName.Size = new System.Drawing.Size(125, 22);
            this.textBoxPartMachineID_CompanyName.TabIndex = 7;
            // 
            // labelPartID
            // 
            this.labelPartID.AutoSize = true;
            this.labelPartID.Location = new System.Drawing.Point(89, 72);
            this.labelPartID.Name = "labelPartID";
            this.labelPartID.Size = new System.Drawing.Size(23, 16);
            this.labelPartID.TabIndex = 8;
            this.labelPartID.Text = "ID:";
            // 
            // labelPartName
            // 
            this.labelPartName.AutoSize = true;
            this.labelPartName.Location = new System.Drawing.Point(285, 72);
            this.labelPartName.Name = "labelPartName";
            this.labelPartName.Size = new System.Drawing.Size(47, 16);
            this.labelPartName.TabIndex = 9;
            this.labelPartName.Text = "Name:";
            // 
            // labelPartInStock
            // 
            this.labelPartInStock.AutoSize = true;
            this.labelPartInStock.Location = new System.Drawing.Point(491, 72);
            this.labelPartInStock.Name = "labelPartInStock";
            this.labelPartInStock.Size = new System.Drawing.Size(57, 16);
            this.labelPartInStock.TabIndex = 10;
            this.labelPartInStock.Text = "In Stock:";
            // 
            // labelPartPrice
            // 
            this.labelPartPrice.AutoSize = true;
            this.labelPartPrice.Location = new System.Drawing.Point(68, 170);
            this.labelPartPrice.Name = "labelPartPrice";
            this.labelPartPrice.Size = new System.Drawing.Size(41, 16);
            this.labelPartPrice.TabIndex = 11;
            this.labelPartPrice.Text = "Price:";
            // 
            // labelPartMax
            // 
            this.labelPartMax.AutoSize = true;
            this.labelPartMax.Location = new System.Drawing.Point(590, 164);
            this.labelPartMax.Name = "labelPartMax";
            this.labelPartMax.Size = new System.Drawing.Size(35, 16);
            this.labelPartMax.TabIndex = 12;
            this.labelPartMax.Text = "Max:";
            // 
            // labelPartMin
            // 
            this.labelPartMin.AutoSize = true;
            this.labelPartMin.Location = new System.Drawing.Point(488, 164);
            this.labelPartMin.Name = "labelPartMin";
            this.labelPartMin.Size = new System.Drawing.Size(31, 16);
            this.labelPartMin.TabIndex = 13;
            this.labelPartMin.Text = "Min:";
            // 
            // labelPartMachineID_CompanyName
            // 
            this.labelPartMachineID_CompanyName.AutoSize = true;
            this.labelPartMachineID_CompanyName.Location = new System.Drawing.Point(252, 258);
            this.labelPartMachineID_CompanyName.Name = "labelPartMachineID_CompanyName";
            this.labelPartMachineID_CompanyName.Size = new System.Drawing.Size(77, 16);
            this.labelPartMachineID_CompanyName.TabIndex = 14;
            this.labelPartMachineID_CompanyName.Text = "Machine ID:";
            // 
            // radioButtonAddPartInHouse
            // 
            this.radioButtonAddPartInHouse.AutoSize = true;
            this.radioButtonAddPartInHouse.Location = new System.Drawing.Point(159, 322);
            this.radioButtonAddPartInHouse.Name = "radioButtonAddPartInHouse";
            this.radioButtonAddPartInHouse.Size = new System.Drawing.Size(82, 20);
            this.radioButtonAddPartInHouse.TabIndex = 15;
            this.radioButtonAddPartInHouse.TabStop = true;
            this.radioButtonAddPartInHouse.Text = "In-House";
            this.radioButtonAddPartInHouse.UseVisualStyleBackColor = true;
            this.radioButtonAddPartInHouse.CheckedChanged += new System.EventHandler(this.radioButtonPartInHouse_CheckedChanged);
            // 
            // radioButtonAddPartOutsourced
            // 
            this.radioButtonAddPartOutsourced.AutoSize = true;
            this.radioButtonAddPartOutsourced.Location = new System.Drawing.Point(504, 322);
            this.radioButtonAddPartOutsourced.Name = "radioButtonAddPartOutsourced";
            this.radioButtonAddPartOutsourced.Size = new System.Drawing.Size(97, 20);
            this.radioButtonAddPartOutsourced.TabIndex = 16;
            this.radioButtonAddPartOutsourced.TabStop = true;
            this.radioButtonAddPartOutsourced.Text = "Outsourced";
            this.radioButtonAddPartOutsourced.UseVisualStyleBackColor = true;
            this.radioButtonAddPartOutsourced.CheckedChanged += new System.EventHandler(this.radioButtonPartOutsourced_CheckedChanged);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(414, 376);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(94, 29);
            this.cancelBtn.TabIndex = 17;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // AddPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 450);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.radioButtonAddPartOutsourced);
            this.Controls.Add(this.radioButtonAddPartInHouse);
            this.Controls.Add(this.labelPartMachineID_CompanyName);
            this.Controls.Add(this.labelPartMin);
            this.Controls.Add(this.labelPartMax);
            this.Controls.Add(this.labelPartPrice);
            this.Controls.Add(this.labelPartInStock);
            this.Controls.Add(this.labelPartName);
            this.Controls.Add(this.labelPartID);
            this.Controls.Add(this.textBoxPartMachineID_CompanyName);
            this.Controls.Add(this.textBoxPartMin);
            this.Controls.Add(this.textBoxPartMax);
            this.Controls.Add(this.textBoxPartPrice);
            this.Controls.Add(this.textBoxPartInStock);
            this.Controls.Add(this.textBoxPartName);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.savePartBtn);
            this.Name = "AddPartForm";
            this.Text = "Add Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button savePartBtn;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxPartName;
        private System.Windows.Forms.TextBox textBoxPartInStock;
        private System.Windows.Forms.TextBox textBoxPartPrice;
        private System.Windows.Forms.TextBox textBoxPartMax;
        private System.Windows.Forms.TextBox textBoxPartMin;
        private System.Windows.Forms.TextBox textBoxPartMachineID_CompanyName;
        private System.Windows.Forms.Label labelPartID;
        private System.Windows.Forms.Label labelPartName;
        private System.Windows.Forms.Label labelPartInStock;
        private System.Windows.Forms.Label labelPartPrice;
        private System.Windows.Forms.Label labelPartMax;
        private System.Windows.Forms.Label labelPartMin;
        private System.Windows.Forms.Label labelPartMachineID_CompanyName;
        private System.Windows.Forms.RadioButton radioButtonAddPartInHouse;
        private System.Windows.Forms.RadioButton radioButtonAddPartOutsourced;
        private System.Windows.Forms.Button cancelBtn;
    }
}
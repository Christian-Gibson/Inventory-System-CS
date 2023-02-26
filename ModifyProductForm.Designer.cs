
namespace InventorySystem
{
    partial class ModifyProductForm
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
            this.buttonModifyProductSearch = new System.Windows.Forms.Button();
            this.textBoxModifyProductSearch = new System.Windows.Forms.TextBox();
            this.buttonModifyProductCancel = new System.Windows.Forms.Button();
            this.buttonModifyProductSaveProduct = new System.Windows.Forms.Button();
            this.buttonModifyProductDeletePart = new System.Windows.Forms.Button();
            this.buttonModifyProductAddPart = new System.Windows.Forms.Button();
            this.labelAddProductPAWTP = new System.Windows.Forms.Label();
            this.labelAddPartACP = new System.Windows.Forms.Label();
            this.modifyProductAssociatedPartsDataGridView = new System.Windows.Forms.DataGridView();
            this.modifyProductAllCandidatePartsDataGridView = new System.Windows.Forms.DataGridView();
            this.textBoxModifyProductMax = new System.Windows.Forms.TextBox();
            this.textBoxModifyProductMin = new System.Windows.Forms.TextBox();
            this.textBoxModifyProductPrice = new System.Windows.Forms.TextBox();
            this.textBoxModifyProductInStock = new System.Windows.Forms.TextBox();
            this.textBoxModifyProductName = new System.Windows.Forms.TextBox();
            this.textBoxModifyProductID = new System.Windows.Forms.TextBox();
            this.labelModifyProductMax = new System.Windows.Forms.Label();
            this.labelModifyProductMin = new System.Windows.Forms.Label();
            this.labelModifyProductPrice = new System.Windows.Forms.Label();
            this.labelModifyProductInStock = new System.Windows.Forms.Label();
            this.labelModifyProductName = new System.Windows.Forms.Label();
            this.labelModifyProductID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.modifyProductAssociatedPartsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifyProductAllCandidatePartsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonModifyProductSearch
            // 
            this.buttonModifyProductSearch.Location = new System.Drawing.Point(910, 32);
            this.buttonModifyProductSearch.Name = "buttonModifyProductSearch";
            this.buttonModifyProductSearch.Size = new System.Drawing.Size(94, 29);
            this.buttonModifyProductSearch.TabIndex = 43;
            this.buttonModifyProductSearch.Text = "Search";
            this.buttonModifyProductSearch.UseVisualStyleBackColor = true;
            this.buttonModifyProductSearch.Click += new System.EventHandler(this.buttonModifyProductSearch_Click);
            // 
            // textBoxModifyProductSearch
            // 
            this.textBoxModifyProductSearch.Location = new System.Drawing.Point(649, 35);
            this.textBoxModifyProductSearch.Name = "textBoxModifyProductSearch";
            this.textBoxModifyProductSearch.Size = new System.Drawing.Size(254, 22);
            this.textBoxModifyProductSearch.TabIndex = 42;
            // 
            // buttonModifyProductCancel
            // 
            this.buttonModifyProductCancel.Location = new System.Drawing.Point(961, 429);
            this.buttonModifyProductCancel.Name = "buttonModifyProductCancel";
            this.buttonModifyProductCancel.Size = new System.Drawing.Size(94, 29);
            this.buttonModifyProductCancel.TabIndex = 41;
            this.buttonModifyProductCancel.Text = "Cancel";
            this.buttonModifyProductCancel.UseVisualStyleBackColor = true;
            this.buttonModifyProductCancel.Click += new System.EventHandler(this.buttonModifyProductCancel_Click);
            // 
            // buttonModifyProductSaveProduct
            // 
            this.buttonModifyProductSaveProduct.Location = new System.Drawing.Point(845, 429);
            this.buttonModifyProductSaveProduct.Name = "buttonModifyProductSaveProduct";
            this.buttonModifyProductSaveProduct.Size = new System.Drawing.Size(80, 29);
            this.buttonModifyProductSaveProduct.TabIndex = 40;
            this.buttonModifyProductSaveProduct.Text = "Save";
            this.buttonModifyProductSaveProduct.UseVisualStyleBackColor = true;
            this.buttonModifyProductSaveProduct.Click += new System.EventHandler(this.buttonModifyProductSaveProduct_Click);
            // 
            // buttonModifyProductDeletePart
            // 
            this.buttonModifyProductDeletePart.Location = new System.Drawing.Point(529, 476);
            this.buttonModifyProductDeletePart.Name = "buttonModifyProductDeletePart";
            this.buttonModifyProductDeletePart.Size = new System.Drawing.Size(63, 29);
            this.buttonModifyProductDeletePart.TabIndex = 39;
            this.buttonModifyProductDeletePart.Text = "Delete";
            this.buttonModifyProductDeletePart.UseVisualStyleBackColor = true;
            this.buttonModifyProductDeletePart.Click += new System.EventHandler(this.buttonModifyProductDeletePart_Click);
            // 
            // buttonModifyProductAddPart
            // 
            this.buttonModifyProductAddPart.Location = new System.Drawing.Point(529, 217);
            this.buttonModifyProductAddPart.Name = "buttonModifyProductAddPart";
            this.buttonModifyProductAddPart.Size = new System.Drawing.Size(51, 29);
            this.buttonModifyProductAddPart.TabIndex = 38;
            this.buttonModifyProductAddPart.Text = "Add";
            this.buttonModifyProductAddPart.UseVisualStyleBackColor = true;
            this.buttonModifyProductAddPart.Click += new System.EventHandler(this.buttonModifyProductAddPart_Click);
            // 
            // labelAddProductPAWTP
            // 
            this.labelAddProductPAWTP.AutoSize = true;
            this.labelAddProductPAWTP.Location = new System.Drawing.Point(28, 269);
            this.labelAddProductPAWTP.Name = "labelAddProductPAWTP";
            this.labelAddProductPAWTP.Size = new System.Drawing.Size(219, 16);
            this.labelAddProductPAWTP.TabIndex = 37;
            this.labelAddProductPAWTP.Text = "Parts Associated With This Product:";
            // 
            // labelAddPartACP
            // 
            this.labelAddPartACP.AutoSize = true;
            this.labelAddPartACP.Location = new System.Drawing.Point(28, 40);
            this.labelAddPartACP.Name = "labelAddPartACP";
            this.labelAddPartACP.Size = new System.Drawing.Size(124, 16);
            this.labelAddPartACP.TabIndex = 36;
            this.labelAddPartACP.Text = "All Candidate Parts:";
            // 
            // modifyProductAssociatedPartsDataGridView
            // 
            this.modifyProductAssociatedPartsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modifyProductAssociatedPartsDataGridView.Location = new System.Drawing.Point(28, 288);
            this.modifyProductAssociatedPartsDataGridView.Name = "modifyProductAssociatedPartsDataGridView";
            this.modifyProductAssociatedPartsDataGridView.RowHeadersWidth = 51;
            this.modifyProductAssociatedPartsDataGridView.RowTemplate.Height = 24;
            this.modifyProductAssociatedPartsDataGridView.Size = new System.Drawing.Size(483, 218);
            this.modifyProductAssociatedPartsDataGridView.TabIndex = 35;
            // 
            // modifyProductAllCandidatePartsDataGridView
            // 
            this.modifyProductAllCandidatePartsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modifyProductAllCandidatePartsDataGridView.Location = new System.Drawing.Point(28, 59);
            this.modifyProductAllCandidatePartsDataGridView.Name = "modifyProductAllCandidatePartsDataGridView";
            this.modifyProductAllCandidatePartsDataGridView.RowHeadersWidth = 51;
            this.modifyProductAllCandidatePartsDataGridView.RowTemplate.Height = 24;
            this.modifyProductAllCandidatePartsDataGridView.Size = new System.Drawing.Size(483, 188);
            this.modifyProductAllCandidatePartsDataGridView.TabIndex = 34;
            // 
            // textBoxModifyProductMax
            // 
            this.textBoxModifyProductMax.Location = new System.Drawing.Point(974, 358);
            this.textBoxModifyProductMax.Name = "textBoxModifyProductMax";
            this.textBoxModifyProductMax.Size = new System.Drawing.Size(38, 22);
            this.textBoxModifyProductMax.TabIndex = 33;
            // 
            // textBoxModifyProductMin
            // 
            this.textBoxModifyProductMin.Location = new System.Drawing.Point(868, 361);
            this.textBoxModifyProductMin.Name = "textBoxModifyProductMin";
            this.textBoxModifyProductMin.Size = new System.Drawing.Size(35, 22);
            this.textBoxModifyProductMin.TabIndex = 32;
            // 
            // textBoxModifyProductPrice
            // 
            this.textBoxModifyProductPrice.Location = new System.Drawing.Point(887, 304);
            this.textBoxModifyProductPrice.Name = "textBoxModifyProductPrice";
            this.textBoxModifyProductPrice.Size = new System.Drawing.Size(125, 22);
            this.textBoxModifyProductPrice.TabIndex = 31;
            // 
            // textBoxModifyProductInStock
            // 
            this.textBoxModifyProductInStock.Location = new System.Drawing.Point(903, 252);
            this.textBoxModifyProductInStock.Name = "textBoxModifyProductInStock";
            this.textBoxModifyProductInStock.Size = new System.Drawing.Size(125, 22);
            this.textBoxModifyProductInStock.TabIndex = 30;
            // 
            // textBoxModifyProductName
            // 
            this.textBoxModifyProductName.Location = new System.Drawing.Point(887, 199);
            this.textBoxModifyProductName.Name = "textBoxModifyProductName";
            this.textBoxModifyProductName.Size = new System.Drawing.Size(125, 22);
            this.textBoxModifyProductName.TabIndex = 29;
            // 
            // textBoxModifyProductID
            // 
            this.textBoxModifyProductID.Location = new System.Drawing.Point(887, 154);
            this.textBoxModifyProductID.Name = "textBoxModifyProductID";
            this.textBoxModifyProductID.ReadOnly = true;
            this.textBoxModifyProductID.Size = new System.Drawing.Size(125, 22);
            this.textBoxModifyProductID.TabIndex = 28;
            // 
            // labelModifyProductMax
            // 
            this.labelModifyProductMax.AutoSize = true;
            this.labelModifyProductMax.Location = new System.Drawing.Point(933, 361);
            this.labelModifyProductMax.Name = "labelModifyProductMax";
            this.labelModifyProductMax.Size = new System.Drawing.Size(35, 16);
            this.labelModifyProductMax.TabIndex = 27;
            this.labelModifyProductMax.Text = "Max:";
            // 
            // labelModifyProductMin
            // 
            this.labelModifyProductMin.AutoSize = true;
            this.labelModifyProductMin.Location = new System.Drawing.Point(830, 361);
            this.labelModifyProductMin.Name = "labelModifyProductMin";
            this.labelModifyProductMin.Size = new System.Drawing.Size(31, 16);
            this.labelModifyProductMin.TabIndex = 26;
            this.labelModifyProductMin.Text = "Min:";
            // 
            // labelModifyProductPrice
            // 
            this.labelModifyProductPrice.AutoSize = true;
            this.labelModifyProductPrice.Location = new System.Drawing.Point(830, 304);
            this.labelModifyProductPrice.Name = "labelModifyProductPrice";
            this.labelModifyProductPrice.Size = new System.Drawing.Size(41, 16);
            this.labelModifyProductPrice.TabIndex = 25;
            this.labelModifyProductPrice.Text = "Price:";
            // 
            // labelModifyProductInStock
            // 
            this.labelModifyProductInStock.AutoSize = true;
            this.labelModifyProductInStock.Location = new System.Drawing.Point(830, 252);
            this.labelModifyProductInStock.Name = "labelModifyProductInStock";
            this.labelModifyProductInStock.Size = new System.Drawing.Size(57, 16);
            this.labelModifyProductInStock.TabIndex = 24;
            this.labelModifyProductInStock.Text = "In Stock:";
            // 
            // labelModifyProductName
            // 
            this.labelModifyProductName.AutoSize = true;
            this.labelModifyProductName.Location = new System.Drawing.Point(830, 199);
            this.labelModifyProductName.Name = "labelModifyProductName";
            this.labelModifyProductName.Size = new System.Drawing.Size(47, 16);
            this.labelModifyProductName.TabIndex = 23;
            this.labelModifyProductName.Text = "Name:";
            // 
            // labelModifyProductID
            // 
            this.labelModifyProductID.AutoSize = true;
            this.labelModifyProductID.Location = new System.Drawing.Point(845, 154);
            this.labelModifyProductID.Name = "labelModifyProductID";
            this.labelModifyProductID.Size = new System.Drawing.Size(23, 16);
            this.labelModifyProductID.TabIndex = 22;
            this.labelModifyProductID.Text = "ID:";
            // 
            // ModifyProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 548);
            this.Controls.Add(this.buttonModifyProductSearch);
            this.Controls.Add(this.textBoxModifyProductSearch);
            this.Controls.Add(this.buttonModifyProductCancel);
            this.Controls.Add(this.buttonModifyProductSaveProduct);
            this.Controls.Add(this.buttonModifyProductDeletePart);
            this.Controls.Add(this.buttonModifyProductAddPart);
            this.Controls.Add(this.labelAddProductPAWTP);
            this.Controls.Add(this.labelAddPartACP);
            this.Controls.Add(this.modifyProductAssociatedPartsDataGridView);
            this.Controls.Add(this.modifyProductAllCandidatePartsDataGridView);
            this.Controls.Add(this.textBoxModifyProductMax);
            this.Controls.Add(this.textBoxModifyProductMin);
            this.Controls.Add(this.textBoxModifyProductPrice);
            this.Controls.Add(this.textBoxModifyProductInStock);
            this.Controls.Add(this.textBoxModifyProductName);
            this.Controls.Add(this.textBoxModifyProductID);
            this.Controls.Add(this.labelModifyProductMax);
            this.Controls.Add(this.labelModifyProductMin);
            this.Controls.Add(this.labelModifyProductPrice);
            this.Controls.Add(this.labelModifyProductInStock);
            this.Controls.Add(this.labelModifyProductName);
            this.Controls.Add(this.labelModifyProductID);
            this.Name = "ModifyProductForm";
            this.Text = "ModifyProductForm";
            this.Load += new System.EventHandler(this.ModifyProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.modifyProductAssociatedPartsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifyProductAllCandidatePartsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonModifyProductSearch;
        private System.Windows.Forms.TextBox textBoxModifyProductSearch;
        private System.Windows.Forms.Button buttonModifyProductCancel;
        private System.Windows.Forms.Button buttonModifyProductSaveProduct;
        private System.Windows.Forms.Button buttonModifyProductDeletePart;
        private System.Windows.Forms.Button buttonModifyProductAddPart;
        private System.Windows.Forms.Label labelAddProductPAWTP;
        private System.Windows.Forms.Label labelAddPartACP;
        private System.Windows.Forms.DataGridView modifyProductAssociatedPartsDataGridView;
        private System.Windows.Forms.DataGridView modifyProductAllCandidatePartsDataGridView;
        private System.Windows.Forms.TextBox textBoxModifyProductMax;
        private System.Windows.Forms.TextBox textBoxModifyProductMin;
        private System.Windows.Forms.TextBox textBoxModifyProductPrice;
        private System.Windows.Forms.TextBox textBoxModifyProductInStock;
        private System.Windows.Forms.TextBox textBoxModifyProductName;
        private System.Windows.Forms.TextBox textBoxModifyProductID;
        private System.Windows.Forms.Label labelModifyProductMax;
        private System.Windows.Forms.Label labelModifyProductMin;
        private System.Windows.Forms.Label labelModifyProductPrice;
        private System.Windows.Forms.Label labelModifyProductInStock;
        private System.Windows.Forms.Label labelModifyProductName;
        private System.Windows.Forms.Label labelModifyProductID;
    }
}
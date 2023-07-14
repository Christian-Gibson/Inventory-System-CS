
namespace InventorySystem
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.addPartBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.productDataGridViewMain = new System.Windows.Forms.DataGridView();
            this.addProductBtn = new System.Windows.Forms.Button();
            this.partDataGridViewMain = new System.Windows.Forms.DataGridView();
            this.deleteProductBtn = new System.Windows.Forms.Button();
            this.modifyProductBtn = new System.Windows.Forms.Button();
            this.deletePartBtn = new System.Windows.Forms.Button();
            this.modifyPartBtn = new System.Windows.Forms.Button();
            this.textBoxPartSearch = new System.Windows.Forms.TextBox();
            this.searchPartBtn = new System.Windows.Forms.Button();
            this.textBoxProductSearch = new System.Windows.Forms.TextBox();
            this.searchProductBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partDataGridViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // addPartBtn
            // 
            this.addPartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addPartBtn.Location = new System.Drawing.Point(109, 303);
            this.addPartBtn.Name = "addPartBtn";
            this.addPartBtn.Size = new System.Drawing.Size(94, 29);
            this.addPartBtn.TabIndex = 0;
            this.addPartBtn.Text = "Add Part";
            this.addPartBtn.UseVisualStyleBackColor = true;
            this.addPartBtn.Click += new System.EventHandler(this.addPartBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Location = new System.Drawing.Point(1094, 507);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(77, 29);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // productDataGridViewMain
            // 
            this.productDataGridViewMain.AllowUserToAddRows = false;
            this.productDataGridViewMain.AllowUserToDeleteRows = false;
            this.productDataGridViewMain.AllowUserToResizeColumns = false;
            this.productDataGridViewMain.AllowUserToResizeRows = false;
            this.productDataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridViewMain.Location = new System.Drawing.Point(624, 12);
            this.productDataGridViewMain.MultiSelect = false;
            this.productDataGridViewMain.Name = "productDataGridViewMain";
            this.productDataGridViewMain.ReadOnly = true;
            this.productDataGridViewMain.RowHeadersWidth = 40;
            this.productDataGridViewMain.RowTemplate.Height = 24;
            this.productDataGridViewMain.Size = new System.Drawing.Size(566, 263);
            this.productDataGridViewMain.TabIndex = 2;
            // 
            // addProductBtn
            // 
            this.addProductBtn.Location = new System.Drawing.Point(744, 303);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Size = new System.Drawing.Size(94, 29);
            this.addProductBtn.TabIndex = 3;
            this.addProductBtn.Text = "Add Product";
            this.addProductBtn.UseVisualStyleBackColor = true;
            this.addProductBtn.Click += new System.EventHandler(this.addProductBtn_Click);
            // 
            // partDataGridViewMain
            // 
            this.partDataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partDataGridViewMain.Location = new System.Drawing.Point(21, 12);
            this.partDataGridViewMain.MultiSelect = false;
            this.partDataGridViewMain.Name = "partDataGridViewMain";
            this.partDataGridViewMain.ReadOnly = true;
            this.partDataGridViewMain.RowHeadersWidth = 51;
            this.partDataGridViewMain.RowTemplate.Height = 24;
            this.partDataGridViewMain.Size = new System.Drawing.Size(558, 263);
            this.partDataGridViewMain.TabIndex = 4;
            // 
            // deleteProductBtn
            // 
            this.deleteProductBtn.Location = new System.Drawing.Point(1002, 303);
            this.deleteProductBtn.Name = "deleteProductBtn";
            this.deleteProductBtn.Size = new System.Drawing.Size(109, 29);
            this.deleteProductBtn.TabIndex = 5;
            this.deleteProductBtn.Text = "Delete Product";
            this.deleteProductBtn.UseVisualStyleBackColor = true;
            this.deleteProductBtn.Click += new System.EventHandler(this.deleteProductBtn_Click);
            // 
            // modifyProductBtn
            // 
            this.modifyProductBtn.Location = new System.Drawing.Point(865, 303);
            this.modifyProductBtn.Name = "modifyProductBtn";
            this.modifyProductBtn.Size = new System.Drawing.Size(108, 29);
            this.modifyProductBtn.TabIndex = 6;
            this.modifyProductBtn.Text = "Modify Product";
            this.modifyProductBtn.UseVisualStyleBackColor = true;
            this.modifyProductBtn.Click += new System.EventHandler(this.modifyProductBtn_Click);
            // 
            // deletePartBtn
            // 
            this.deletePartBtn.Location = new System.Drawing.Point(368, 303);
            this.deletePartBtn.Name = "deletePartBtn";
            this.deletePartBtn.Size = new System.Drawing.Size(94, 29);
            this.deletePartBtn.TabIndex = 7;
            this.deletePartBtn.Text = "Delete Part";
            this.deletePartBtn.UseVisualStyleBackColor = true;
            this.deletePartBtn.Click += new System.EventHandler(this.deletePartBtn_Click);
            // 
            // modifyPartBtn
            // 
            this.modifyPartBtn.Location = new System.Drawing.Point(234, 303);
            this.modifyPartBtn.Name = "modifyPartBtn";
            this.modifyPartBtn.Size = new System.Drawing.Size(94, 29);
            this.modifyPartBtn.TabIndex = 8;
            this.modifyPartBtn.Text = "Modify Part";
            this.modifyPartBtn.UseVisualStyleBackColor = true;
            this.modifyPartBtn.Click += new System.EventHandler(this.modifyPartBtn_Click);
            // 
            // textBoxPartSearch
            // 
            this.textBoxPartSearch.Location = new System.Drawing.Point(127, 413);
            this.textBoxPartSearch.Name = "textBoxPartSearch";
            this.textBoxPartSearch.Size = new System.Drawing.Size(201, 22);
            this.textBoxPartSearch.TabIndex = 9;
            // 
            // searchPartBtn
            // 
            this.searchPartBtn.Location = new System.Drawing.Point(348, 413);
            this.searchPartBtn.Name = "searchPartBtn";
            this.searchPartBtn.Size = new System.Drawing.Size(94, 22);
            this.searchPartBtn.TabIndex = 10;
            this.searchPartBtn.Text = "Search Part";
            this.searchPartBtn.UseVisualStyleBackColor = true;
            this.searchPartBtn.Click += new System.EventHandler(this.searchPartBtn_Click);
            // 
            // textBoxProductSearch
            // 
            this.textBoxProductSearch.Location = new System.Drawing.Point(708, 413);
            this.textBoxProductSearch.Name = "textBoxProductSearch";
            this.textBoxProductSearch.Size = new System.Drawing.Size(201, 22);
            this.textBoxProductSearch.TabIndex = 11;
            // 
            // searchProductBtn
            // 
            this.searchProductBtn.Location = new System.Drawing.Point(915, 413);
            this.searchProductBtn.Name = "searchProductBtn";
            this.searchProductBtn.Size = new System.Drawing.Size(113, 22);
            this.searchProductBtn.TabIndex = 12;
            this.searchProductBtn.Text = "Search Product";
            this.searchProductBtn.UseVisualStyleBackColor = true;
            this.searchProductBtn.Click += new System.EventHandler(this.searchProductBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1202, 561);
            this.Controls.Add(this.searchProductBtn);
            this.Controls.Add(this.textBoxProductSearch);
            this.Controls.Add(this.searchPartBtn);
            this.Controls.Add(this.textBoxPartSearch);
            this.Controls.Add(this.modifyPartBtn);
            this.Controls.Add(this.deletePartBtn);
            this.Controls.Add(this.modifyProductBtn);
            this.Controls.Add(this.deleteProductBtn);
            this.Controls.Add(this.partDataGridViewMain);
            this.Controls.Add(this.addProductBtn);
            this.Controls.Add(this.productDataGridViewMain);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.addPartBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Inventory Management System";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partDataGridViewMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addPartBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.DataGridView productDataGridViewMain;
        private System.Windows.Forms.Button addProductBtn;
        private System.Windows.Forms.DataGridView partDataGridViewMain;
        private System.Windows.Forms.Button deleteProductBtn;
        private System.Windows.Forms.Button modifyProductBtn;
        private System.Windows.Forms.Button deletePartBtn;
        private System.Windows.Forms.Button modifyPartBtn;
        private System.Windows.Forms.TextBox textBoxPartSearch;
        private System.Windows.Forms.Button searchPartBtn;
        private System.Windows.Forms.TextBox textBoxProductSearch;
        private System.Windows.Forms.Button searchProductBtn;
    }
}


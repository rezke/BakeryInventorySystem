namespace BakeryInventorySystem
{
    partial class MainForm
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
            this.btnInvoices = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnItems = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnInvoices
            // 
            this.btnInvoices.Location = new System.Drawing.Point(63, 29);
            this.btnInvoices.Name = "btnInvoices";
            this.btnInvoices.Size = new System.Drawing.Size(79, 52);
            this.btnInvoices.TabIndex = 1;
            this.btnInvoices.Text = "Invoices";
            this.btnInvoices.UseVisualStyleBackColor = true;
            this.btnInvoices.Click += new System.EventHandler(this.btnInvoices_Click);
            // 
            // btnSales
            // 
            this.btnSales.Location = new System.Drawing.Point(148, 29);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(79, 52);
            this.btnSales.TabIndex = 2;
            this.btnSales.Text = "Sales";
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnItems
            // 
            this.btnItems.Location = new System.Drawing.Point(233, 29);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(79, 52);
            this.btnItems.TabIndex = 3;
            this.btnItems.Text = "Items";
            this.btnItems.UseVisualStyleBackColor = true;
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(318, 29);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(79, 52);
            this.btnProducts.TabIndex = 4;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnStock
            // 
            this.btnStock.Location = new System.Drawing.Point(403, 29);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(79, 52);
            this.btnStock.TabIndex = 5;
            this.btnStock.Text = "Stock";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(488, 29);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(79, 52);
            this.btnHelp.TabIndex = 6;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Location = new System.Drawing.Point(63, 88);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(974, 364);
            this.pnlMain.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 464);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.btnItems);
            this.Controls.Add(this.btnSales);
            this.Controls.Add(this.btnInvoices);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnInvoices;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnItems;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Panel pnlMain;
    }
}


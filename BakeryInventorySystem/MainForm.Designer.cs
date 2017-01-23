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
            this.pnlInvoices = new System.Windows.Forms.Panel();
            this.pnlSales = new System.Windows.Forms.Panel();
            this.pnlIngredients = new System.Windows.Forms.Panel();
            this.pnlProducts = new System.Windows.Forms.Panel();
            this.pnlStock = new System.Windows.Forms.Panel();
            this.lblStock = new System.Windows.Forms.Label();
            this.pnlHelp = new System.Windows.Forms.Panel();
            this.lblHelp = new System.Windows.Forms.Label();
            this.lblProducts = new System.Windows.Forms.Label();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.lblSales = new System.Windows.Forms.Label();
            this.lblInvoices = new System.Windows.Forms.Label();
            this.btnInvoices = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnItems = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.pnlInvoices.SuspendLayout();
            this.pnlSales.SuspendLayout();
            this.pnlIngredients.SuspendLayout();
            this.pnlProducts.SuspendLayout();
            this.pnlStock.SuspendLayout();
            this.pnlHelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInvoices
            // 
            this.pnlInvoices.Controls.Add(this.lblInvoices);
            this.pnlInvoices.Controls.Add(this.pnlSales);
            this.pnlInvoices.Location = new System.Drawing.Point(63, 96);
            this.pnlInvoices.Name = "pnlInvoices";
            this.pnlInvoices.Size = new System.Drawing.Size(914, 335);
            this.pnlInvoices.TabIndex = 0;
            // 
            // pnlSales
            // 
            this.pnlSales.Controls.Add(this.pnlIngredients);
            this.pnlSales.Controls.Add(this.lblSales);
            this.pnlSales.Location = new System.Drawing.Point(49, 21);
            this.pnlSales.Name = "pnlSales";
            this.pnlSales.Size = new System.Drawing.Size(914, 335);
            this.pnlSales.TabIndex = 1;
            // 
            // pnlIngredients
            // 
            this.pnlIngredients.Controls.Add(this.pnlProducts);
            this.pnlIngredients.Controls.Add(this.lblIngredients);
            this.pnlIngredients.Location = new System.Drawing.Point(57, 21);
            this.pnlIngredients.Name = "pnlIngredients";
            this.pnlIngredients.Size = new System.Drawing.Size(914, 335);
            this.pnlIngredients.TabIndex = 2;
            // 
            // pnlProducts
            // 
            this.pnlProducts.Controls.Add(this.pnlStock);
            this.pnlProducts.Controls.Add(this.lblProducts);
            this.pnlProducts.Location = new System.Drawing.Point(60, 38);
            this.pnlProducts.Name = "pnlProducts";
            this.pnlProducts.Size = new System.Drawing.Size(914, 335);
            this.pnlProducts.TabIndex = 3;
            // 
            // pnlStock
            // 
            this.pnlStock.Controls.Add(this.lblStock);
            this.pnlStock.Controls.Add(this.pnlHelp);
            this.pnlStock.Location = new System.Drawing.Point(110, 38);
            this.pnlStock.Name = "pnlStock";
            this.pnlStock.Size = new System.Drawing.Size(914, 335);
            this.pnlStock.TabIndex = 4;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(4, 4);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(75, 31);
            this.lblStock.TabIndex = 0;
            this.lblStock.Text = "Stock";
            // 
            // pnlHelp
            // 
            this.pnlHelp.Controls.Add(this.lblHelp);
            this.pnlHelp.Location = new System.Drawing.Point(151, 51);
            this.pnlHelp.Name = "pnlHelp";
            this.pnlHelp.Size = new System.Drawing.Size(914, 335);
            this.pnlHelp.TabIndex = 5;
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelp.Location = new System.Drawing.Point(4, 4);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(66, 31);
            this.lblHelp.TabIndex = 0;
            this.lblHelp.Text = "Help";
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducts.Location = new System.Drawing.Point(4, 4);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(112, 31);
            this.lblProducts.TabIndex = 0;
            this.lblProducts.Text = "Products";
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredients.Location = new System.Drawing.Point(6, 4);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(144, 31);
            this.lblIngredients.TabIndex = 0;
            this.lblIngredients.Text = "Ingredients";
            // 
            // lblSales
            // 
            this.lblSales.AutoSize = true;
            this.lblSales.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSales.Location = new System.Drawing.Point(4, 4);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(73, 31);
            this.lblSales.TabIndex = 0;
            this.lblSales.Text = "Sales";
            // 
            // lblInvoices
            // 
            this.lblInvoices.AutoSize = true;
            this.lblInvoices.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoices.Location = new System.Drawing.Point(4, 4);
            this.lblInvoices.Name = "lblInvoices";
            this.lblInvoices.Size = new System.Drawing.Size(107, 31);
            this.lblInvoices.TabIndex = 0;
            this.lblInvoices.Text = "Invoices";
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 464);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.btnItems);
            this.Controls.Add(this.btnSales);
            this.Controls.Add(this.btnInvoices);
            this.Controls.Add(this.pnlInvoices);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlInvoices.ResumeLayout(false);
            this.pnlInvoices.PerformLayout();
            this.pnlSales.ResumeLayout(false);
            this.pnlSales.PerformLayout();
            this.pnlIngredients.ResumeLayout(false);
            this.pnlIngredients.PerformLayout();
            this.pnlProducts.ResumeLayout(false);
            this.pnlProducts.PerformLayout();
            this.pnlStock.ResumeLayout(false);
            this.pnlStock.PerformLayout();
            this.pnlHelp.ResumeLayout(false);
            this.pnlHelp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInvoices;
        private System.Windows.Forms.Panel pnlIngredients;
        private System.Windows.Forms.Panel pnlProducts;
        private System.Windows.Forms.Panel pnlStock;
        private System.Windows.Forms.Panel pnlHelp;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Label lblIngredients;
        private System.Windows.Forms.Panel pnlSales;
        private System.Windows.Forms.Label lblSales;
        private System.Windows.Forms.Label lblInvoices;
        private System.Windows.Forms.Button btnInvoices;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnItems;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnHelp;
    }
}


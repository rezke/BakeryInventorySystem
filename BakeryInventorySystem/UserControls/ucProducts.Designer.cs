namespace BakeryInventorySystem.UserControls
{
    partial class ucProducts
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label lblProducts;
            lblProducts = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblProducts
            // 
            lblProducts.AutoSize = true;
            lblProducts.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold);
            lblProducts.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblProducts.Location = new System.Drawing.Point(4, 4);
            lblProducts.Name = "lblProducts";
            lblProducts.Size = new System.Drawing.Size(98, 28);
            lblProducts.TabIndex = 0;
            lblProducts.Text = "Products";
            // 
            // ucProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(lblProducts);
            this.Name = "ucProducts";
            this.Size = new System.Drawing.Size(974, 364);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

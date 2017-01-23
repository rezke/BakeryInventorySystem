namespace BakeryInventorySystem.UserControls
{
    partial class ucItems
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
            this.lblItems = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblItems.Location = new System.Drawing.Point(4, 4);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(66, 28);
            this.lblItems.TabIndex = 0;
            this.lblItems.Text = "Items";
            // 
            // ucItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblItems);
            this.Name = "ucItems";
            this.Size = new System.Drawing.Size(974, 364);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblItems;
    }
}

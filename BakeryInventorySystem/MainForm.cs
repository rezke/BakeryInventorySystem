using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakeryInventorySystem
{
    public partial class MainForm : Form
    {        
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {            
            pnlInvoices.Visible = false;
            pnlSales.Visible = false;
            pnlProducts.Visible = false;
            pnlIngredients.Visible = false;
            pnlStock.Visible = false;
            pnlHelp.Visible = false;
       //     pnlInvoices.Show();        

        }

        private void btnInvoices_Click(object sender, EventArgs e)
        {

            pnlInvoices.Visible = true;
            pnlSales.Visible = false;
            pnlProducts.Visible = false;
            pnlIngredients.Visible = false;
            pnlStock.Visible = false;
            pnlHelp.Visible = false;
            pnlInvoices.Show();
           
        }

        private void btnSales_Click(object sender, EventArgs e)
        {

            pnlInvoices.Visible = false;
            pnlSales.Visible = true;
            pnlProducts.Visible = false;
            pnlIngredients.Visible = false;
            pnlStock.Visible = false;
            pnlHelp.Visible = false;
            pnlSales.Show();
        }

        private void btnItems_Click(object sender, EventArgs e)
        {       
            pnlSales.Visible = false;
            pnlProducts.Visible = false;
            pnlIngredients.Visible = true;
            pnlStock.Visible = false;
            pnlHelp.Visible = false;
            pnlIngredients.Show();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {

            pnlSales.Visible = false;
            pnlProducts.Visible = true;
            pnlIngredients.Visible = false;
            pnlStock.Visible = false;
            pnlHelp.Visible = false;
            pnlProducts.Show();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {

            pnlSales.Visible = false;
            pnlProducts.Visible = false;
            pnlIngredients.Visible = false;
            pnlStock.Visible = true;
            pnlHelp.Visible = false;
            pnlStock.Show();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {

            pnlSales.Visible = false;
            pnlProducts.Visible = false;
            pnlIngredients.Visible = false;
            pnlStock.Visible = false;
            pnlHelp.Visible = true;
            pnlHelp.Show(); 
        }
    }
}

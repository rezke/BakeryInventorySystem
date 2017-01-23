using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BakeryInventorySystem.UserControls;

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
          

        }

        private void btnInvoices_Click(object sender, EventArgs e)
        {
            if (!pnlMain.Controls.Contains(ucInvoices.Instance))
            {
                pnlMain.Controls.Add(ucInvoices.Instance);
                ucInvoices.Instance.Dock = DockStyle.Fill;
                ucInvoices.Instance.BringToFront();
            }
            else
                ucInvoices.Instance.BringToFront();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            if (!pnlMain.Controls.Contains(ucSales.Instance))
            {
                pnlMain.Controls.Add(ucSales.Instance);
                ucSales.Instance.Dock = DockStyle.Fill;
                ucSales.Instance.BringToFront();
            }
            else
                ucSales.Instance.BringToFront();

        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            if (!pnlMain.Controls.Contains(ucItems.Instance))
            {
                pnlMain.Controls.Add(ucItems.Instance);
                ucItems.Instance.Dock = DockStyle.Fill;
                ucItems.Instance.BringToFront();
            }
            else
                ucItems.Instance.BringToFront();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            if (!pnlMain.Controls.Contains(ucProducts.Instance))
            {
                pnlMain.Controls.Add(ucProducts.Instance);
                ucProducts.Instance.Dock = DockStyle.Fill;
                ucProducts.Instance.BringToFront();
            }
            else
                ucProducts.Instance.BringToFront();

        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            if (!pnlMain.Controls.Contains(ucStock.Instance))
            {
                pnlMain.Controls.Add(ucStock.Instance);
                ucStock.Instance.Dock = DockStyle.Fill;
                ucStock.Instance.BringToFront();
            }
            else
                ucInvoices.Instance.BringToFront();

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            if (!pnlMain.Controls.Contains(ucHelp.Instance))
            {
                pnlMain.Controls.Add(ucHelp.Instance);
                ucHelp.Instance.Dock = DockStyle.Fill;
                ucHelp.Instance.BringToFront();
            }
            else
                ucHelp.Instance.BringToFront();

        }
    }
}

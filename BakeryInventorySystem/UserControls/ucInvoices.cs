using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakeryInventorySystem.UserControls
{
    public partial class ucInvoices : UserControl
    {
        private static ucInvoices _instance;
        public static ucInvoices Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucInvoices();
                return _instance;
            }
        }

        public ucInvoices()
        {
            InitializeComponent();
        }
    }
}

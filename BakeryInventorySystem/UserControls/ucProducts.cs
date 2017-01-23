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
    public partial class ucProducts : UserControl
    {
        private static ucProducts _instance;
        public static ucProducts Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucProducts();
                return _instance;
            }
        }

        public ucProducts()
        {
            InitializeComponent();
        }
    }
}

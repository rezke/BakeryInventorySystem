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
    public partial class ucStock : UserControl
    {
        private static ucStock _instance;
        public static ucStock Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucStock();
                return _instance;
            }
        }

        public ucStock()
        {
            InitializeComponent();
        }

        private void lblStock_Click(object sender, EventArgs e)
        {

        }
    }
}

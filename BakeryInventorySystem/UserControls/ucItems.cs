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
    public partial class ucItems : UserControl
    {
        private static ucItems _instance;
        public static ucItems Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucItems();
                return _instance;
            }
        }

        public ucItems()
        {
            InitializeComponent();
        }
    }
}

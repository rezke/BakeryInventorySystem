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
    public partial class ucHelp : UserControl
    {
        private static ucHelp _instance;
        public static ucHelp Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucHelp();
                return _instance;
            }
        }
        public ucHelp()
        {
            InitializeComponent();
        }
    }
}

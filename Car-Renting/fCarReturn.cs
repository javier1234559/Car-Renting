using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Renting
{
    public partial class fCarReturn : Form
    {
        private fNavigation currentForm;
        public fCarReturn()
        {
            InitializeComponent();
        }
        public fCarReturn(fNavigation currentform)
        {
            InitializeComponent();
            this.currentForm = currentform;
        }

        private void btnDetailContact_Click(object sender, EventArgs e)
        {

        }
    }
}

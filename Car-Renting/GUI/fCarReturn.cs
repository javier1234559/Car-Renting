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

        public fCarReturn()
        {
            InitializeComponent();
        }

        private void btnDetailContact_Click(object sender, EventArgs e)
        {

        }

        private void btnNavCarReturn_Click(object sender, EventArgs e)
        {
            fNavigation form = fNavigation.getInstance();
            if (form != null)
            {
                fSubmitCarReturn f = new fSubmitCarReturn();
                f.ShowDialog();
            }
        }

        private void fCarReturn_Load(object sender, EventArgs e)
        {

        }
    }
}

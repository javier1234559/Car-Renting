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
    public partial class fRent : Form
    {
        private fNavigation currentForm;

        public fRent()
        {
            InitializeComponent();
        }
        public fRent(fNavigation currentForm)
        {
            InitializeComponent();
            this.currentForm=currentForm;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            fRentSubmit f = new fRentSubmit(this.currentForm);
            f.Show();
        }
    }
}

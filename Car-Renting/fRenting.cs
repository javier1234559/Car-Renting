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
    public partial class fRenting : Form
    {
        private Rent rent; 
        private CarDAO cardao = new CarDAO();
        private fNavigation currentForm;
        public fRenting()
        {
            InitializeComponent();

        }
      
        public fRenting(fNavigation currentForm)
        {
            InitializeComponent();
            this.currentForm = currentForm;
        }
        public fRenting(fNavigation currentForm,Rent rent)
        {
            InitializeComponent();
            this.currentForm = currentForm;
            this.rent = rent;
        }
        private void btnCancelRent_Click(object sender, EventArgs e)
        {
            fNavigation form = this.currentForm;

            if (form != null)
            {
                form.OpenChildForm(new fRentCancel());
                form.DisableButton();
                form.leftBorderBtn.Visible = false; ;
            }
        }

        private void btnNavCarReturn_Click(object sender, EventArgs e)
        {
            fNavigation form = this.currentForm;

            if (form != null)
            {
                form.OpenChildForm(new fCarReturn(currentForm));
                form.DisableButton();
                form.leftBorderBtn.Visible = false; ;
            }
        }
    }
}

using Car_Renting.UserControls;
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
    public partial class fRentSubmit : Form
    {
        private fNavigation currentForm;

        public fRentSubmit(fNavigation currentForm)
        {
            InitializeComponent();
            this.currentForm=currentForm;

        }
        public fRentSubmit()
        {
            InitializeComponent();
        }

        private void tbnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            fNavigation form = this.currentForm;

            if (form != null)
            {
                //form.panelDesktop.Controls.Add(new RentsScreen(car));
                this.Close();
                form.OpenChildForm(new fRenting(currentForm));
                form.DisableButton();
                form.leftBorderBtn.Visible = false; ;
            }

        }
    }
}

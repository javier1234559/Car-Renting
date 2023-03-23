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
        RentDAO rentsDAO = new RentDAO();
        private fNavigation currentForm;
        public fRenting()
        {
            InitializeComponent();
            ShowListRent();

        }
      
        public fRenting(fNavigation currentForm)
        {
            InitializeComponent();
            this.currentForm = currentForm;
            ShowListRent();
        }
        public fRenting(fNavigation currentForm,Rent rent)
        {
            InitializeComponent();
            this.currentForm = currentForm;
            this.rent = rent;
            ShowListRent();
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
        private void ShowListRent()
        {
            this.gvRentList.DataSource = rentsDAO.GetAllDataTable();
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

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
        RentDAO rentsDAO = new RentDAO();

        private Rent rent; 
        private CarDAO cardao = new CarDAO();

        public fRenting()
        {
            InitializeComponent();
            ShowListRent();
        }
        
        private void ShowListRent()
        {
            this.gvRentList.DataSource = rentsDAO.GetAllDataTable();
        }

        private void btnCancelRent_Click(object sender, EventArgs e)
        {
            fNavigation form = fNavigation.getInstance();

            if (form != null)
            {
                form.OpenChildForm(new fRentCancel());
            }
        }

        private void btnNavCarReturn_Click(object sender, EventArgs e)
        {
            fNavigation form = fNavigation.getInstance();

            if (form != null)
            {
                form.OpenChildForm(new fCarReturn());
            }
        }
    }
}

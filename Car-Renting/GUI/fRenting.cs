using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
            this.gvRentList.DataSource = rentsDAO.GetAllDataTableTwoStates(Contraint.STATE_PEDDING,Contraint.STATE_RENTING);
        }

        private void AutoCountDown(DateTime start, DateTime end)
        {
            //DateTime start = datepkbegin.Value;
            //DateTime end = datepkend.Value;
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

        private void btnNavRent_Click(object sender, EventArgs e)
        {
            fNavigation form = fNavigation.getInstance();

            if (form != null)
            {
                form.OpenChildForm(new fRent());
            }
        }

        private void gvRentList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gvRentList.Rows[e.RowIndex];
                
                lbNameCar.Text = row.Cells["CarName"].Value.ToString();
                lbBrand.Text = row.Cells["Name"].Value.ToString();
                lbCategory.Text = row.Cells["CategoryName"].Value.ToString();
                lbNumbePlate.Text = row.Cells["NumberPlate"].Value.ToString();
                lbStatus.Text = row.Cells["State"].Value.ToString();
                string nameImage = row.Cells["ImageCar"].Value.ToString();
                string imagePath = Upload.GetFullImgPath(nameImage);
                if (File.Exists(imagePath))
                {
                    ImageCar.ImageLocation = imagePath;
                }
            }
        }
    }
}

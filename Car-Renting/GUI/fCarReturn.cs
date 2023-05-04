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

namespace Car_Renting
{
    public partial class fCarReturn : Form
    {
        RentDAO rentsDAO = new RentDAO();

        public fCarReturn()
        {
            InitializeComponent();
            ShowListRent();
        }

        private void ShowListRent()
        {
            this.gvCarReturn.DataSource = rentsDAO.GetAllDataTableByState(Contraint.STATE_WAITING);
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

        private void gvCarReturn_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gvCarReturn.Rows[e.RowIndex];

                lbNameCar.Text = row.Cells["CarName"].Value.ToString();
                lbBrand.Text = row.Cells["Name"].Value.ToString();
                lbCategory.Text = row.Cells["CategoryName"].Value.ToString();
                lbNumbePlate.Text = row.Cells["NumberPlate"].Value.ToString();
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

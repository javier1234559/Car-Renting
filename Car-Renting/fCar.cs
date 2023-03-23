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
    public partial class fCar : Form
    {
        private fNavigation currentForm;
        CarDAO carDao = new CarDAO();
        Car car = new Car();

        public fCar(fNavigation currentForm)
        {
            InitializeComponent();
            loadDataCar();
            this.currentForm=currentForm;
        }

        private void loadDataCar()
        {
            this.gvCars.DataSource = carDao.GetAllDataTable();
        }

        private void gvCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gvCars.Rows[e.RowIndex];
                car.CarId = (int)row.Cells["CarId"].Value;
                txtNameCar.Text = row.Cells["CarName"].Value.ToString();
                txtCategory.Text = row.Cells["CategoryName"].Value.ToString();
                txtBrand.Text = row.Cells["Brand"].Value.ToString();
                txtPricePerDay.Text = row.Cells["PricePerDay"].Value.ToString();
                txtSeat.Text = row.Cells["Seats"].Value.ToString();
                txtDescription.Text = row.Cells["Description"].Value.ToString();
                string imagePath = gvCars.CurrentRow.Cells["ImageCar"].Value.ToString();
                Image image = Image.FromFile(imagePath);
                ImageCar.Image = image;
            }
        }

        private void btnRentFromCars_Click(object sender, EventArgs e)
        {
            if(car.CarId == 0 )
            {
                MessageBox.Show("Vui long nhap thong tin xe");
                return;
            }


            fNavigation form = this.currentForm;
            if (form != null)
            {
                this.Close();
                form.OpenChildForm(new fRent(currentForm,car));
                form.DisableButton();
                form.leftBorderBtn.Visible = false; ;
            }
        }
    }
}

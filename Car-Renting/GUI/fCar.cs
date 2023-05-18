using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using iText.Kernel.XMP.Impl;
using Car_Renting.DAO;

namespace Car_Renting
{
    public partial class fCar : Form
    {
        private CarDAO _carDao; 
        private Car car;

        public fCar()
        {
            _carDao = new CarDAO();
            InitializeComponent();
            LoadData();
        }

        //--------------- Handle Event ---------------- 

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchKeyword = txtSearch.Text.Trim();
            this.gvCars.DataSource = _carDao.Search(searchKeyword);
        }

        private void gvCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gvCars.Rows[e.RowIndex];
                if (String.IsNullOrEmpty(row.Cells["CarId"].Value?.ToString())) return;

                //Load data to modal car
                int idcar = (int)row.Cells["CarId"].Value;
                this.car = _carDao.GetById(idcar);

                //Load data to textbox
                txtNameCar.Text = row.Cells["CarName"].Value.ToString();
                txtCategory.Text = row.Cells["CategoryName"].Value.ToString();
                txtBrand.Text = row.Cells["Brand"].Value.ToString();
                txtPricePerDay.Text = row.Cells["PricePerDay"].Value.ToString();
                txtSeats.Text = row.Cells["Seats"].Value.ToString();
                txtNumberPlate.Text = row.Cells["NumberPlate"].Value.ToString();
                txtDescription.Text = row.Cells["Description"].Value.ToString();
                string nameImage = gvCars.CurrentRow.Cells["ImageCar"].Value.ToString();
                string imagePath = Upload.GetFullImgPath(nameImage);
                if (File.Exists(imagePath))
                {
                    ImageCar.ImageLocation = imagePath;
                }
            }
        }

        private void btnRentFromCars_Click(object sender, EventArgs e)
        {
            if (car.CarId == 0)
            {
                MessageBox.Show("Vui long nhap thong tin xe");
                return;
            }

            fNavigation form = fNavigation.getInstance();
            if (form != null)
            {
                this.Close();
                Session.Currentcar = this.car;
                form.OpenChildForm(new fRent());
                form.DisableButton();
                form.leftBorderBtn.Visible = false; ;
            }
        }

        private void ImageCar_Click(object sender, EventArgs e)
        {
            Upload.SaveImageToResources(this.ImageCar);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = txtNameCar.Text;
            string category = txtCategory.Text;
            string brand = txtBrand.Text;
            int pricePerday = Int32.Parse(txtPricePerDay.Text);
            int seat = Int32.Parse(txtSeats.Text);
            string numberPlate = txtNumberPlate.Text;
            string descript = txtDescription.Text;
            string imagecar = Upload.GetImageName(ImageCar.ImageLocation);
            Car tempCarToGetId = _carDao.GetByImageName(imagecar);
            int idCar = tempCarToGetId.CarId;

            Car updateCar = new Car(idCar, name, category, brand, seat, pricePerday,numberPlate, descript, imagecar);
            _carDao.Update(updateCar);
            MessageBox.Show("Update Car thanh cong !");
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtNameCar.Text;
            string category = txtCategory.Text;
            string brand = txtBrand.Text;
            int pricePerday = Int32.Parse(txtPricePerDay.Text);
            int seat = Int32.Parse(txtSeats.Text);
            string numberPlate = txtNumberPlate.Text;
            string descript = txtDescription.Text;
            string imagecar = Upload.GetImageName(ImageCar.ImageLocation);
            Car newCar = new Car(name, category, brand, seat , pricePerday ,numberPlate, descript, imagecar);
            _carDao.Insert(newCar);
            MessageBox.Show("Insert Car thanh cong !");
            LoadData();
        }

        //--------------- Handle Logic ---------------- 
        private void LoadData()
        {
            this.gvCars.DataSource = _carDao.GetAllDataTableAvaiable();
        }

    }
}

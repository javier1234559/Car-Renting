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
        private CarDAO carDao = new CarDAO();
        private Car car ;

        public fCar()
        {
            InitializeComponent();
            loadDataCar();
        }

        private void loadDataCar()
        {
            this.gvCars.DataSource = carDao.GetAllDataTable();
        }

        private void SearchProducts(string searchKeyword)
        {
            DataTable table = new DataTable();
            table = carDao.GetAllDataTable();
            var result = from row in table.AsEnumerable()
                         where row.Field<string>("CarName").ToLower().Contains(searchKeyword.ToLower()) || row.Field<string>("CategoryName").ToLower().Contains(searchKeyword.ToLower())
                         select row;
            this.gvCars.DataSource = result.CopyToDataTable();

        }

        private void gvCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gvCars.Rows[e.RowIndex];
                //Load data to modal car
                int idcar = (int)row.Cells["CarId"].Value;
                this.car = carDao.GetById(idcar);

                //Load data to textbox
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

            fNavigation form = fNavigation.getInstance();
            if (form != null)
            {
                this.Close();
                Session.currentcar = this.car;
                form.OpenChildForm(new fRent());
                form.DisableButton();
                form.leftBorderBtn.Visible = false; ;
            }
        }

        private void btTim_Click_1(object sender, EventArgs e)
        {

            string searchKeyword = txtTimXe.Text.Trim();
            SearchProducts(searchKeyword);
        }

        private void comboxLoaiXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            string LoaiXe = comboxLoaiXe.SelectedItem.ToString();

            // Create a binding source object to filter the data source of the DataGridView
            BindingSource bs = new BindingSource();
            bs.DataSource = gvCars.DataSource;

            // Apply a filter to the binding source based on the selected type of vehicle
            // If the user selects "All", show all vehicles
            if (LoaiXe == "All")
            {
                bs.Filter = "";
            }
            else
            {
                bs.Filter = "CategoryName = '" + LoaiXe + "'";
            }

            // Set the data source of the DataGridView to the binding source
            gvCars.DataSource = bs;
        }

        private void comboxTieuChi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboxTieuChi.SelectedItem.ToString() == "Xe được thuê nhiều")
            {
                Dictionary<int, int> carRentalCounts = new Dictionary<int, int>();

                // Lặp qua từng dòng trong datagridview
                foreach (DataGridViewRow row in gvCars.Rows)
                {
                    int carModel = (int)row.Cells["CarId"].Value;
                    int carCounts = (int)row.Cells["so_luong_thue"].Value;

                    // Tăng giá trị tương ứng của xe đó trong Dictionary


                    carRentalCounts.Add(carModel, carCounts);

                }

                // Lấy 3 xe được thuê nhiều nhất
                var top3CarModels = carRentalCounts.OrderByDescending(x => x.Value).Take(3);

            }
            if (comboxTieuChi.SelectedItem.ToString() == "Xe được được đánh giá cao")
            {

            }
        }
    }
}

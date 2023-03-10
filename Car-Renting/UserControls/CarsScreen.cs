using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Renting.UserControls
{
    public partial class CarsScreen : UserControl
    {
        CarDAO carDao = new CarDAO();
        public CarsScreen()
        {
            InitializeComponent();
            ShowListCar();
        }
        private void ShowListCar()
        {
            this.gvCars.DataSource = carDao.GetAllDataTable();
        }
        private void SearchProducts(string searchKeyword)
        {
            DataTable table =new DataTable();
            table=carDao.GetAllDataTable();
            var result = from row in table.AsEnumerable()
                         where row.Field<string>("CarName").ToLower().Contains(searchKeyword.ToLower()) || row.Field<string>("CategoryName").ToLower().Contains(searchKeyword.ToLower())
                         select row;
            this.gvCars.DataSource = result.CopyToDataTable();
            

        }

        private void btTim_Click(object sender, EventArgs e)
        {
            string searchKeyword = txtTim.Text.Trim();
            SearchProducts(searchKeyword);
        }
        

        private void gvCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = gvCars.Rows[e.RowIndex];

                txtNameCar.Text = row.Cells["CarName"].Value.ToString();
                txtCategory.Text = row.Cells["CategoryName"].Value.ToString();
                txtBrand.Text = row.Cells["Brand"].Value.ToString();
                txtPrice.Text = row.Cells["PricePerDay"].Value.ToString();
                txtDescription.Text = row.Cells["Description"].Value.ToString();
                string imagePath = (string)gvCars.CurrentRow.Cells["ImageCar"].Value;
                Image image = Image.FromFile(imagePath);
                ImageCar.Image = image;

            }
        }
    }
}

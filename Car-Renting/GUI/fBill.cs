using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Car_Renting
{
    public partial class fBill : Form
    {
        private Bill bill;
        private Rent rent;
        private Car car;
        private Client client;
        private User user;

        private BillDAO billDao = new BillDAO();
        private CarDAO carDao = new CarDAO();
        private ClientDAO clientDao = new ClientDAO();
        private RentDAO rentDao = new RentDAO();
        private UserDAO userDao = new UserDAO();

        public fBill()
        {
            InitializeComponent();
            loadData();
            if (Session.currentBill != null){
                this.bill = Session.currentBill;
                fillDataBill();
            }
        }

        private void loadData()
        {
            this.gvBills.DataSource = billDao.GetAllDataTable();
        }

        private void fillDataBill()
        {
            fillmodalBill(this.bill.BillId);
            txtNameCar.Text = car.CarName;
            txtBrand.Text = car.Brand;
            txtCategory.Text = car.CategoryName;
            txtPricePerDay.Text = car.PricePerDay.ToString();
            string imagePath = Upload.GetFullImgPath(car.ImageCar);
            if (File.Exists(imagePath))
            {
                ImageCar.ImageLocation = imagePath;
            }
        }

        private void fillmodalBill(int id)
        {
            this.bill = billDao.GetById(id);
            this.user =  userDao.GetById(bill.IdUser);
            this.rent = rentDao.GetById(bill.RentId);
            this.car = carDao.GetById(rent.CarId);
            this.client = clientDao.GetById(rent.ClientId);
            updateSession();
        }

        private void updateSession()
        {
            Session.currentBill = this.bill;

        }

        private void gvBills_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                if (e.RowIndex >= 0)
                {
                DataGridViewRow row = gvBills.Rows[e.RowIndex];

                //Load data to modal bill
                int idbill = (int)row.Cells["BillId"].Value;
                fillmodalBill(idbill);

                //Load data to textbox
                txtNameCar.Text = car.CarName;
                txtBrand.Text = car.Brand;
                txtCategory.Text = car.CategoryName;
                txtPricePerDay.Text = car.PricePerDay.ToString();
                string imagePath = Upload.GetFullImgPath(car.ImageCar);
                if (File.Exists(imagePath))
                {
                    ImageCar.ImageLocation = imagePath;
                }
            }
        }

        private void btnDetailBill_Click(object sender, EventArgs e)
        {
            fSubmitCarReturn f = new fSubmitCarReturn();
            f.ShowDialog();

        }
    }
}

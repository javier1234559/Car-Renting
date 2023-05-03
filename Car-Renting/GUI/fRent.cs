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
    public partial class fRent : Form
    {
        private CarDAO cardao = new CarDAO();
        private ClientDAO clientdao = new ClientDAO();

        //Store data in the current form
        private Car car;
        private Client client;
        private Rent rent;

        public fRent()
        {
            InitializeComponent();
            if (Session.currentcar != null)
            {
                this.car = Session.currentcar;
                fillDataCar();
            }
            if (Session.currentclient != null)
            {
                this.client = Session.currentclient;
                fillDataClient();
            }
        }

        private void fillDataClient()
        {
            txtClientName.Text = client.Name;
            txtPhone.Text = client.Phone;
            txtCMND.Text = client.CCCD;
            txtEmail.Text = client.Email;
            txtLicense.Text = client.License;
        }

        private void fillDataCar()
        {
            txtNameCar.Text = car.CarName;
            txtSeat.Text = car.Seats.ToString();
            txtCategory.Text = car.CategoryName;
            txtBrand.Text = car.Brand;
            txtPricePerDay.Text = car.PricePerDay.ToString();
            txtDescription.Text = car.Description;
            txtNumberPlate.Text = car.NumberPlate;
            string imagePath = Upload.GetFullImgPath(car.ImageCar);
            if (File.Exists(imagePath))
            {
                ImageCar.ImageLocation = imagePath;
            }
        }

        private bool handleSaveClient()
        {
            string name = txtClientName.Text;
            string phone = txtClientName.Text;
            string cmnd = txtCMND.Text;
            string email = txtEmail.Text;
            string lisence = txtLicense.Text;
            Client temp = new Client(name, phone, cmnd, email, lisence);

            if (this.clientdao.FindIDClientByCmnd(temp.CCCD) != null)
            {
                if (Session.currentclient != null && Session.currentclient.CCCD == temp.CCCD)
                {
                    this.client = Session.currentclient;
                    return false;
                }
                else
                {
                    MessageBox.Show("Người dùng này đã tồn tại , vui lòng tìm kiếm ở bảng Client");
                }

                return true;
            }
            else
            {
                this.client = temp;
                return false;
            }

        }

        private void saveDataToSession()
        {
            Session.currentcar = this.car;
            Session.currentclient= this.client;
            Session.currentrent = this.rent;
        }

        private void handleSaveRent()
        {
            DateTime start = datepkbegin.Value;
            DateTime end = datepkend.Value;
            string descriptionRent = txtdescriptionRent.Text;
            this.rent  = new Rent(car.CarId, start, end, descriptionRent);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (this.car == null) return;

            //handle save data when press submit
            if (handleSaveClient()) return;

            handleSaveRent();
            saveDataToSession();
            fRentSubmit f = new fRentSubmit();
            f.Show();
        }
    }
}

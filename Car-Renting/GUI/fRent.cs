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
            int deposit = CalculateDeposit();
            string descriptionRent = txtdescriptionRent.Text;
            this.rent = new Rent(car.CarId, start, end, deposit, descriptionRent);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (this.car == null) return;

            if(String.IsNullOrEmpty(txtDeposit.Text))
            {
                MessageBox.Show("Hay chon ngay thue !!");
                return;
            }

            //handle save data when press submit
            if (handleSaveClient()) return;

            handleSaveRent();
            saveDataToSession();
            fRentSubmit f = new fRentSubmit();
            f.Show();
        }

        private void datepkbegin_ValueChanged(object sender, EventArgs e)
        {
            DateTime end = datepkend.Value;
            if (datepkbegin.Value >= end.AddDays(-1))
            {
                datepkbegin.ValueChanged -= datepkbegin_ValueChanged;
                MessageBox.Show("The start date must be at least 1 day earlier than the end date.", "Invalid date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                datepkbegin.Value = DateTime.Now;
                datepkbegin.ValueChanged += datepkbegin_ValueChanged;
            }
            else
            {
                CalculateDeposit();
            }
        }

        private void datepkend_ValueChanged(object sender, EventArgs e)
        {
            DateTime start = datepkbegin.Value;
            if (datepkend.Value <= start.AddDays(1))
            {
                datepkend.ValueChanged -= datepkend_ValueChanged;
                MessageBox.Show("The end date must be at least 1 day later than the start date.", "Invalid date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                datepkend.Value = DateTime.Now;
                datepkend.ValueChanged += datepkend_ValueChanged;
            }
            else
            {
                CalculateDeposit();
            }
        }

        private int CalculateDeposit()
        {
            DateTime start = datepkbegin.Value;
            DateTime end = datepkend.Value;
            int pricePerDay = Int32.Parse(txtPricePerDay.Text);
            int rentalDuration = (int)(end - start).TotalDays;
            int deposit = (int)(pricePerDay * rentalDuration * 0.3); //30% of the total rental cost
            txtDeposit.Text = $"{deposit}";
            return deposit;
        }
    }
}

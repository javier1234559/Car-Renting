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
    public partial class fRent : Form
    {
        private Rent rent;
        private Client client;
        private Car car;
        private CarDAO cardao = new CarDAO();
        private fNavigation currentForm;

        public fRent()
        {
            InitializeComponent();
        }
        public fRent(fNavigation currentForm)
        {
            InitializeComponent();
            this.currentForm=currentForm;
            if (this.car != null) fillDataCar();

        }
        public fRent(fNavigation currentForm,Car car)
        {
            InitializeComponent();
            this.currentForm=currentForm;
            this.car = car;
            if (this.car != null) fillDataCar();
        }
        private void fillDataCar()
        {
            int id = this.car.CarId;
            this.car = this.cardao.GetById(id);
            txtNameCar.Text = car.CarName;
            txtSeat.Text = car.Seats.ToString();
            txtCategory.Text = car.CategoryName;
            txtBrand.Text = car.Brand;
            txtPricePerDay.Text =  car.PricePerDay.ToString();
            txtDescription.Text =  car.Description;
            Image image = Image.FromFile(car.ImageCar);
            ImageCar.Image = image;
        }
        

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (this.car == null) return;
            string name = txtClientName.Text;
            string phone = txtClientName.Text;
            string cmnd = txtCMND.Text;
            string email = txtEmail.Text;
            string lisence = txtLicense.Text;
            this.client = new Client(name, phone, cmnd, email, lisence);

            DateTime start = datepkbegin.Value;
            DateTime end = datepkend.Value;
            string descriptionRent = txtdescriptionRent.Text;
            this.rent = new Rent(this.car.CarId, start, end, descriptionRent);
            this.rent.Client = this.client;
            this.rent.Car = this.car;

            fRentSubmit f = new fRentSubmit(this.currentForm,rent);
            f.Show();
        }
    }
}

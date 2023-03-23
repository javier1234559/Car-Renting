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
    public partial class RentsScreen : UserControl
    {

        private Car car;
        private Client client;
        private Rent rent;

        private CarDAO cardao = new CarDAO();


        public RentsScreen()
        {
            InitializeComponent();
        }

        public RentsScreen(Car carParam)
        {
            InitializeComponent();
            car = carParam;
            FillDataCar();
        }

        public void FillDataCar()
        {
            if (this.car == null) return;
            int id = this.car.CarId;
            this.car = this.cardao.GetById(id);
            txtCarId.Value = car.CarId;
            txtNameCar.Text = car.CarName;
            //txtCategory.Text =car.Ca;
            txtBrand.Text = car.Brand;
            txtPricePerDay.Text =  car.PricePerDay.ToString();
            txtDescription.Text =  car.Description;
            //string imagePath = (string)gvCars.CurrentRow.Cells["ImageCar"].Value;
            Image image = Image.FromFile("D:\\Desktop\\HondaCivic.png");
            ImageCar.Image = image;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            client.ClientId = Int32.Parse(txtClientId.Text.ToString());
            client.Phone = txtPhone.Text.ToString();
            client.CCCD = txtCCCD.Text.ToString();
            client.Email = txtEmail.Text.ToString();


        }
    }
}

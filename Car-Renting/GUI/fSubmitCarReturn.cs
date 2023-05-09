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
    public partial class fSubmitCarReturn : Form
    {
        private CarDAO carDAO = new CarDAO();
        private ClientDAO clientDAO = new ClientDAO();
        private RentDAO rentDAO = new RentDAO();

        //Store data in the current form
        private Rent rentReturn;
        private Car car;
        private Client client;

        public fSubmitCarReturn()
        {
            InitializeComponent();
        }

        public fSubmitCarReturn(Rent rentReturn)
        {
            InitializeComponent();
            if(rentReturn != null)
            {
                this.rentReturn = rentReturn;
                this.car = carDAO.GetById(rentReturn.CarId);
                this.client = clientDAO.GetById(rentReturn.ClientId);
                LoadData();
            }
        }

        //------ Load Data -------
        private void LoadData()
        {
            //fill Client 
            txtClientName.Text = client.Name;
            txtCMND.Text = client.CCCD;
            txtEmail.Text = client.Email;
            txtPhone.Text = client.Phone;
            txtLicense.Text = client.License;
            txtDeposit.Text = rentReturn.Deposit.ToString();

            //fill Car
            txtNameCar.Text = car.CarName;
            string nameImage = car.ImageCar;
            string imagePath = Upload.GetFullImgPath(nameImage);
            if (File.Exists(imagePath))
            {
                ImageCar.ImageLocation = imagePath;
            }

            //fillRent 
            lbDayStart.Text = rentReturn.DateStart.ToString();
            lbDateEnd.Text = rentReturn.DateEnd.ToString();
            txtDescription.Text = rentReturn.DescriptionRent;
            //txtCompensationName.Text = rentReturn.CancellationReason;
            //txtCompensationDescription.Text = rentReturn.CancellationReason;
            //txtCompensation.Text = rentReturn

            //Tao them ham doi gia tri thue 
            //

        }


    }
}

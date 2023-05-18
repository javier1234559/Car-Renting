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
using Car_Renting;

namespace Car_Renting
{
    public partial class fSubmitCarReturn : Form
    {
        private CarReturnManager _carReturnManager; //This class is builded in BUS layer
        private Rent rentReturn;
        private Car car;
        private Client client;
        private Bill newbill;

        public fSubmitCarReturn()
        {
            _carReturnManager = new CarReturnManager();
            InitializeComponent();
        }

        public fSubmitCarReturn(Rent rentReturn)
        {
            _carReturnManager = new CarReturnManager();
            InitializeComponent();
            if(rentReturn != null)
            {
                this.rentReturn = rentReturn;
                this.car = _carReturnManager.GetCarById(rentReturn.CarId);
                this.client = _carReturnManager.GetClientById(rentReturn.ClientId);
                this.newbill = new Bill();
                LoadData();
            }
        }

        //--------------- Handle Event ---------------- 
        private void btnAccept_Click(object sender, EventArgs e)
        {
            //Save Rating
            string selectedValue = "";
            foreach (Control control in gpRating.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)control;
                    if (radioButton.Checked)
                    {
                        selectedValue = radioButton.Text;
                        break;
                    }
                }
            }
            int ratingValue = Int32.Parse(selectedValue);
            string feedBack = txtFeedBack.Text;
            Rating newRating = new Rating(rentReturn.RentId, car.CarId, ratingValue, feedBack, client.ClientId);

            //Save newbill
            
            newbill.RentId = this.rentReturn.RentId;
            newbill.IdUser = Session.LoginedAccount.IdUser;
            newbill.CompensationName = txtCompensationName.Text != null ? txtCompensationName.Text : "";
            newbill.Compensation = String.IsNullOrEmpty(txtCompensation.Text) != true  ? Int32.Parse(txtCompensation.Text) : 0;
            newbill.CompensationDescript = txtCompensationDescription.Text != null ? txtCompensationDescription.Text : "";
            newbill.CreateDate = DateTime.Now;
            newbill.TotalCost = Decimal.Parse(lbTotalCost.Text);


            _carReturnManager.HandleSubmit(this.newbill, newRating);
            MessageBox.Show("Done!");

            this.Close();
            fBillDashBoard f = new fBillDashBoard();
            f.ShowDialog();

        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            if (txtDiscountCode.Text.Length == 4)
            {
                string code = txtDiscountCode.Text; 
                decimal beforeDiscount = Decimal.Parse(lbTotalCost.Text);
                decimal afterDiscount= _carReturnManager.HandleDiscount(this.client.ClientId, code, beforeDiscount);
                if(beforeDiscount > afterDiscount)
                {
                    MessageBox.Show("Discount successfully !");
                    this.newbill.DiscountCode = code;
                }

                lbTotalCost.Text = $"{afterDiscount}";
            }
        }

        private void txtCompensation_TextChanged(object sender, EventArgs e)
        {
            decimal totalCost;
            if (decimal.TryParse(txtCompensation.Text, out decimal compensationValue))
            {
                totalCost = Decimal.Parse(lbTotalCost.Text) + compensationValue;
            }
            else
            {
                MessageBox.Show("Please enter the number value!");
                txtCompensation.Text = "";
                totalCost = Decimal.Parse(lbTotalCost.Text);
            }

            lbTotalCost.Text = totalCost.ToString();

        }

        //--------------- Handle Logic ---------------- 

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

            //fill Bill
            DateTime now = DateTime.Now;
            DateTime start = rentReturn.DateStart;
            int pricePerDay = car.PricePerDay;
            int rentalDuration = (int)(now - start).TotalDays;
            decimal TotalCost = (decimal)(pricePerDay * rentalDuration);
            string cost = $"{TotalCost}";
            lbPrice.Text = cost;
            lbTotalCost.Text = cost;
        }

    }
}

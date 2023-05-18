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
    public partial class fCarReturn : Form
    {
        private CarReturnManager _carReturnManager ; 
        private Rent rent;
        private Timer countdownTimer;

        public fCarReturn()
        {
            _carReturnManager = new CarReturnManager();
            InitializeComponent();
            ShowListRent();
            if (Session.CurrentrentCanceled != null)
            {
                this.rent = Session.CurrentrentCanceled;
            }
        }

        private void ShowListRent()
        {
            this.gvCarReturn.DataSource = _carReturnManager.LoadData();
        }

        //--------------- Handle Event ---------------- 

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchKeyword = txtSearch.Text.Trim();
            this.gvCarReturn.DataSource = _carReturnManager.SearchTwoState(searchKeyword, Contraint.STATE_PEDDING, Contraint.STATE_RENTING);
        }

        private void btnDetailContact_Click(object sender, EventArgs e)
        {
            if (this.rent == null)
            {
                MessageBox.Show("Pls select the item first !!");
                return;
            }
            fRentSubmit f = new fRentSubmit(this.rent);
            f.ShowDialog();
        }

        private void btnNavCarReturn_Click(object sender, EventArgs e)
        {
            fSubmitCarReturn f = new fSubmitCarReturn(this.rent);
            f.ShowDialog();
        }

        private void gvCarReturn_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gvCarReturn.Rows[e.RowIndex];
                if (String.IsNullOrEmpty(row.Cells["RentId"].Value?.ToString())) return;

                this.rent = _carReturnManager.GetRentById(Int32.Parse(row.Cells["RentId"].Value.ToString()));
                lbNameCar.Text = row.Cells["CarName"].Value.ToString();
                lbBrand.Text = row.Cells["Name"].Value.ToString();
                lbCategory.Text = row.Cells["CategoryName"].Value.ToString();
                lbNumbePlate.Text = row.Cells["NumberPlate"].Value.ToString();
                string nameImage = row.Cells["ImageCar"].Value.ToString();
                string imagePath = Upload.GetFullImgPath(nameImage);
                if (File.Exists(imagePath))
                {
                    ImageCar.ImageLocation = imagePath;
                }
                StartCountdown(this.rent.DateEnd);
            }
        }
        
        //--------------- Handle Logic ---------------- 

        private void StartCountdown(DateTime end)
        {
            if (countdownTimer != null)
            {
                countdownTimer.Stop();
            }

            countdownTimer = new Timer();
            countdownTimer.Interval = 1000; // 1 second
            countdownTimer.Tick += (sender, e) => {
                DateTime currentTime = DateTime.Now;
                TimeSpan remainingTime = currentTime.Subtract(end);

                double totalSeconds = remainingTime.TotalSeconds;
                int hours = (int)(totalSeconds / 3600);
                int minutes = (int)((totalSeconds % 3600) / 60);
                int seconds = (int)(totalSeconds % 60);
                lbOverTime.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", hours, minutes, seconds);
                
            };

            countdownTimer.Start();
        }

    }
}

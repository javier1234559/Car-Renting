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
using static System.Windows.Forms.AxHost;

namespace Car_Renting
{
    public partial class fRenting : Form
    {
        //DAO
        private RentDAO _rentsDAO;
        private Rent rent;
        private Timer countdownTimer;

        public fRenting()
        {
            _rentsDAO = new RentDAO();
            InitializeComponent();
            ShowListRent();
            UpdateStateRenting();
        }
        
        private void ShowListRent()
        {
            this.gvRentList.DataSource = _rentsDAO.GetAllDataTableTwoStates(Contraint.STATE_PEDDING,Contraint.STATE_RENTING);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchKeyword = txtSearch.Text.Trim();
            this.gvRentList.DataSource = _rentsDAO.SearchTwoState(searchKeyword, Contraint.STATE_PEDDING, Contraint.STATE_RENTING);
        }

        private void btnCancelRent_Click(object sender, EventArgs e)
        {
            string message = "Are you sure to cancel this renting ?";
            string title = "Cancel Renting";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.No)
            {
                return ;
            }

            fNavigation form = fNavigation.getInstance();
            Session.CurrentrentCanceled = this.rent;
            _rentsDAO.ChangeState(this.rent.RentId, Contraint.STATE_CANCLED);
            if (form != null)
            {

                form.OpenChildForm(new fRentCancel());
            }
        }

        private void btnNavCarReturn_Click(object sender, EventArgs e)
        {
            fNavigation form = fNavigation.getInstance();

            if (form != null)
            {
                form.OpenChildForm(new fCarReturn());
                Session.CurrentrentCanceled = this.rent;
            }
        }

        private void btnNavRent_Click(object sender, EventArgs e)
        {
            fNavigation form = fNavigation.getInstance();

            if (form != null)
            {
                form.OpenChildForm(new fRent());
            }
        }

        private void gvRentList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gvRentList.Rows[e.RowIndex];
                if (String.IsNullOrEmpty(row.Cells["RentId"].Value?.ToString())) return;

                this.rent = _rentsDAO.GetById(Int32.Parse(row.Cells["RentId"].Value.ToString()));
                lbNameCar.Text = row.Cells["CarName"].Value.ToString();
                lbBrand.Text = row.Cells["Name"].Value.ToString();
                lbCategory.Text = row.Cells["CategoryName"].Value.ToString();
                lbNumbePlate.Text = row.Cells["NumberPlate"].Value.ToString();
                lbStatus.Text = row.Cells["State"].Value.ToString();
                string nameImage = row.Cells["ImageCar"].Value.ToString();
                string imagePath = Upload.GetFullImgPath(nameImage);
                if (File.Exists(imagePath))
                {
                    ImageCar.ImageLocation = imagePath;
                }
                StartCountdown(this.rent.DateStart, this.rent.DateEnd);

            }

        }

        private void StartCountdown(DateTime start, DateTime end)
        {
            if (countdownTimer != null)
            {
                countdownTimer.Stop();
            }

            countdownTimer = new Timer();
            countdownTimer.Interval = 1000; // 1 second
            countdownTimer.Tick += (sender, e) => {
                DateTime currentTime = DateTime.Now;

                int startCompare = DateTime.Compare(currentTime, start);
                int endCompare = DateTime.Compare(currentTime, end);

                if (startCompare < 0)
                {
                    TimeSpan remainingTime = end.Subtract(start);
                    double totalSeconds = remainingTime.TotalSeconds;
                    int hours = (int)(totalSeconds / 3600);
                    int minutes = (int)((totalSeconds % 3600) / 60);
                    int seconds = (int)(totalSeconds % 60);
                    lbTimeRemain.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", hours, minutes, seconds);

                }
                else if (startCompare >= 0 && endCompare < 0)
                {
                    TimeSpan timeDiff = currentTime - start; // When currentTime is later than start about 2 second then Update
                    if (timeDiff.TotalSeconds <= 2)
                    {
                        UpdateStateRenting();
                        lbStatus.Text = Contraint.STATE_RENTING;
                    }


                    TimeSpan remainingTime = end.Subtract(currentTime);
                    double totalSeconds = remainingTime.TotalSeconds;
                    int hours = (int)(totalSeconds / 3600);
                    int minutes = (int)((totalSeconds % 3600) / 60);
                    int seconds = (int)(totalSeconds % 60);
                    lbTimeRemain.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", hours, minutes, seconds);

                }
                else
                {
                    lbTimeRemain.Text = "00:00:00";
                    UpdateStateRenting();
                    countdownTimer.Stop();
                }
            };

            countdownTimer.Start();
        }

        private void UpdateStateRenting()
        {
            DateTime currentTime = DateTime.Now;

            DataTable rentsPeddingList = _rentsDAO.GetAllDataTableByState(Contraint.STATE_PEDDING);

            // Loop through each rent and check if it's time to update the state
            foreach (DataRow rent in rentsPeddingList.Rows)
            {
                DateTime endDate = (DateTime)rent["DateStart"];

                if (currentTime >= endDate)
                {
                    int rentId = Int32.Parse(rent["RentId"].ToString());
                    _rentsDAO.ChangeState(rentId, Contraint.STATE_RENTING);
                }
            }
            DataTable rentsRentingList = _rentsDAO.GetAllDataTableByState(Contraint.STATE_RENTING);

            // Loop through each rent and check if it's time to update the state
            foreach (DataRow rent in rentsRentingList.Rows)
            {
                DateTime endDate = (DateTime)rent["DateEnd"];

                if (currentTime >= endDate)
                {
                    int rentId = Int32.Parse(rent["RentId"].ToString());
                    _rentsDAO.ChangeState(rentId, Contraint.STATE_WAITING);
                }
            }

            ShowListRent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UpdateStateRenting();
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

    }
}

using Account_Renting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Markup;

namespace Car_Renting
{
    public partial class fDashboardUser : Form
    {
        private int revernueByDay;
        private int revernueByMonth;
        private int revernueByYear;
        private Account account;
        private User user;
        private UserDAO _userDAO;
        private AccountDAO _accountDAO;

        public fDashboardUser()
        {
            _userDAO = new UserDAO();
            _accountDAO  = new AccountDAO();
            InitializeComponent();
            loadData();
            if (Session.LoginedAccount != null)
                this.account = Session.LoginedAccount;
            if (Session.CurrentuserAtDashboard != null)
            {
                this.user = Session.CurrentuserAtDashboard;
                fillDataUser();
                loadDataChart();
            }
        }

        //--------------- Handle Event ---------------- 

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchKeyword = txtSearch.Text.Trim();
            this.gvUser.DataSource = _accountDAO.SearchFullDataUser(searchKeyword);
        }

        private void gvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gvUser.Rows[e.RowIndex];
                if (String.IsNullOrEmpty(row.Cells["IdUser"].Value?.ToString())) return;
                //Load data to modal car
                int iduser = (int)row.Cells["IdUser"].Value;
                int idaccount = (int)row.Cells["AccID"].Value;
                fillmodalUser(iduser, idaccount);
                loadDataChart();
                //Load data to textbox
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtPhone.Text = row.Cells["Phone"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtPassword.Text =row.Cells["Password"].Value.ToString();

            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            int totalRevenue = 0;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                if(phone.Length < 10)
                {
                    MessageBox.Show("Vui long nhap du 10 so cua so dien thoai");
                    return;
                }
                if(_userDAO.GetByPhone(phone) != null) {
                    MessageBox.Show("Vui Long khong nhap trung thong tin");
                    return;
                }

                MessageBox.Show("Vui Long nhap thong tin day du");
                return;
            }

            User newuser = new User(name, phone, address, totalRevenue);
            int idnewuser = _userDAO.Insert(newuser);
            Account newaccount = new Account(email,password,idnewuser);
            int idnewaccount = _accountDAO.Insert(newaccount);
            MessageBox.Show( $"Create new User successfully User Name is : {newuser.Name} !");
            loadData();
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (this.account == null || this.user == null)
            {
                MessageBox.Show("Please choose user want to update");
                return;
            }
                
            Account updateaccount = this.account;
            User updateuser = this.user;

            updateaccount.Email = txtEmail.Text;
            updateaccount.Password= txtPassword.Text;
            updateuser.Name= txtName.Text;
            updateuser.Phone= txtPhone.Text;
            updateuser.Address= txtAddress.Text;
            _userDAO.Update(updateuser);
            _accountDAO.Update(updateaccount);

            MessageBox.Show("Update user successfully !");
            loadData();

        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (this.account == null || this.user == null)
            {
                MessageBox.Show("Please choose user want to delete");
                return;
            }
            Account deleteaccount = this.account;
            User deleteuser = this.user;

            _accountDAO.Delete(deleteaccount);
            _userDAO.Delete(deleteuser);

            MessageBox.Show("Delete user successfully !");
            loadData();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtPassword.Text ="";
            this.user = null;
            this.account = null;
        }

        //--------------- Handle Logic ---------------- 

        private void loadData()
        {
            this.gvUser.DataSource = _accountDAO.GetFullDataUser();
            drawDoughnutChart();
        }

        private void loadDataChart()
        {
            loadRevenue();
            drawSpline();
            //drawDoughnutChart();
        }

        private void loadRevenue()
        {
            int iduser = this.user.IdUser;
            if (iduser == 0) return;
            DateTime currentday = DateTime.Now;

            this.revernueByDay = sumRevenue(_userDAO.GetDataTableByDay(currentday, iduser));
            lbTotalRevenueDay.Text = revernueByDay.ToString();

            this.revernueByMonth = sumRevenue(_userDAO.GetDataTableByMonth(currentday, iduser));
            lbTotalRevenueMonth.Text = revernueByMonth.ToString();

            this.revernueByYear = sumRevenue(_userDAO.GetDataTableByYear(currentday, iduser));
            lbTotalRevenueYear.Text = revernueByYear.ToString();

            lbTotalRevenue.Text = this.user.TotalRevenue.ToString();
        }

        private int sumRevenue(DataTable dt)
        {
            Decimal total = 0;
            foreach (DataRow row in dt.Rows)
            {
                total += Decimal.Parse(row["TotalCost"].ToString());
            }

            return Decimal.ToInt32(total);
        }

        private void drawSpline()
        {
            chartSpline.Series[0].Points.Clear();
            Dictionary<string, int> data = GetRevenueBy5Month();
            foreach (KeyValuePair<string, int> entry in data)
            {
                string month = entry.Key;
                int revenue = entry.Value;
                chartSpline.Series[0].Points.AddXY(month, revenue);
            }

            // Set chart properties
            chartSpline.Series[0].ChartType = SeriesChartType.SplineArea;
            chartSpline.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartSpline.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chartSpline.ChartAreas[0].AxisX.Interval = 1;
        }

        private void drawDoughnutChart()
        {
            List<User> listUser = _userDAO.GetAllDateList();

            if (listUser != null)
            {
                chartDoughnut.Series.Clear();
                Series series = new Series();
                series.ChartType = SeriesChartType.Doughnut;
                int total = 0;
                foreach (User u in listUser)
                {
                    DataPoint dataPoint = new DataPoint();
                    dataPoint.Label = u.Name;
                    dataPoint.SetValueXY(u.Name, u.TotalRevenue);
                    series.Points.Add(dataPoint);
                    total += u.TotalRevenue;
                }

                foreach (DataPoint dataPoint in series.Points)
                {
                    double percentage = (double)dataPoint.YValues[0] / total * 100;
                    dataPoint.YValues[0] = percentage;
                    dataPoint.Label = $"{percentage.ToString("0.00")}%";
                    dataPoint.LegendText = dataPoint.AxisLabel;
                }
                chartDoughnut.Series.Add(series);
            }
        }

        private Dictionary<string, int> GetRevenueBy5Month()
        {
            DateTime currentday = DateTime.Now;
            int iduser = this.user.IdUser;
            Dictionary<string, int> data = new Dictionary<string, int>();

            for (int i = 5; i >= 1; i--)
            {
                DateTime month = currentday.AddMonths(-i + 1);
                int revenue = sumRevenue(_userDAO.GetDataTableByMonth(month, iduser));
                string monthStr = month.ToString("MM/yyyy");
                data.Add(monthStr, revenue);
            }
            return data;
        }

        private void fillDataUser()
        {
            txtName.Text = user.Name;
            txtPhone.Text = user.Phone;
            txtAddress.Text = user.Address;
            txtEmail.Text = account.Email;
            txtPassword.Text = account.Password;
        }

        private void fillmodalUser(int iduser, int idaccount)
        {
            this.user =  _userDAO.GetById(iduser);
            this.account =  _accountDAO.GetById(idaccount);
            updateSession();
        }

        private void updateSession()
        {
            Session.CurrentuserAtDashboard = this.user;
            Session.CurrentaccountAtDashboard = this.account;
        }


    }
}

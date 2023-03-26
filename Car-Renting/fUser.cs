using Account_Renting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Car_Renting
{
    public partial class fUser : Form
    {
        private Account account;
        private User user;
        private UserDAO userDao = new UserDAO();
        private AccountDAO accountDAO = new AccountDAO();

        public fUser()
        {
            InitializeComponent();
            loadData();
            if (Session.currentuser != null)
            {
                this.user = Session.currentuser;
                fillDataUser();
            }
        }

        private void loadData()
        {
            DataTable dt1 = userDao.GetAllDataTable();
            DataTable dt2 = accountDAO.GetAllDataTable();
            var joinedTable = from user in dt1.AsEnumerable()
                              join account in dt2.AsEnumerable() on user.Field<int>("IdUser") equals account.Field<int>("IdUser")
                              select new
                              {
                                  IdUser = user.Field<int>("IdUser"),
                                  Name = user.Field<string>("Name"),
                                  Phone = user.Field<string>("Phone"),
                                  Address = user.Field<string>("Address"),
                                  TotalRevenue = user.Field<int>("TotalRevenue"),
                                  AccID = account.Field<int>("AccID"),
                                  Email = account.Field<string>("Email"),
                                  Password = account.Field<string>("Password")
                              };

            DataTable dtResult = new DataTable();
            dtResult.Columns.Add("IdUser", typeof(int));
            dtResult.Columns.Add("Name", typeof(string));
            dtResult.Columns.Add("Phone", typeof(string));
            dtResult.Columns.Add("Address", typeof(string));
            dtResult.Columns.Add("TotalRevenue", typeof(int));
            dtResult.Columns.Add("AccID", typeof(int));
            dtResult.Columns.Add("Email", typeof(string));
            dtResult.Columns.Add("Password", typeof(string));

            foreach (var row in joinedTable)
            {
                dtResult.Rows.Add(row.IdUser, row.Name, row.Phone, row.Address, row.TotalRevenue, row.AccID, row.Email, row.Password);
            }

            this.gvUser.DataSource = dtResult;
        }

        private void fillDataUser()
        {
            txtName.Text = user.Name;
            txtPhone.Text = user.Phone;
            txtAddress.Text = user.Address;
            txtRevenue.Text = user.TotalRevenue.ToString();
        }

        private void fillmodalUser(int iduser ,int idaccount)
        {
            this.user =  userDao.GetById(iduser);
            this.account =  accountDAO.GetById(idaccount);
            updateSession();
        }

        private void updateSession()
        {
            Session.currentuser = this.user;
        }

        private void gvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gvUser.Rows[e.RowIndex];
                //Load data to modal car
                int iduser = (int)row.Cells["IdUser"].Value;
                int idaccount = (int)row.Cells["AccID"].Value;
                fillmodalUser(iduser, idaccount);

                 //Load data to textbox
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtPhone.Text = row.Cells["Phone"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();
                txtRevenue.Text = row.Cells["TotalRevenue"].ToString();
                  
            }
        }
    }
}

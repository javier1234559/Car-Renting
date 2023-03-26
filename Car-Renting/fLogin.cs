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

namespace Car_Renting
{
    public partial class fLogin : Form
    {
        AccountDAO accountdao = new AccountDAO();
        public fLogin()
        {
            InitializeComponent();
            //dien san tk mk 
            txtLogin.Text = "1@gmail.com";
            txtPassword.Text = "1";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string pass = txtPassword.Text.Trim();
            if (login == "" || pass == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin");
                return;
            }

            string query = $"SELECT * FROM Account WHERE Email = '{login}' and Password = '{pass}';";
            DataTable dt = DbConnection.Instance.getData(query);

            if (dt.Rows.Count > 0)
            {
                fNavigation f = fNavigation.getInstance();
                this.Hide();
                f.ShowDialog();
                //this.Show();
            }
            else
            {
                MessageBox.Show("Dang nhap khong thanh cong. Vui long thu lai.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có thật sự muốn thoát ?","Thông báo ",MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                e.Cancel= true;
        }
    }
}

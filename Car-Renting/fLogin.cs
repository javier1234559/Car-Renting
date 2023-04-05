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
        Account account;

        public fLogin()
        {
            InitializeComponent();
            //dien san tk mk 
            txtLogin.Text = "1@gmail.com";
            txtPassword.Text = "1";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtLogin.Text.Trim();
            string pass = txtPassword.Text.Trim();
            if (email == "" || pass == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin");
                return;
            }

            Account temp = accountdao.GetByEmailAndPass(email, pass);
            if (temp != null)
            {
                this.account = temp;
                Session.currentaccount= this.account;
                fNavigation f = fNavigation.getInstance();
                this.Hide();
                f.ShowDialog();
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

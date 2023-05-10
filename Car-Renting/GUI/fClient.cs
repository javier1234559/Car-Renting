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
    public partial class fClient : Form
    {
        private Client client;

        ClientDAO _clientDAO = new ClientDAO();

        public fClient()
        {
            InitializeComponent();
            loadDataClients();
            if (Session.Currentclient != null)
            {
                this.client = Session.Currentclient;
            }
        }

        private void loadDataClients()
        {
            this.gvClients.DataSource = _clientDAO.GetAllDataTable();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchKeyword = txtSearch.Text.Trim();
            this.gvClients.DataSource = _clientDAO.Search(searchKeyword);
        }

        private void gvClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gvClients.Rows[e.RowIndex];
                if (String.IsNullOrEmpty(row.Cells["ClientId"].Value?.ToString())) return;

                //Load data to modal car
                int idclient = (int)row.Cells["ClientId"].Value;
                this.client = _clientDAO.GetById(idclient);

                //Load data to textbox
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtPhone.Text = row.Cells["Phone"].Value.ToString();
                txtCmnd.Text = row.Cells["CCCD"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtLicence.Text = row.Cells["License"].Value.ToString();
            }
        }

        private void handleAddClient()
        {
            string clientCCCD = txtCmnd.Text;
            if (this._clientDAO.FindIDClientByCmnd(clientCCCD) != null)
            {
                MessageBox.Show("Người dùng này đã tồn tại , vui lòng không thêm trùng lặp");
                MessageBox.Show("Hãy làm mới trang và nhập lại thông tin ");
                return;
            }
            else
            {
                string name = txtName.Text;
                string phone = txtPhone.Text;
                string cmnd = txtCmnd.Text;
                string email = txtEmail.Text;
                string license = txtLicence.Text;
                Client newClient = new Client( name, phone, cmnd, email, license);
                
                _clientDAO.Insert(newClient);
            }

        }

        private void handleUpdateClient()
        {
            int id = this.client.ClientId;
            string name = txtName.Text;
            string phone = txtPhone.Text;
            string cmnd = txtCmnd.Text;
            string email = txtEmail.Text;
            string license = txtLicence.Text;
            Client updatedClient = new Client(id, name, phone, cmnd, email, license);

            if(_clientDAO.Update(updatedClient) != 0)
            {
                MessageBox.Show("Cập nhật thành công !");
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại !");
            }

        }

        private bool checkEmptyTxt()
        {
            string name = txtName.Text;
            string phone = txtPhone.Text;
            string cmnd = txtCmnd.Text;

            if(name == null  && phone == null && cmnd == null )
            {
                MessageBox.Show("Vui long dien day du thong tin ");
                return true;
            }
            this.client = this._clientDAO.FindIDClientByCmnd(cmnd);

            return false;
        }

        private void btnRentFromClient_Click(object sender, EventArgs e)
        {
            checkEmptyTxt();

            fNavigation form = fNavigation.getInstance();
            if (form != null)
            {
                this.Close();
                Session.Currentclient = this.client;
                form.OpenChildForm(new fRent());
                form.DisableButton();
                form.leftBorderBtn.Visible = false; ;
            }
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            if (checkEmptyTxt()) return;
            handleAddClient();
            loadDataClients();
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            if (checkEmptyTxt()) return;
            handleUpdateClient();
            loadDataClients();
        }

    }
}

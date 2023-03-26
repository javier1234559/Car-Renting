using Car_Renting.UserControls;
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
    public partial class fRentSubmit : Form
    {
        //Store data in the current form
        private Rent rent;
        private Car car;
        private Client client;
        //Dao
        private ClientDAO clientdao = new ClientDAO();
        private RentDAO rentdao = new RentDAO();
        

        public fRentSubmit()
        {
            InitializeComponent();
            if(Session.currentrent!= null)
            {
                this.rent = Session.currentrent;
                this.car = Session.currentcar; 
                this.client = Session.currentclient;
                fillDataRent();
            }
        }

        private void fillDataRent()
        {
            //fill car
            txtNameCar.Text = this.car.CarName;
            Image image = Image.FromFile(this.car.ImageCar);
            ImageCar.Image = image;

            //fill client
            txtClientName.Text = this.client.Name;
            txtCMND.Text = this.client.CCCD;
            txtEmail.Text = this.client.Email;
            txtPhone.Text = this.client.Phone;
            txtLisence.Text = this.client.License;

            //fill date
            datepkbegin.Value = this.rent.DateStart;
            datepkend.Value = this.rent.DateEnd;
            txtdescriptionRent.Text = this.rent.DescriptionRent;

        }

        private void tbnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void handleInsertClient()
        {
            int lastesid = clientdao.Insert(this.client);
            this.client.ClientId = lastesid;
        }

        private void handleInsertRent()
        {
            Client temp = clientdao.FindIDClientByCmnd(this.client.CCCD);
            if (temp != null)
            {
                this.rent.ClientId = temp.ClientId;
                this.rent.RentId =  rentdao.Insert(this.rent);
            }

        }

        private void updateSessionRent()
        {
            Session.currentrent = this.rent;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (this.rent == null) return;

            handleInsertClient();
            handleInsertRent();
            updateSessionRent();

            fNavigation form = fNavigation.getInstance();
            if (form != null)
            {
                this.Close();
                form.OpenChildForm(new fRenting());
            }

        }

    }
}

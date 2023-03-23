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
        private fNavigation currentForm;
        private Rent rent;

        public fRentSubmit(fNavigation currentForm, Rent rent)
        {
            InitializeComponent();
            this.currentForm=currentForm;
            this.rent=rent;
            if (rent != null) fillDataRent();
        }
        
        public fRentSubmit()
        {
            InitializeComponent();
        }

        private void fillDataRent()
        {
            //fill car
            txtNameCar.Text = this.rent.Car.CarName;
            Image image = Image.FromFile(this.rent.Car.ImageCar);
            ImageCar.Image = image;

            //fill client
            txtClientName.Text = this.rent.Client.Name;
            txtCMND.Text = this.rent.Client.CCCD;
            txtEmail.Text = this.rent.Client.Email;
            txtPhone.Text = this.rent.Client.Phone;
            txtLisence.Text = this.rent.Client.License;

            //fill date
            datepkbegin.Value = this.rent.DateStart;
            datepkend.Value = this.rent.DateEnd;
            txtdescriptionRent.Text = this.rent.DescriptionRent;


        }

        private void tbnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void btnAccept_Click(object sender, EventArgs e)
        {
            fNavigation form = this.currentForm;
            if (this.rent == null) return;
            ClientDAO clientdao = new ClientDAO();
            clientdao.Insert(this.rent.Client);
            Client d = clientdao.FindIDClientByCmnd(this.rent.Client.CCCD);

            


            if (form != null)
            {
                //form.panelDesktop.Controls.Add(new RentsScreen(car));
                this.Close();
                form.OpenChildForm(new fRenting(currentForm));
                form.DisableButton();
                form.leftBorderBtn.Visible = false; ;
            }

        }
    }
}

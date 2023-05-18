using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Car_Renting
{
    public partial class fRentSubmit : Form
    {
        private ClientDAO clientDAO;
        private RentDAO rentDAO;
        private CarDAO carDAO;
        private Rent rent;
        private Car car;
        private Client client;
       
        public fRentSubmit()
        {
            clientDAO = new ClientDAO();
            rentDAO = new RentDAO();
            carDAO = new CarDAO();
            InitializeComponent();
            
            if(Session.Currentrent != null && Session.Currentcar != null && Session.Currentclient != null)
            {
                this.rent = Session.Currentrent;
                this.car = Session.Currentcar;
                this.client = Session.Currentclient;
                fillDataRent();
            }
            else
            {
                MessageBox.Show("Lỗi không có giá trị thuê trong bộ nhớ đệm ");
            }
        }

        public fRentSubmit(Rent detailRent )
        {
            clientDAO = new ClientDAO();
            rentDAO = new RentDAO();
            carDAO = new CarDAO();

            InitializeComponent();

            this.rent = detailRent;
            this.car = carDAO.GetById(detailRent.CarId);
            this.client = clientDAO.GetById(detailRent.ClientId);

            btnAccept.Visible = false;
            fillDataRent();

        }

        //--------------- Handle Event ---------------- 

        private void tbnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            dialog.Title = "Car_Rental_Contact";
            dialog.FileName = "Car_Rental_Contact.pdf";
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filePath = dialog.FileName;
                PDFGenerate savepdf = PDFGenerate.getInstance();
                savepdf.GeneratePDFRent(filePath, this.rent, this.car, this.client, Session.Currentuser);

                MessageBox.Show($"Xuat file PDF thanh cong tai : {filePath}");

                Process process = new Process();
                process.StartInfo.FileName = filePath;
                process.Start();

                if (!process.WaitForExit(5000)) process.Kill();
            }

        }

        //--------------- Handle Logic ---------------- 

        private void fillDataRent()
        {
            //fill car
            txtNameCar.Text = this.car.CarName;
            string imagePath = Upload.GetFullImgPath(this.car.ImageCar);
            if (File.Exists(imagePath))
            {
                ImageCar.ImageLocation = imagePath;
            }

            //fill client
            txtClientName.Text = this.client.Name;
            txtCMND.Text = this.client.CCCD;
            txtEmail.Text = this.client.Email;
            txtPhone.Text = this.client.Phone;
            txtLisence.Text = this.client.License;

            //fill rent
            lbDeposit.Text = $"{this.rent.Deposit}";
            datepkbegin.Value = this.rent.DateStart;
            datepkend.Value = this.rent.DateEnd;
            txtdescriptionRent.Text = this.rent.DescriptionRent;

        }

        private void handleInsertClient()
        {
            int lastesid = clientDAO.Insert(this.client);
            this.client.ClientId = lastesid;
        }

        private void handleInsertRent()
        {
            Client temp = clientDAO.FindIDClientByCmnd(this.client.CCCD);
            Rent newRent = this.rent;
            newRent.State = Contraint.STATE_PEDDING;
            newRent.DateDelayQuantity = 0;
            newRent.CancellationReason = "";

            if (temp != null)
            {
                this.rent.ClientId = temp.ClientId;
                this.rent.RentId =  rentDAO.Insert(this.rent);
            }

        }

        private void updateSessionRent()
        {
            Session.Currentrent = this.rent;
        }
    }
}

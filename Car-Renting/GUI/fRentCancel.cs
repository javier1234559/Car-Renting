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
    public partial class fRentCancel : Form
    {
        //DAO
        RentDAO rentsDAO = new RentDAO();
        //Store data in the current form
        Rent rent = new Rent();

        public fRentCancel()
        {
            InitializeComponent();
            ShowListRent();
            if(Session.currentrentCanceled != null)
            {
                this.rent = Session.currentrentCanceled;
            }
        }
        private void ShowListRent()
        {
            this.gvCarCancel.DataSource = rentsDAO.GetAllDataTableByState(Contraint.STATE_CANCLED);
        }

        private void gvCarCancel_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gvCarCancel.Rows[e.RowIndex];
                if (String.IsNullOrEmpty(row.Cells["RentId"].Value?.ToString())) return;

                this.rent = rentsDAO.GetById(Int32.Parse(row.Cells["RentId"].Value.ToString()));
            }
        }

        private void btnRentCancelDetail_Click(object sender, EventArgs e)
        {
            fRentSubmit f = new fRentSubmit(this.rent , "Canceled_RENT");
            f.ShowDialog();
        }

        private void btnCancellationReasonSubmit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCancellationReason.Text)){
                MessageBox.Show("Hay dien ly do truoc khi save");
                return;
            }
            string resson = txtCancellationReason.Text;
            this.rent.CancellationReason = resson;
            rentsDAO.ChangeState(this.rent.RentId, Contraint.STATE_AVAILABLE);
            ShowListRent();
        }
    }
}

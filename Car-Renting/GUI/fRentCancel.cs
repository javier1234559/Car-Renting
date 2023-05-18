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
        RentDAO _rentsDAO;
        Rent rent ;

        public fRentCancel()
        {
            _rentsDAO = new RentDAO();
            InitializeComponent();
            ShowListRent();
            if(Session.CurrentrentCanceled != null)
            {
                this.rent = Session.CurrentrentCanceled;
            }
        }

        //--------------- Handle Event ---------------- 
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchKeyword = txtSearch.Text.Trim();
            this.gvCarCancel.DataSource = _rentsDAO.Search(searchKeyword, Contraint.STATE_CANCLED);
        }

        private void gvCarCancel_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gvCarCancel.Rows[e.RowIndex];
                if (String.IsNullOrEmpty(row.Cells["RentId"].Value?.ToString())) return;

                this.rent = _rentsDAO.GetById(Int32.Parse(row.Cells["RentId"].Value.ToString()));
            }
        }

        private void btnRentCancelDetail_Click(object sender, EventArgs e)
        {
            if(this.rent == null)
            {
                MessageBox.Show("Hay chon hoa don de xem chi tiet !!");
                return;
            }
            fRentSubmit f = new fRentSubmit(this.rent);
            f.ShowDialog();
        }

        private void btnCancellationReasonSubmit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCancellationReason.Text)){
                MessageBox.Show("Hay dien ly do truoc khi save");
                return;
            }
            string resson = txtCancellationReason.Text;
            _rentsDAO.ChangeState(this.rent.RentId, Contraint.STATE_AVAILABLE);
            Rent updateRent = _rentsDAO.GetById(this.rent.RentId);
            updateRent.CancellationReason = resson;
            _rentsDAO.Update(updateRent);
            ShowListRent();
        }

        //--------------- Handle Logic ---------------- 
        private void ShowListRent()
        {
            this.gvCarCancel.DataSource = _rentsDAO.GetAllDataTableByState(Contraint.STATE_CANCLED);
        }

    }
}

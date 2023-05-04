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
        RentDAO rentsDAO = new RentDAO();
        public fRentCancel()
        {
            InitializeComponent();
            ShowListRent();
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

            }
        }
    }
}

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
    public partial class fDiscount : Form
    {
        private DiscountManager _discountManager;//This class is builded in BUS layer
        private Discount discount;

        public fDiscount()
        {
            _discountManager= new DiscountManager();
            InitializeComponent();
            LoadData();
        }

        //--------------- Handle Event ---------------- 
        private void btnAddDiscount_Click(object sender, EventArgs e)
        {
            Discount newDiscount = new Discount();
            newDiscount.DiscountPercent = decimal.Parse(txtDiscountPercent.Text);
            newDiscount.StartDate = dtpStartDate.Value;
            newDiscount.EndDate = dtpEndDate.Value;
            newDiscount.Quantity = int.Parse(txtQuantity.Text);
            newDiscount.CreatedDate = DateTime.Now;
            newDiscount.CreatedBy = txtCreatedBy.Text;

            _discountManager.AddDiscount(newDiscount);
            MessageBox.Show("Create new discount successfully !");
            LoadData();
        }

        private void gvDiscount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get the selected row
            DataGridViewRow row = gvDiscount.Rows[e.RowIndex];
            if (String.IsNullOrEmpty(row.Cells["Id"].Value?.ToString())) return;
            // Fill the data into the controls
            LBDiscountCode.Text = row.Cells["Code"].Value.ToString();
            txtDiscountPercent.Text = row.Cells["DiscountPercent"].Value.ToString();
            dtpStartDate.Value = Convert.ToDateTime(row.Cells["StartDate"].Value);
            dtpEndDate.Value = Convert.ToDateTime(row.Cells["EndDate"].Value);
            txtQuantity.Text = row.Cells["Quantity"].Value.ToString();
            txtCreatedBy.Text = row.Cells["CreatedBy"].Value.ToString();

        }

        //--------------- Handle Logic ---------------- 
        private void LoadData()
        {
            DataTable dt = _discountManager.getAllDiscount();
            gvDiscount.DataSource = dt;
        }


    }
}

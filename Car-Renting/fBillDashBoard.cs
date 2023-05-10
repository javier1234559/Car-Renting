using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Car_Renting
{
    public partial class fBillDashBoard : Form
    {
        private BillDAO _billDAO;
        private Dictionary<string, int> data ;
        private DateTime start ;
        private DateTime end;


        public fBillDashBoard()
        {
            _billDAO= new BillDAO();
            this.start = DateTime.Today;
            this.end = DateTime.Now;
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            gvBill.DataSource = _billDAO.GetFullDataBill();
        }

        private void btnStatisticDamage_Click(object sender, EventArgs e)
        {
            this.data = _billDAO.GetDataDamaged(this.start,this.end);
            DrawChart();
        }

        private void btnStatíticByBestsellers_Click(object sender, EventArgs e)
        {
            this.data = _billDAO.GetDataBestSeller(this.start , this.end);
            DrawChart();
        }


        private void btnStatisticByRating_Click(object sender, EventArgs e)
        {
            this.data = _billDAO.GetDataRating();
            DrawChart();
        }

        private void DrawChart()
        {

            chartColumn.Series["ColumnSeries"].Points.Clear();

            foreach (KeyValuePair<string, int> kvp in data)
            {
                chartColumn.Series["ColumnSeries"].Points.AddXY(kvp.Key, kvp.Value);
            }

            chartDoughnut.Series["DoughnutSeries"].Points.Clear();

            chartDoughnut.Series["DoughnutSeries"].Points.DataBindXY(data.Keys, data.Values);

        }

        private void btnByDay_Click(object sender, EventArgs e)
        {
            this.start = DateTime.Today;
            this.end = DateTime.Now;
            DrawChart();
        }

        private void btnByMonth_Click(object sender, EventArgs e)
        {
            this.start =  new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            this.end = DateTime.Now;
            DrawChart();
        }

        private void btnByYear_Click(object sender, EventArgs e)
        {
            this.start =  new DateTime(DateTime.Today.Year, 1, 1);
            this.end = DateTime.Now;
            DrawChart();
        }

        private void btnQuarterLy_Click(object sender, EventArgs e)
        {
            this.end = DateTime.Now;
            this.start = this.end.AddMonths(-3);

            DrawChart();
        }
    }
}

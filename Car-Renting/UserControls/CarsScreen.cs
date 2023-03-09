using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Renting.UserControls
{
    public partial class CarsScreen : UserControl
    {
        CarDAO carDao = new CarDAO();
        public CarsScreen()
        {
            InitializeComponent();
            ShowListCar();
        }
        private void ShowListCar()
        {
            this.gvCars.DataSource = carDao.getListCar();
        }


        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private void gvCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

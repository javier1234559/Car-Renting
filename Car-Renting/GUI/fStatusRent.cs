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
    public partial class fStatusRent : Form
    {
        private RentDAO _rentDAO;

        public fStatusRent()
        {
            InitializeComponent();
            _rentDAO= new RentDAO();
            this.gvStatusRent.DataSource = _rentDAO.GetAllDataTable();
        }

    }
}

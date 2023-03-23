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
    public partial class fClient : Form
    {
        ClientDAO clientdao = new ClientDAO();
        public fClient()
        {
            InitializeComponent();
            loadDataClients();
        }

        private void loadDataClients()
        {
            this.gvClients.DataSource = clientdao.GetAllDataTable();
        }

        private void gvClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

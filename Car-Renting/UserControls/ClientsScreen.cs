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
    public partial class ClientsScreen : UserControl
    {
        ClientDAO clientdao = new ClientDAO();
        public ClientsScreen()
        {
            InitializeComponent();
        }

        private void ClientsScreen_Load(object sender, EventArgs e)
        {
            gvClients.DataSource = clientdao.getListClient();
        }


    }
}

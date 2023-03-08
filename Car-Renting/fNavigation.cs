using Car_Renting.UserControls;
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
    public partial class fNavigation : Form
    {
        NavigationLogic navlogic;

        public fNavigation()
        {
            InitializeComponent();
            InititalizeNavigationLogic();
        }

        private void InititalizeNavigationLogic()
        {
           
            List<UserControl> list = new List<UserControl>();
            list.Add(new RentsScreen());
            list.Add(new CarsScreen());
            list.Add(new BillsScreen());
            list.Add(new ClientsScreen());
            list.Add(new UsersScreen());
            list.Add(new SettingScreen());

            navlogic = new NavigationLogic(list, this.plMainScreen);
            navlogic.Display(0);
        }

        private void btn_RentsNav_Click(object sender, EventArgs e)
        {
            navlogic.Display(0);
        }
        private void btn_CarsNav_Click(object sender, EventArgs e)
        {
            navlogic.Display(1);
        }

        private void tbn_BillsNav_Click(object sender, EventArgs e)
        {
            navlogic.Display(2);

        }

        private void btn_ClientsNav_Click(object sender, EventArgs e)
        {
            navlogic.Display(3);
        }

        private void btn_UsersNav_Click(object sender, EventArgs e)
        {
            navlogic.Display(4);
        }

        private void btn_SettingNav_Click(object sender, EventArgs e)
        {
            navlogic.Display(5);
        }
    }
}

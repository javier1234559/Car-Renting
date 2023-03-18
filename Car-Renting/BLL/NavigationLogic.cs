using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Renting
{
    public class NavigationLogic
    {
        public List<UserControl> list = new List<UserControl>();
        public Panel panel;

        public NavigationLogic(Panel panel) { 
            this.panel = panel;
        }

        public NavigationLogic(List<UserControl> list, Panel panel) {
            this.list = list;
            this.panel = panel;
            AddUserControl();
        }

        public void AddUserControl()
        {
            foreach (UserControl control in list)
            {
                control.Dock = DockStyle.Fill;
                panel.Controls.Add(control);
            }

        }
        public void Display(int index)
        {
            if (index < list.Count())
            {
                list[index].BringToFront();
            }
        }

        public void Display(UserControl control) {
            control.Dock = DockStyle.Fill;
            panel.Controls.Add(control);

        }
    }
}

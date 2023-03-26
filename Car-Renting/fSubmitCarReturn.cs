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
    public partial class fSubmitCarReturn : Form
    {

        private const int MAX_HEIGHT_WITHOUT_SCROLLBAR = 600; // 
        public fSubmitCarReturn()
        {
            InitializeComponent();
            this.MaximumSize = new Size(int.MaxValue, MAX_HEIGHT_WITHOUT_SCROLLBAR);
            this.AutoScroll = true;
        }

    }
}

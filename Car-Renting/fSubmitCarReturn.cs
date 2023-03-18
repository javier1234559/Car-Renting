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
        private const int MAX_HEIGHT_WITHOUT_SCROLLBAR = 700; // 
        public fSubmitCarReturn()
        {
            InitializeComponent();
            this.AutoScroll = true;
            this.HorizontalScroll.Enabled = false;
            this.AutoScrollMinSize = new Size(0, MAX_HEIGHT_WITHOUT_SCROLLBAR);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EisenhowerMatrix
{
    public partial class DateTask : Form
    {
        public DateTask()
        {
            InitializeComponent();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_date_Click(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}

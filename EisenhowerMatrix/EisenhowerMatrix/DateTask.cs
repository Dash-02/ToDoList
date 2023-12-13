//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace EisenhowerMatrix
//{
//    public partial class DateTask : Form
//    {
//        public DateTime SelectedDate { get; private set; }
//        public string TaskDescription { get; private set; }

//        public DateTask()
//        {
//            InitializeComponent();
//        }

//        private void btn_home_Click(object sender, EventArgs e)
//        {
//            DialogResult = DialogResult.Cancel;
//            Close();
//        }

//        private void btn_taskDate_Click(object sender, EventArgs e)
//        {
//            SelectedDate = monthCalendar1.SelectionStart;
//            TaskDescription = textBoxTask.Text;

//            DialogResult = DialogResult.OK;
//            Close();
//        }

//        private void btn_date_Click(object sender, EventArgs e)
//        {
//            Refresh();
//        }
//    }
//}
using System;
using System.Windows.Forms;

namespace EisenhowerMatrix
{
    public partial class DateTask : Form
    {
        public DateTime SelectedDate { get; private set; }
        //public string TaskDescription { get; private set; }

        public DateTask()
        {
            InitializeComponent();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            SelectedDate = monthCalendar1.SelectionStart;

            //TaskDescription = textBoxTaskDescription.Text;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}


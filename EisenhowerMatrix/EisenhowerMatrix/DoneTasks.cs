using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace EisenhowerMatrix
{
    public partial class DoneTasks : Form
    {
        private List<Task> completedTasks;
        public DoneTasks(List<Task> tasks)
        {
            InitializeComponent();
            completedTasks = tasks.Where(task => task.IsCompleted).ToList();
            UpdateCompletedTasksDisplay();
        }
        private void UpdateCompletedTasksDisplay()
        {
            listBox1.Items.Clear();

            foreach (Task task in completedTasks)
            {
                listBox1.Items.Add(task.Title);
            }
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_add_task_Click(object sender, EventArgs e)
        {
            Close();
            AddTaskForm addTaskForm = new AddTaskForm();
            addTaskForm.ShowDialog();
        }

        private void btn_done_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btn_date_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

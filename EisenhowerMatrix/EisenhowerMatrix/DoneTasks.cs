using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EisenhowerMatrix
{
    public partial class DoneTasks : Form
    {
        private List<Task> completedTasks;
        private List<Task> completedTasks2;
        public DoneTasks(List<Task> completedTasks)
        {
            InitializeComponent();
            completedTasks2 = completedTasks;
            UpdateCompletedTasks();
        }
        private void UpdateCompletedTasks()
        {
            listBox1.Items.Clear();

            foreach (Task task in completedTasks2)
            {
                listBox1.Items.Add(task);
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

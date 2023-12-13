using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace EisenhowerMatrix
{
    public partial class DoneTasks : Form
    {
        private List<Task> completedTasks;

        public List<Task> CompletedTasks { get { return completedTasks; } }

        public DoneTasks(List<Task> completedTasks)
        {
            InitializeComponent();
            this.completedTasks = LoadCompletedTasks();
            UpdateCompletedTasks();
            label1.Text = $"Выполненные задачи: {completedTasks.Count}";
        }

        private void DoneTasks_Load(object sender, EventArgs e)
        {
            LoadCompletedTasks();
            UpdateCompletedTasks();
        }

        private List<Task> LoadCompletedTasks()
        {
            if (File.Exists("completedTasks.json"))
            {
                string json = File.ReadAllText("completedTasks.json");
                if (!string.IsNullOrEmpty(json))
                {
                    return JsonConvert.DeserializeObject<List<Task>>(json) ?? new List<Task>();
                }
            }
            return new List<Task>();
        }

        private void UpdateCompletedTasks()
        {
            listBox1.Items.Clear();
            foreach (Task task in completedTasks)
            {
                listBox1.Items.Add(task);
            }
        }

        private void SaveCompletedTasks()
        {
            label1.Text = $"Выполненные задачи: {completedTasks.Count}";
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_done_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void CopyToolStripMenu_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            ContextMenuStrip menu = (ContextMenuStrip)menuItem.Owner;
            Control sourceControl = menu.SourceControl;

            if (sourceControl is ListBox listBox)
            {
                if (listBox.SelectedItem is Task selectedTask)
                {
                    Clipboard.SetText(selectedTask.Title);
                }
            }
        }

        private void DeleteToolStripMenu_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)sender;
            if (toolStripMenuItem.GetCurrentParent() is ContextMenuStrip contextMenuStrip && contextMenuStrip.SourceControl is ListBox listBox)
            {
                if (listBox.SelectedItem is Task selectedTask)
                {
                    DialogResult result = MessageBox.Show("Вы действительно хотите удалить задачу?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        completedTasks.Remove(selectedTask);
                        UpdateCompletedTasks();
                        SaveCompletedTasks();
                    }
                }
            }
        }

    }
}

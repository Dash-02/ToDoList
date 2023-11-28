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
        private List<Task> completedTasks2;

        public List<Task> CompletedTasks { get; internal set; }
        public DoneTasks()
        {
            InitializeComponent();
            completedTasks = LoadCompletedTasks();
            UpdateCompletedTasks();
            label1.Text = $"Выполненные задачи: {completedTasks.Count}";
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
            List<Task> existingCompletedTasks = LoadCompletedTasks();
            existingCompletedTasks.AddRange(completedTasks);
            string json = JsonConvert.SerializeObject(existingCompletedTasks, Formatting.Indented);
            File.WriteAllText("completedTasks.json", json);
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
                    completedTasks.Remove(selectedTask);
                    UpdateCompletedTasks();
                    SaveCompletedTasks();
                }
            }
        }
    }
}

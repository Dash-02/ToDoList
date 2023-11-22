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

        //public DoneTasks(List<Task> completedTasks)
        //{
        //    InitializeComponent();
        //    completedTasks2 = completedTasks;
        //    LoadCompletedTasks();
        //    SaveCompletedTasks();
        //    UpdateCompletedTasks();
        //    label1.Text = $"Выполненные задачи: {completedTasks.Count}";
        //}
        //private List<Task> LoadCompletedTasks()
        //{
        //    if (File.Exists("completedTasks.json"))
        //    {
        //        string json = File.ReadAllText("completedTasks.json");
        //        if (!string.IsNullOrEmpty(json))
        //        {
        //            return JsonConvert.DeserializeObject<List<Task>>(json);
        //        }
        //    }
        //    return new List<Task>();
        //}
        //private void UpdateCompletedTasks()
        //{
        //    listBox1.Items.Clear();

        //    foreach (Task task in completedTasks2)
        //    {
        //        listBox1.Items.Add(task);
        //    }
        //}
        //private void SaveCompletedTasks()
        //{
        //    string json = JsonConvert.SerializeObject(completedTasks);
        //    File.WriteAllText("completedTasks.json", json);
        //}

        public DoneTasks(List<Task> completedTasks)
        {
            InitializeComponent();
            completedTasks2 = completedTasks;
            LoadCompletedTasks();
            SaveCompletedTasks();
            UpdateCompletedTasks();
            label1.Text = $"Выполненные задачи: {completedTasks2.Count}";
        }
        //private List<Task> LoadCompletedTasks()
        //{
        //    if (File.Exists("completedTasks.json"))
        //    {
        //        string json = File.ReadAllText("completedTasks.json");
        //        if (!string.IsNullOrEmpty(json))
        //        {
        //            completedTasks = JsonConvert.DeserializeObject<List<Task>>(json);
        //        }
        //    }
        //    return completedTasks;
        //}

        private void LoadCompletedTasks()
        {
            if (File.Exists("tasks.json"))
            {
                string json = File.ReadAllText("tasks.json");
                if (!string.IsNullOrEmpty(json))
                {
                    completedTasks = JsonConvert.DeserializeObject<List<Task>>(json);
                }
            }
        }
        private void UpdateCompletedTasks()
        {
            listBox1.Items.Clear();
            foreach (Task task in completedTasks)
            {
                if (task.IsCompleted)
                {
                    listBox1.Items.Add(task);
                }
            }
        }

        private void SaveCompletedTasks()
        {
            string json = JsonConvert.SerializeObject(completedTasks2);
            File.WriteAllText("tasks.json", json);
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
        private void DeleteToolStripMenu_Click(object sender, EventArgs e)// пофиксить, не удаляет
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

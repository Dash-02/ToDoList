using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace EisenhowerMatrix
{
    public partial class Form1 : Form
    {
        private List<Task> tasks;
        private List<Task> completedTasks;
        public Form1()
        {
            InitializeComponent();
            tasks = new List<Task>();
            completedTasks = new List<Task>();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTasksFromJson();
            UpdateTasksDisplay();
        }
        #region ButtonsMenu
        private void btn_home_Click(object sender, EventArgs e)
        {
            UpdateTasksDisplay();
        }

        private void btn_date_Click(object sender, EventArgs e)
        {

        }

        private void btn_done_Click(object sender, EventArgs e)
        {
            DoneTasks DoneTasks = new DoneTasks(completedTasks);
            DoneTasks.ShowDialog();
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            AddTaskForm addTaskForm = new AddTaskForm();
            if (addTaskForm.ShowDialog() == DialogResult.OK)
            {
                string taskTitle = addTaskForm.TaskTitle;
                string priority = addTaskForm.Priority;

                Task newTask = new Task(taskTitle, priority);
                tasks.Add(newTask);
                SaveTasksToJson();
                UpdateTasksDisplay();
            }
        }
        #endregion
        
        private void UpdateTasksDisplay()
        {
            lsBoxImportantUg.Items.Clear();
            lsBoxImportantNotUg.Items.Clear();
            lsBoxNotImportUg.Items.Clear();
            lsBoxNotImportNotUg.Items.Clear();


            foreach (Task task in tasks)
            {
                switch (task.Priority)
                {
                    case "Важно-срочно":
                        lsBoxImportantUg.Items.Add(task);
                        break;
                    case "Важно-не-срочно":
                        lsBoxImportantNotUg.Items.Add(task);
                        break;
                    case "Не-важно-срочно":
                        lsBoxNotImportUg.Items.Add(task);
                        break;
                    case "Не-важно-не-срочно":
                        lsBoxNotImportNotUg.Items.Add(task);
                        break;
                }
            }
        }
        private void SaveTasksToJson()
        {
            string json = JsonConvert.SerializeObject(tasks);
            File.WriteAllText("tasks.json", json);
        }

        private void LoadTasksFromJson()
        {
            if (File.Exists("tasks.json"))
            {
                string json = File.ReadAllText("tasks.json");
                if (!string.IsNullOrEmpty(json))
                {
                    tasks = JsonConvert.DeserializeObject<List<Task>>(json);
                }
            }
        }

        private void TaskClick(object sender, EventArgs e)
        {
            ListBox listBox = (ListBox)sender;

            if (listBox.SelectedItem != null && listBox.SelectedItem is Task)
            {
                Task clickedTask = (Task)listBox.SelectedItem;
                clickedTask.IsCompleted = true;
                completedTasks.Add(clickedTask);
                tasks.Remove(clickedTask);
                SaveTasksToJson();
                UpdateTasksDisplay();
            }
        }
        #region StripMenuTools
        private void CopyToolStripMenu_Click(object sender, EventArgs e)
        {

        }

        private void PasteToolStripMenu_Click(object sender, EventArgs e)
        {

        }

        private void CropToolStripMenu_Click(object sender, EventArgs e)
        {

        }

        private void DeleteToolStripMenu_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
    public class Task
    {
        public string Title { get; set; }
        public string Priority { get; set; }
        public bool IsCompleted { get; set; }

        public Task(string title, string priority)
        {
            Title = title;
            Priority = priority;
            IsCompleted = false;
        }
        public override string ToString()
        {
            return Title;
        }
    }
}

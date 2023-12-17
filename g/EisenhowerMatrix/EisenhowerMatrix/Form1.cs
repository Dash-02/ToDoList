using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace EisenhowerMatrix
{
    public partial class Form1 : Form
    {
        private List<Task> tasks;
        private List<Task> completedTasks;
        private bool isEditing;
        private Task selectedTask;
        private Point dragStartPoint;
        int indexToMove;
        private ListBox currentListBox;

        public Form1()
        {
            InitializeComponent();
            tasks = new List<Task>();
            completedTasks = LoadCompletedTasks();

            UpdateTasksDisplay();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTasksFromJson();
            UpdateTasksDisplay();
        }
        
        private void ListBox_MouseDown(object sender, MouseEventArgs e)
        {
            ListBox listBox = sender as ListBox;
            if (e.Button == MouseButtons.Left)
            {
                selectedTask = listBox.SelectedItem as Task;
                if (selectedTask != null)
                {
                    dragStartPoint = e.Location;
                    listBox.DoDragDrop(selectedTask, DragDropEffects.Move | DragDropEffects.Copy);
                    currentListBox = listBox;
                }
            }
        }
        
        #region ButtonsMenu
        private void btn_home_Click(object sender, EventArgs e)
        {
            UpdateTasksDisplay();
        }

        private void btn_done_Click(object sender, EventArgs e)
        {
            DoneTasks doneTasksForm = new DoneTasks(completedTasks);
            doneTasksForm.ShowDialog();
            completedTasks = doneTasksForm.CompletedTasks;
            SaveCompletedTasks();
            UpdateTasksDisplay();
        }
         private void btn_add_Click(object sender, EventArgs e)
        {
            AddTaskForm addTaskForm = new AddTaskForm();
            if (addTaskForm.ShowDialog() == DialogResult.OK)
            {
                DateTime date = addTaskForm.SelectedDate;
                string taskTitle = addTaskForm.TaskTitle;
                string priority = addTaskForm.Priority;

                Task newTask = new Task(taskTitle, priority, date);
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
            label5.Text = $"Всего задач: {tasks.Count}";
        }
        private void SaveTasksToJson()
        {
            string json = JsonConvert.SerializeObject(tasks, Formatting.Indented);
            File.WriteAllText("tasks.json", json);
        }

        private void SaveCompletedTasks()
        {
            string json = JsonConvert.SerializeObject(completedTasks, Formatting.Indented);
            File.WriteAllText("completedTasks.json", json);
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
            ToolStripMenuItem toolStripMenuItem = sender as ToolStripMenuItem;

            if (toolStripMenuItem != null)
            {
                ContextMenuStrip menu = (ContextMenuStrip)toolStripMenuItem.Owner;
                Control sourceControl = menu.SourceControl;

                if (sourceControl is ListBox listBox)
                {
                    if (listBox.SelectedItem is Task selectedTask)
                    {
                        selectedTask.IsCompleted = true;
                        completedTasks.Add(selectedTask);
                        tasks.Remove(selectedTask);
                        SaveTasksToJson();
                        SaveCompletedTasks();
                        UpdateTasksDisplay();
                        DialogResult result = MessageBox.Show("Задача выполнена!", "Выполнение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
            }
        }

        #region StripMenuTools
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

        private void PasteToolStripMenu_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            ContextMenuStrip menu = (ContextMenuStrip)menuItem.Owner;
            Control sourceControl = menu.SourceControl;
            string priority = "";
            DateTime date = selectedTask.Date;
            if (sourceControl is ListBox listBox)
            {
                if (listBox.Name == lsBoxImportantUg.Name)
                {
                    priority = "Важно-срочно";
                }
                else if (listBox.Name == lsBoxImportantNotUg.Name)
                {
                    priority = "Важно-не-срочно";
                }
                else if (listBox.Name == lsBoxNotImportUg.Name)
                {
                    priority = "Не-важно-срочно";
                }
                else if (listBox.Name == lsBoxNotImportNotUg.Name)
                {
                    priority = "Не-важно-не-срочно";
                }

                string clipboardText = Clipboard.GetText();
                if (!string.IsNullOrEmpty(clipboardText))
                {
                    Task newTask = new Task(clipboardText, priority, date);
                    tasks.Add(newTask);
                    SaveTasksToJson();
                    UpdateTasksDisplay();
                }
            }
        }

        private void CropToolStripMenu_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            ContextMenuStrip menu = (ContextMenuStrip)menuItem.GetCurrentParent();
            Control sourceControl = menu.SourceControl;

            if (sourceControl is ListBox listBox)
            {
                if (listBox.SelectedItem is Task selectedTask)
                {
                    tasks.Remove(selectedTask);
                    Clipboard.SetText(selectedTask.Title);
                    SaveTasksToJson();
                    UpdateTasksDisplay();
                }
            }
        }

        private void DeleteToolStripMenu_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)sender;
            if (toolStripMenuItem.GetCurrentParent() is ContextMenuStrip contextMenuStrip && contextMenuStrip.SourceControl is ListBox listBox && listBox.SelectedItem != null)
            {
                DialogResult result = MessageBox.Show("Вы действительно хотите удалить задачу?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (listBox.SelectedItem is Task selectedTask)
                {
                    tasks.Remove(selectedTask);
                    SaveTasksToJson();
                    UpdateTasksDisplay();
                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lsBoxImportantUg.SelectedItem != null)
            {
                Task selectedTask = (Task)lsBoxImportantUg.SelectedItem;
                OpenEditForm(selectedTask);
            }
            else if(lsBoxImportantNotUg.SelectedItem != null)
            {
                Task selectedTask = (Task)lsBoxImportantNotUg.SelectedItem;
                OpenEditForm(selectedTask);
            }
            else if (lsBoxNotImportUg.SelectedItem != null)
            {
                Task selectedTask = (Task)lsBoxNotImportUg.SelectedItem;
                OpenEditForm(selectedTask);
            }
            else if(lsBoxNotImportNotUg.SelectedItem != null)
            {
                Task selectedTask = (Task)lsBoxNotImportNotUg.SelectedItem;
                OpenEditForm(selectedTask);
            }
        }

        #endregion
        private void OpenEditForm(Task task)
        {
            using (AddTaskForm editForm = new AddTaskForm(true, task.Title, task.Priority, task.Date))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    task.Title = editForm.TaskTitle;
                    task.Priority = editForm.Priority;
                    task.Date = editForm.TaskDate;
                    SaveTasksToJson();
                    UpdateTasksDisplay();
                }
            }
        }
    }
    public class Task
    {
        public string Title { get; set; }
        public string Priority { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime Date { get; set; }

        public Task(string title, string priority, DateTime date)
        {
            Title = title;
            Priority = priority;
            Date = date;
            IsCompleted = false;
        }

        public override string ToString()
        {
            return $"{Title} - {Date.ToShortDateString()}";
        }
    }
}

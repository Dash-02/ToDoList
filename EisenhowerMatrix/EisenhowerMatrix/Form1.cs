using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace EisenhowerMatrix
{
    public partial class Form1 : Form
    {
        private List<Task> tasks;
        public Form1()
        {
            InitializeComponent();
            tasks = new List<Task>();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            boxImportantUg.SetInnerMargins(10, 8, 8, 8);
            boxImportantNotUg.SetInnerMargins(10, 8, 8, 8);
            boxNotImportUg.SetInnerMargins(10, 8, 8, 8);
            boxNotImportNotUg.SetInnerMargins(10, 8, 8, 8);

            if (File.Exists("tasks.json"))
            {
                string json = File.ReadAllText("tasks.json");
                tasks = JsonConvert.DeserializeObject<List<Task>>(json);
            }
            else
            {
                tasks = new List<Task>();
            }
        }

        private void btn_home_Click(object sender, EventArgs e)
        {

        }

        private void btn_date_Click(object sender, EventArgs e)
        {

        }

        private void btn_done_Click(object sender, EventArgs e)
        {
            DoneTasks DoneTasks = new DoneTasks();
        }
        //    private void btn_add_Click(object sender, EventArgs e)
        //    {
        //        AddTaskForm addTaskForm = new AddTaskForm();
        //        if (addTaskForm.ShowDialog() == DialogResult.OK)
        //        {
        //            string taskTitle = addTaskForm.TaskTitle;
        //            string priority = addTaskForm.Priority;

        //            Task newTask = new Task(taskTitle, priority);
        //            tasks.Add(newTask);
        //            SaveTasksToJson();
        //            UpdateTasksDisplay();
        //        }
        //    }
        //    private void SaveTasksToJson()
        //    {
        //        string json = JsonConvert.SerializeObject(tasks);
        //        File.WriteAllText("tasks.json", json);
        //    }
        //    private void UpdateTasksDisplay()
        //    {
        //        boxImportantUg.Clear();
        //        boxImportantNotUg.Clear();
        //        boxNotImportUg.Clear();
        //        boxNotImportNotUg.Clear();

        //        foreach (Task task in tasks)
        //        {
        //            if (task.Priority == "Важно-срочно")
        //            {
        //                boxImportantUg.AppendText(task.Title + Environment.NewLine);
        //            }
        //            else if (task.Priority == "Важно-не-срочно")
        //            {
        //                boxImportantNotUg.AppendText(task.Title + Environment.NewLine);
        //            }
        //            else if (task.Priority == "Не-важно-срочно")
        //            {
        //                boxNotImportUg.AppendText(task.Title + Environment.NewLine);
        //            }
        //            else if (task.Priority == "Не-важно-не-срочно")
        //            {
        //                boxNotImportNotUg.AppendText(task.Title + Environment.NewLine);
        //            }
        //        }
        //    }
        //}
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

        private void SaveTasksToJson()
        {
            List<Task> allTasks;
            if (File.Exists("tasks.json"))
            {
                string json = File.ReadAllText("tasks.json");
                allTasks = JsonConvert.DeserializeObject<List<Task>>(json);
            }
            else
            {
                allTasks = new List<Task>();
            }

            allTasks.AddRange(tasks);
            string updatedJson = JsonConvert.SerializeObject(allTasks);
            File.WriteAllText("tasks.json", updatedJson);
        }

        private List<Task> LoadTasksFromJson()
        {
            if (File.Exists("tasks.json"))
            {
                string json = File.ReadAllText("tasks.json");
                return JsonConvert.DeserializeObject<List<Task>>(json);
            }
            return new List<Task>();
        }

        private void UpdateTasksDisplay()
        {
            boxImportantUg.Clear();
            boxImportantNotUg.Clear();
            boxNotImportUg.Clear();
            boxNotImportNotUg.Clear();

            foreach (Task task in tasks)
            {
                if (task.Priority == "Важно-срочно")
                {
                    boxImportantUg.AppendText(task.Title + Environment.NewLine);
                }
                else if (task.Priority == "Важно-не-срочно")
                {
                    boxImportantNotUg.AppendText(task.Title + Environment.NewLine);
                }
                else if (task.Priority == "Не-важно-срочно")
                {
                    boxNotImportUg.AppendText(task.Title + Environment.NewLine);
                }
                else if (task.Priority == "Не-важно-не-срочно")
                {
                    boxNotImportNotUg.AppendText(task.Title + Environment.NewLine);
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            tasks = LoadTasksFromJson();
            UpdateTasksDisplay();
        }
    }
    public class Task
    {
        public string Title { get; set; }
        public string Priority { get; set; }

        public Task(string title, string priority)
        {
            Title = title;
            Priority = priority;
        }
    }
}

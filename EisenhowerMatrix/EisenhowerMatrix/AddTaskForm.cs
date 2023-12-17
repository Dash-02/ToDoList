using System;
using System.Windows.Forms;

namespace EisenhowerMatrix
{
    public partial class AddTaskForm : Form
    {
        private bool isEditing;

        public DateTime SelectedDate { get; private set; }
        public DateTime TaskDate { get; private set; }
        public AddTaskForm()
        {
            InitializeComponent();
            SelectedDate = DateTime.Now;
        }

        public AddTaskForm(bool isEditing, string taskTitle, string priority, DateTime date)
        {
            this.isEditing = isEditing;
            InitializeComponent();
            Edit(isEditing, taskTitle, priority, date);
        }

        public string TaskTitle { get; private set; }
        public string Priority { get; private set; }
        public object Date { get; }

        private void btn_add_Click(object sender, EventArgs e)
        {
            TaskTitle = textBox1.Text;

            if (!string.IsNullOrWhiteSpace(TaskTitle))
            {
                if (radioBtn_urgentImportant.Checked)
                    Priority = "Важно-срочно";
                else if (radioBtn_urgentNotImportant.Checked)
                    Priority = "Не-важно-срочно";
                else if (radioBtn_notUrgentImportant.Checked)
                    Priority = "Важно-не-срочно";
                else if (radioBtn_notUrgentNotImportant.Checked)
                    Priority = "Не-важно-не-срочно";
                else
                {
                    MessageBox.Show("Выберите приоритет задачи", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                TaskDate = SelectedDate;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Введите текст задачи", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Edit(bool isEdit, string taskTitle, string priority, DateTime date)
        {
            if (isEdit == true)
            {
                this.Text = "Редактирование задач";
                label1.Text = "Измените задачу:";
                btn_save.Text = "Сохранить";
                label3.Text = "Изменить дату:";
                textBox1.Text = taskTitle;
                dateTimePicker1.Value = date;

                switch (priority)
                {
                    case "Важно-срочно":
                        radioBtn_urgentImportant.Checked = true;
                        break;
                    case "Не-важно-срочно":
                        radioBtn_urgentNotImportant.Checked = true;
                        break;
                    case "Важно-не-срочно":
                        radioBtn_notUrgentImportant.Checked = true;
                        break;
                    case "Не-важно-не-срочно":
                        radioBtn_notUrgentNotImportant.Checked = true;
                        break;
                }
                TaskDate = dateTimePicker1.Value;

            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            TaskDate = dateTimePicker1.Value;
            SelectedDate = TaskDate;
        }
    }
}

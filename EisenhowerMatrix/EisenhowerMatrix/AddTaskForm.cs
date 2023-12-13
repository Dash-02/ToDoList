using System;
using System.Windows.Forms;

namespace EisenhowerMatrix
{
    public partial class AddTaskForm : Form
    {
        private bool isEditing;

        public DateTime SelectedDate { get; private set; }

        public AddTaskForm()
        {
            InitializeComponent();
        }

        public AddTaskForm(bool isEditing)
        {
            this.isEditing = isEditing;
            InitializeComponent();
            Edit(isEditing);
        }

        public string TaskTitle { get; private set; }
        public string Priority { get; private set; }

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

                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Введите текст задачи", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Edit(bool isEdit)
        {
            if (isEdit == true)
            {
                this.Text = "Редактирование задач";
                label1.Text = "Измените задачу:";
                btn_save.Text = "Сохранить";
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_selectDate_Click(object sender, EventArgs e)
        {
            using (var dateDialog = new DateTask())
            {
                if (dateDialog.ShowDialog() == DialogResult.OK)
                {
                    SelectedDate = dateDialog.SelectedDate;
                }
            }
        }
    }
}

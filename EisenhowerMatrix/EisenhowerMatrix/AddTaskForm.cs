using System;
using System.Windows.Forms;

namespace EisenhowerMatrix
{
    public partial class AddTaskForm : Form
    {
        
        public AddTaskForm()
        {
            InitializeComponent();
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

                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Введите текст задачи", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

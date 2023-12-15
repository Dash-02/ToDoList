namespace EisenhowerMatrix
{
    partial class AddTaskForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTaskForm));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioBtn_urgentImportant = new System.Windows.Forms.RadioButton();
            this.radioBtn_urgentNotImportant = new System.Windows.Forms.RadioButton();
            this.radioBtn_notUrgentImportant = new System.Windows.Forms.RadioButton();
            this.radioBtn_notUrgentNotImportant = new System.Windows.Forms.RadioButton();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.textBox1.Location = new System.Drawing.Point(258, 104);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(399, 49);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.SlateGray;
            this.label1.Location = new System.Drawing.Point(367, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите задачу:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.SlateGray;
            this.label2.Location = new System.Drawing.Point(253, 184);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Приоритет задачи";
            // 
            // radioBtn_urgentImportant
            // 
            this.radioBtn_urgentImportant.AutoSize = true;
            this.radioBtn_urgentImportant.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.radioBtn_urgentImportant.Location = new System.Drawing.Point(258, 238);
            this.radioBtn_urgentImportant.Margin = new System.Windows.Forms.Padding(4);
            this.radioBtn_urgentImportant.Name = "radioBtn_urgentImportant";
            this.radioBtn_urgentImportant.Size = new System.Drawing.Size(132, 23);
            this.radioBtn_urgentImportant.TabIndex = 3;
            this.radioBtn_urgentImportant.TabStop = true;
            this.radioBtn_urgentImportant.Text = "Важно и срочно";
            this.radioBtn_urgentImportant.UseVisualStyleBackColor = true;
            // 
            // radioBtn_urgentNotImportant
            // 
            this.radioBtn_urgentNotImportant.AutoSize = true;
            this.radioBtn_urgentNotImportant.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.radioBtn_urgentNotImportant.Location = new System.Drawing.Point(258, 295);
            this.radioBtn_urgentNotImportant.Margin = new System.Windows.Forms.Padding(4);
            this.radioBtn_urgentNotImportant.Name = "radioBtn_urgentNotImportant";
            this.radioBtn_urgentNotImportant.Size = new System.Drawing.Size(164, 23);
            this.radioBtn_urgentNotImportant.TabIndex = 4;
            this.radioBtn_urgentNotImportant.TabStop = true;
            this.radioBtn_urgentNotImportant.Text = "Не важно, но срочно";
            this.radioBtn_urgentNotImportant.UseVisualStyleBackColor = true;
            // 
            // radioBtn_notUrgentImportant
            // 
            this.radioBtn_notUrgentImportant.AutoSize = true;
            this.radioBtn_notUrgentImportant.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.radioBtn_notUrgentImportant.Location = new System.Drawing.Point(458, 238);
            this.radioBtn_notUrgentImportant.Margin = new System.Windows.Forms.Padding(4);
            this.radioBtn_notUrgentImportant.Name = "radioBtn_notUrgentImportant";
            this.radioBtn_notUrgentImportant.Size = new System.Drawing.Size(162, 23);
            this.radioBtn_notUrgentImportant.TabIndex = 5;
            this.radioBtn_notUrgentImportant.TabStop = true;
            this.radioBtn_notUrgentImportant.Text = "Важно, но не срочно";
            this.radioBtn_notUrgentImportant.UseVisualStyleBackColor = true;
            // 
            // radioBtn_notUrgentNotImportant
            // 
            this.radioBtn_notUrgentNotImportant.AutoSize = true;
            this.radioBtn_notUrgentNotImportant.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.radioBtn_notUrgentNotImportant.Location = new System.Drawing.Point(458, 295);
            this.radioBtn_notUrgentNotImportant.Margin = new System.Windows.Forms.Padding(4);
            this.radioBtn_notUrgentNotImportant.Name = "radioBtn_notUrgentNotImportant";
            this.radioBtn_notUrgentNotImportant.Size = new System.Drawing.Size(172, 23);
            this.radioBtn_notUrgentNotImportant.TabIndex = 6;
            this.radioBtn_notUrgentNotImportant.TabStop = true;
            this.radioBtn_notUrgentNotImportant.Text = "Не важно и не срочно";
            this.radioBtn_notUrgentNotImportant.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Lavender;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_save.ForeColor = System.Drawing.Color.SlateGray;
            this.btn_save.Location = new System.Drawing.Point(373, 432);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(183, 42);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Добавить";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Lavender;
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_cancel.ForeColor = System.Drawing.Color.SlateGray;
            this.btn_cancel.Location = new System.Drawing.Point(373, 495);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(183, 42);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "Отмена";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.SlateGray;
            this.dateTimePicker1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker1.Location = new System.Drawing.Point(426, 346);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(214, 25);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.SlateGray;
            this.label3.Location = new System.Drawing.Point(261, 346);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Выберите дату:";
            // 
            // AddTaskForm
            // 
            this.AcceptButton = this.btn_save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(914, 585);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.radioBtn_notUrgentNotImportant);
            this.Controls.Add(this.radioBtn_notUrgentImportant);
            this.Controls.Add(this.radioBtn_urgentNotImportant);
            this.Controls.Add(this.radioBtn_urgentImportant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddTaskForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание задачи";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioBtn_urgentImportant;
        private System.Windows.Forms.RadioButton radioBtn_urgentNotImportant;
        private System.Windows.Forms.RadioButton radioBtn_notUrgentImportant;
        private System.Windows.Forms.RadioButton radioBtn_notUrgentNotImportant;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
    }
}
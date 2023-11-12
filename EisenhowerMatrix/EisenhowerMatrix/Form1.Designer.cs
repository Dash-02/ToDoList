namespace EisenhowerMatrix
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.boxImportantNotUg = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boxImportantUg = new System.Windows.Forms.RichTextBox();
            this.boxNotImportNotUg = new System.Windows.Forms.RichTextBox();
            this.boxNotImportUg = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_done = new System.Windows.Forms.Button();
            this.btn_add_task = new System.Windows.Forms.Button();
            this.btn_date = new System.Windows.Forms.Button();
            this.btn_menu = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxImportantNotUg
            // 
            this.boxImportantNotUg.AcceptsTab = true;
            this.boxImportantNotUg.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.boxImportantNotUg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.boxImportantNotUg.ContextMenuStrip = this.contextMenuStrip1;
            this.boxImportantNotUg.EnableAutoDragDrop = true;
            this.boxImportantNotUg.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.boxImportantNotUg.ForeColor = System.Drawing.Color.White;
            this.boxImportantNotUg.Location = new System.Drawing.Point(565, 73);
            this.boxImportantNotUg.Margin = new System.Windows.Forms.Padding(2);
            this.boxImportantNotUg.MaxLength = 15000;
            this.boxImportantNotUg.Name = "boxImportantNotUg";
            this.boxImportantNotUg.Size = new System.Drawing.Size(330, 219);
            this.boxImportantNotUg.TabIndex = 0;
            this.boxImportantNotUg.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копироватьToolStripMenuItem,
            this.вставитьToolStripMenuItem,
            this.вырезатьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(163, 76);
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.вставитьToolStripMenuItem.Text = "Вставить";
            // 
            // вырезатьToolStripMenuItem
            // 
            this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            this.вырезатьToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.вырезатьToolStripMenuItem.Text = "Вырезать";
            // 
            // boxImportantUg
            // 
            this.boxImportantUg.AcceptsTab = true;
            this.boxImportantUg.BackColor = System.Drawing.Color.Tan;
            this.boxImportantUg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.boxImportantUg.ContextMenuStrip = this.contextMenuStrip1;
            this.boxImportantUg.EnableAutoDragDrop = true;
            this.boxImportantUg.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boxImportantUg.ForeColor = System.Drawing.Color.White;
            this.boxImportantUg.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.boxImportantUg.Location = new System.Drawing.Point(214, 73);
            this.boxImportantUg.Margin = new System.Windows.Forms.Padding(2);
            this.boxImportantUg.MaxLength = 15000;
            this.boxImportantUg.Name = "boxImportantUg";
            this.boxImportantUg.Size = new System.Drawing.Size(330, 219);
            this.boxImportantUg.TabIndex = 1;
            this.boxImportantUg.Text = "";
            // 
            // boxNotImportNotUg
            // 
            this.boxNotImportNotUg.AcceptsTab = true;
            this.boxNotImportNotUg.BackColor = System.Drawing.Color.DarkKhaki;
            this.boxNotImportNotUg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.boxNotImportNotUg.ContextMenuStrip = this.contextMenuStrip1;
            this.boxNotImportNotUg.EnableAutoDragDrop = true;
            this.boxNotImportNotUg.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.boxNotImportNotUg.ForeColor = System.Drawing.Color.White;
            this.boxNotImportNotUg.Location = new System.Drawing.Point(565, 332);
            this.boxNotImportNotUg.Margin = new System.Windows.Forms.Padding(2);
            this.boxNotImportNotUg.MaxLength = 15000;
            this.boxNotImportNotUg.Name = "boxNotImportNotUg";
            this.boxNotImportNotUg.Size = new System.Drawing.Size(330, 219);
            this.boxNotImportNotUg.TabIndex = 2;
            this.boxNotImportNotUg.Text = "";
            // 
            // boxNotImportUg
            // 
            this.boxNotImportUg.AcceptsTab = true;
            this.boxNotImportUg.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.boxNotImportUg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.boxNotImportUg.ContextMenuStrip = this.contextMenuStrip1;
            this.boxNotImportUg.EnableAutoDragDrop = true;
            this.boxNotImportUg.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.boxNotImportUg.ForeColor = System.Drawing.Color.Peru;
            this.boxNotImportUg.Location = new System.Drawing.Point(214, 332);
            this.boxNotImportUg.Margin = new System.Windows.Forms.Padding(2);
            this.boxNotImportUg.MaxLength = 15000;
            this.boxNotImportUg.Name = "boxNotImportUg";
            this.boxNotImportUg.Size = new System.Drawing.Size(330, 219);
            this.boxNotImportUg.TabIndex = 3;
            this.boxNotImportUg.Text = "";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Tan;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(214, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Важно и срочно";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(565, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Важно но не срочно";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Peru;
            this.label3.Location = new System.Drawing.Point(214, 312);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(330, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Не важно но срочно";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DarkKhaki;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(565, 312);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(330, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Не важно и не срочно";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.SlateGray;
            this.label5.Location = new System.Drawing.Point(71, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 35);
            this.label5.TabIndex = 8;
            this.label5.Text = "Всего задач:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btn_done);
            this.panel1.Controls.Add(this.btn_add_task);
            this.panel1.Controls.Add(this.btn_date);
            this.panel1.Controls.Add(this.btn_menu);
            this.panel1.Controls.Add(this.btn_home);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(55, 587);
            this.panel1.TabIndex = 9;
            // 
            // btn_done
            // 
            this.btn_done.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_done.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_done.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_done.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_done.Font = new System.Drawing.Font("Segoe MDL2 Assets", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_done.ForeColor = System.Drawing.Color.SlateGray;
            this.btn_done.Location = new System.Drawing.Point(-4, 216);
            this.btn_done.Margin = new System.Windows.Forms.Padding(0);
            this.btn_done.Name = "btn_done";
            this.btn_done.Size = new System.Drawing.Size(62, 55);
            this.btn_done.TabIndex = 13;
            this.btn_done.Text = "";
            this.btn_done.UseVisualStyleBackColor = true;
            this.btn_done.Click += new System.EventHandler(this.btn_done_Click);
            // 
            // btn_add_task
            // 
            this.btn_add_task.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_task.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_add_task.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_task.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_task.Font = new System.Drawing.Font("Segoe MDL2 Assets", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_task.ForeColor = System.Drawing.Color.SlateGray;
            this.btn_add_task.Location = new System.Drawing.Point(-4, 162);
            this.btn_add_task.Margin = new System.Windows.Forms.Padding(0);
            this.btn_add_task.Name = "btn_add_task";
            this.btn_add_task.Size = new System.Drawing.Size(62, 55);
            this.btn_add_task.TabIndex = 12;
            this.btn_add_task.Text = "";
            this.btn_add_task.UseVisualStyleBackColor = true;
            this.btn_add_task.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_date
            // 
            this.btn_date.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_date.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_date.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_date.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_date.Font = new System.Drawing.Font("Segoe MDL2 Assets", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_date.ForeColor = System.Drawing.Color.SlateGray;
            this.btn_date.Location = new System.Drawing.Point(-4, 108);
            this.btn_date.Margin = new System.Windows.Forms.Padding(0);
            this.btn_date.Name = "btn_date";
            this.btn_date.Size = new System.Drawing.Size(62, 55);
            this.btn_date.TabIndex = 11;
            this.btn_date.Text = "";
            this.btn_date.UseVisualStyleBackColor = true;
            this.btn_date.Click += new System.EventHandler(this.btn_date_Click);
            // 
            // btn_menu
            // 
            this.btn_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu.Font = new System.Drawing.Font("Segoe MDL2 Assets", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu.ForeColor = System.Drawing.Color.SlateGray;
            this.btn_menu.Location = new System.Drawing.Point(-4, 0);
            this.btn_menu.Margin = new System.Windows.Forms.Padding(0);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(64, 55);
            this.btn_menu.TabIndex = 10;
            this.btn_menu.Tag = "";
            this.btn_menu.Text = "";
            this.btn_menu.UseVisualStyleBackColor = true;
            // 
            // btn_home
            // 
            this.btn_home.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Segoe MDL2 Assets", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.Color.SlateGray;
            this.btn_home.Location = new System.Drawing.Point(-4, 54);
            this.btn_home.Margin = new System.Windows.Forms.Padding(0);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(62, 55);
            this.btn_home.TabIndex = 10;
            this.btn_home.Text = "";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(914, 585);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxNotImportUg);
            this.Controls.Add(this.boxNotImportNotUg);
            this.Controls.Add(this.boxImportantUg);
            this.Controls.Add(this.boxImportantNotUg);
            this.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Матрица Эйзенхауэра";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox boxImportantNotUg;
        private System.Windows.Forms.RichTextBox boxImportantUg;
        private System.Windows.Forms.RichTextBox boxNotImportNotUg;
        private System.Windows.Forms.RichTextBox boxNotImportUg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_home;
        public System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Button btn_date;
        private System.Windows.Forms.Button btn_add_task;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem;
        private System.Windows.Forms.Button btn_done;
    }
}


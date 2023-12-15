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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CopyToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CropToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_done = new System.Windows.Forms.Button();
            this.btn_add_task = new System.Windows.Forms.Button();
            this.btn_menu = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.lsBoxImportantUg = new System.Windows.Forms.ListBox();
            this.lsBoxImportantNotUg = new System.Windows.Forms.ListBox();
            this.lsBoxNotImportUg = new System.Windows.Forms.ListBox();
            this.lsBoxNotImportNotUg = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.contextMenuStrip1.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyToolStripMenu,
            this.CropToolStripMenu,
            this.PasteToolStripMenu,
            this.DeleteToolStripMenu,
            this.editToolStripMenuItem,
            this.doneToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 148);
            // 
            // CopyToolStripMenu
            // 
            this.CopyToolStripMenu.Name = "CopyToolStripMenu";
            this.CopyToolStripMenu.Size = new System.Drawing.Size(180, 24);
            this.CopyToolStripMenu.Text = "Копировать";
            this.CopyToolStripMenu.Click += new System.EventHandler(this.CopyToolStripMenu_Click);
            // 
            // CropToolStripMenu
            // 
            this.CropToolStripMenu.Name = "CropToolStripMenu";
            this.CropToolStripMenu.Size = new System.Drawing.Size(180, 24);
            this.CropToolStripMenu.Text = "Вырезать";
            this.CropToolStripMenu.Click += new System.EventHandler(this.CropToolStripMenu_Click);
            // 
            // PasteToolStripMenu
            // 
            this.PasteToolStripMenu.Name = "PasteToolStripMenu";
            this.PasteToolStripMenu.Size = new System.Drawing.Size(180, 24);
            this.PasteToolStripMenu.Text = "Вставить";
            this.PasteToolStripMenu.Click += new System.EventHandler(this.PasteToolStripMenu_Click);
            // 
            // DeleteToolStripMenu
            // 
            this.DeleteToolStripMenu.Name = "DeleteToolStripMenu";
            this.DeleteToolStripMenu.Size = new System.Drawing.Size(180, 24);
            this.DeleteToolStripMenu.Text = "Удалить";
            this.DeleteToolStripMenu.Click += new System.EventHandler(this.DeleteToolStripMenu_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.editToolStripMenuItem.Text = "Редактировать";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // doneToolStripMenuItem
            // 
            this.doneToolStripMenuItem.Name = "doneToolStripMenuItem";
            this.doneToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.doneToolStripMenuItem.Text = "Выполнено";
            this.doneToolStripMenuItem.Click += new System.EventHandler(this.TaskClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Tan;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(214, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 243);
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
            this.label2.Size = new System.Drawing.Size(330, 243);
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
            this.label3.Size = new System.Drawing.Size(330, 243);
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
            this.label4.Size = new System.Drawing.Size(330, 243);
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
            this.btn_done.Location = new System.Drawing.Point(-4, 162);
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
            this.btn_add_task.Location = new System.Drawing.Point(-4, 108);
            this.btn_add_task.Margin = new System.Windows.Forms.Padding(0);
            this.btn_add_task.Name = "btn_add_task";
            this.btn_add_task.Size = new System.Drawing.Size(62, 55);
            this.btn_add_task.TabIndex = 12;
            this.btn_add_task.Text = "";
            this.btn_add_task.UseVisualStyleBackColor = true;
            this.btn_add_task.Click += new System.EventHandler(this.btn_add_Click);
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
            // lsBoxImportantUg
            // 
            this.lsBoxImportantUg.AllowDrop = true;
            this.lsBoxImportantUg.BackColor = System.Drawing.Color.Tan;
            this.lsBoxImportantUg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsBoxImportantUg.ContextMenuStrip = this.contextMenuStrip1;
            this.lsBoxImportantUg.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lsBoxImportantUg.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.lsBoxImportantUg.ForeColor = System.Drawing.Color.White;
            this.lsBoxImportantUg.FormattingEnabled = true;
            this.lsBoxImportantUg.HorizontalScrollbar = true;
            this.lsBoxImportantUg.ItemHeight = 28;
            this.lsBoxImportantUg.Location = new System.Drawing.Point(229, 95);
            this.lsBoxImportantUg.Name = "lsBoxImportantUg";
            this.lsBoxImportantUg.Size = new System.Drawing.Size(304, 168);
            this.lsBoxImportantUg.TabIndex = 10;
            this.lsBoxImportantUg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListBox_MouseDown);
            // 
            // lsBoxImportantNotUg
            // 
            this.lsBoxImportantNotUg.AllowDrop = true;
            this.lsBoxImportantNotUg.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lsBoxImportantNotUg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsBoxImportantNotUg.ContextMenuStrip = this.contextMenuStrip1;
            this.lsBoxImportantNotUg.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.lsBoxImportantNotUg.ForeColor = System.Drawing.Color.White;
            this.lsBoxImportantNotUg.FormattingEnabled = true;
            this.lsBoxImportantNotUg.HorizontalScrollbar = true;
            this.lsBoxImportantNotUg.ItemHeight = 28;
            this.lsBoxImportantNotUg.Location = new System.Drawing.Point(580, 95);
            this.lsBoxImportantNotUg.Name = "lsBoxImportantNotUg";
            this.lsBoxImportantNotUg.Size = new System.Drawing.Size(305, 168);
            this.lsBoxImportantNotUg.TabIndex = 11;
            this.lsBoxImportantNotUg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListBox_MouseDown);
            // 
            // lsBoxNotImportUg
            // 
            this.lsBoxNotImportUg.AllowDrop = true;
            this.lsBoxNotImportUg.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lsBoxNotImportUg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsBoxNotImportUg.ContextMenuStrip = this.contextMenuStrip1;
            this.lsBoxNotImportUg.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.lsBoxNotImportUg.ForeColor = System.Drawing.Color.Peru;
            this.lsBoxNotImportUg.FormattingEnabled = true;
            this.lsBoxNotImportUg.HorizontalScrollbar = true;
            this.lsBoxNotImportUg.ItemHeight = 28;
            this.lsBoxNotImportUg.Location = new System.Drawing.Point(229, 358);
            this.lsBoxNotImportUg.Name = "lsBoxNotImportUg";
            this.lsBoxNotImportUg.Size = new System.Drawing.Size(304, 168);
            this.lsBoxNotImportUg.TabIndex = 12;
            this.lsBoxNotImportUg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListBox_MouseDown);
            // 
            // lsBoxNotImportNotUg
            // 
            this.lsBoxNotImportNotUg.AllowDrop = true;
            this.lsBoxNotImportNotUg.BackColor = System.Drawing.Color.DarkKhaki;
            this.lsBoxNotImportNotUg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsBoxNotImportNotUg.ContextMenuStrip = this.contextMenuStrip1;
            this.lsBoxNotImportNotUg.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.lsBoxNotImportNotUg.ForeColor = System.Drawing.Color.White;
            this.lsBoxNotImportNotUg.FormattingEnabled = true;
            this.lsBoxNotImportNotUg.HorizontalScrollbar = true;
            this.lsBoxNotImportNotUg.ItemHeight = 28;
            this.lsBoxNotImportNotUg.Location = new System.Drawing.Point(580, 358);
            this.lsBoxNotImportNotUg.Name = "lsBoxNotImportNotUg";
            this.lsBoxNotImportNotUg.Size = new System.Drawing.Size(305, 168);
            this.lsBoxNotImportNotUg.TabIndex = 13;
            this.lsBoxNotImportNotUg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListBox_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(914, 585);
            this.Controls.Add(this.lsBoxNotImportNotUg);
            this.Controls.Add(this.lsBoxNotImportUg);
            this.Controls.Add(this.lsBoxImportantNotUg);
            this.Controls.Add(this.lsBoxImportantUg);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_home;
        public System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Button btn_add_task;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CopyToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem PasteToolStripMenu;
        private System.Windows.Forms.Button btn_done;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenu;
        private System.Windows.Forms.ListBox lsBoxImportantUg;
        private System.Windows.Forms.ListBox lsBoxImportantNotUg;
        private System.Windows.Forms.ListBox lsBoxNotImportUg;
        private System.Windows.Forms.ListBox lsBoxNotImportNotUg;
        private System.Windows.Forms.ToolStripMenuItem CropToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doneToolStripMenuItem;
    }
}


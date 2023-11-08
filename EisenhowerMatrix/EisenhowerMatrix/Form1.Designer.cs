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
            this.boxImportantNotUg = new System.Windows.Forms.RichTextBox();
            this.boxImportantUg = new System.Windows.Forms.RichTextBox();
            this.boxNotImportNotUg = new System.Windows.Forms.RichTextBox();
            this.boxNotImportUg = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxImportantNotUg
            // 
            this.boxImportantNotUg.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.boxImportantNotUg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.boxImportantNotUg.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.boxImportantNotUg.ForeColor = System.Drawing.Color.White;
            this.boxImportantNotUg.Location = new System.Drawing.Point(753, 90);
            this.boxImportantNotUg.Name = "boxImportantNotUg";
            this.boxImportantNotUg.Size = new System.Drawing.Size(440, 270);
            this.boxImportantNotUg.TabIndex = 0;
            this.boxImportantNotUg.Text = "";
            // 
            // boxImportantUg
            // 
            this.boxImportantUg.BackColor = System.Drawing.Color.Tan;
            this.boxImportantUg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.boxImportantUg.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boxImportantUg.ForeColor = System.Drawing.Color.White;
            this.boxImportantUg.Location = new System.Drawing.Point(286, 90);
            this.boxImportantUg.Name = "boxImportantUg";
            this.boxImportantUg.Size = new System.Drawing.Size(440, 270);
            this.boxImportantUg.TabIndex = 1;
            this.boxImportantUg.Text = "";
            // 
            // boxNotImportNotUg
            // 
            this.boxNotImportNotUg.BackColor = System.Drawing.Color.DarkKhaki;
            this.boxNotImportNotUg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.boxNotImportNotUg.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.boxNotImportNotUg.ForeColor = System.Drawing.Color.White;
            this.boxNotImportNotUg.Location = new System.Drawing.Point(753, 408);
            this.boxNotImportNotUg.Name = "boxNotImportNotUg";
            this.boxNotImportNotUg.Size = new System.Drawing.Size(440, 270);
            this.boxNotImportNotUg.TabIndex = 2;
            this.boxNotImportNotUg.Text = "";
            // 
            // boxNotImportUg
            // 
            this.boxNotImportUg.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.boxNotImportUg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.boxNotImportUg.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.boxNotImportUg.ForeColor = System.Drawing.Color.White;
            this.boxNotImportUg.Location = new System.Drawing.Point(286, 408);
            this.boxNotImportUg.Name = "boxNotImportUg";
            this.boxNotImportUg.Size = new System.Drawing.Size(440, 270);
            this.boxNotImportUg.TabIndex = 3;
            this.boxNotImportUg.Text = "";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Tan;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(286, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Важно и срочно";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(753, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(440, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Важно но не срочно";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Peru;
            this.label3.Location = new System.Drawing.Point(286, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(440, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Не важно но срочно";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DarkKhaki;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(753, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(440, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Не важно и не срочно";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(93, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 37);
            this.label5.TabIndex = 8;
            this.label5.Text = "Всего задач:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(87, 723);
            this.panel1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::EisenhowerMatrix.Properties.Resources.icons8_главная_77;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(0, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 68);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1219, 720);
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
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Матрица Эйзенхауэра";
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
        private System.Windows.Forms.Button button1;
    }
}


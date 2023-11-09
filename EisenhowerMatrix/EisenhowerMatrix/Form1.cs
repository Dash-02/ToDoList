//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Drawing.Drawing2D;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace EisenhowerMatrix
//{
//public partial class Form1 : Form
//{
//    public Form1()
//    {
//        InitializeComponent();
//    }
//    private void Form1_Load(object sender, EventArgs e)
//    {
//        boxImportantUg.SetInnerMargins(10, 8, 8, 8);
//        boxImportantNotUg.SetInnerMargins(10, 8, 8, 8);
//        boxNotImportUg.SetInnerMargins(10, 8, 8, 8);
//        boxNotImportNotUg.SetInnerMargins(10, 8, 8, 8);
//    }
//    private void buttonAddTask_Click(object sender, EventArgs e)
//    {
//        // Добавление задачи в RichTextBox
//        //richTextBox1.AppendText("Новая задача\n");

//        // Обновление количества задач в Label
//        //label5.Text = "Количество задач: " + richTextBox1.Lines.Length;
//    }

//    private void btn_home_Click(object sender, EventArgs e)
//    {

//    }

//    private void btn_date_Click(object sender, EventArgs e)
//    {

//    }

//    private void btn_add_task_Click(object sender, EventArgs e)
//    {

//    }

//    private void btn_done_Click(object sender, EventArgs e)
//    {

//    }
//}
//}
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using System;

namespace WinFormsApp1 
{
    
    public partial class Form1 : Form
    {
        private System.ComponentModel.IContainer components = null;
        ListView DragSrc; ListBox DragTgt;
        int idxDragItm, idxDropItm;
        Rectangle dragBox;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }
        public Form1()
        {
            SuspendLayout();
            DragSrc = new ListView()
            {
                Location = new Point(73, 54),
                Name = "DragSrc"
            ,
                Size = new Size(206, 130),
                TabIndex = 3
            ,
                UseCompatibleStateImageBehavior = false,
                View = View.Details
        };
        DragSrc.Columns.AddRange(new ColumnHeader[] {
            new ColumnHeader() { Text = "Имя", Width = 100 }
            , new ColumnHeader() { Text = "Фамилия", Width = 100 } });
        DragSrc.MouseDown += DragSrc_MouseDown;
        DragSrc.MouseMove += DragSrc_MouseMove;
        DragSrc.MouseUp += DragSrc_MouseUp;
        DragTgt = new ListBox()
        {
            AllowDrop = true,
            FormattingEnabled = true,
            ItemHeight = 15,
            Location = new Point(384, 54),
            Name = "DragTgt",
            Size = new Size(146, 124),
            TabIndex = 4
        };
        DragTgt.DragDrop += DragTgt_DragDrop;
        DragTgt.DragOver += DragTgt_DragOver;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size(800, 450);
        Controls.AddRange(new Control[] { DragTgt, DragSrc });
        Name = Text = "Form1";
        ResumeLayout(false);
    }
    protected override void OnLoad(EventArgs e)
    {
        DragSrc.Items.AddRange(
            new ListViewItem[] { new ListViewItem(new string[]{ "Иван", "Петров" })
            , new ListViewItem(new string[]{ "Алексей", "Сидоров" })
            , new ListViewItem(new string[]{ "Дормидонт", "Семинарский" })});
    }
    private void DragSrc_MouseDown(object sender, MouseEventArgs e)
    {
        idxDragItm = DragSrc.Items.IndexOf(DragSrc.GetItemAt(e.X, e.Y));
        if (idxDragItm != ListBox.NoMatches)
        {
            Size dragSize = SystemInformation.DragSize;
            dragBox = new Rectangle(
                new Point(e.X - (dragSize.Width / 2), e.Y - (dragSize.Height / 2))
                , dragSize);
        }
        else dragBox = Rectangle.Empty;
    }
    private void DragSrc_MouseUp(object sender, MouseEventArgs e)
    {
        dragBox = Rectangle.Empty;
    }
    private void DragSrc_MouseMove(object sender, MouseEventArgs e)
    {
        if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
        {
            if (dragBox != Rectangle.Empty && !dragBox.Contains(e.X, e.Y))
            {
                DragDropEffects dropEffect = DragSrc.DoDragDrop(
                    DragSrc.Items[idxDragItm], DragDropEffects.All);
                if (dropEffect == DragDropEffects.Move)
                {
                    DragSrc.Items.RemoveAt(idxDragItm);
                    if (idxDragItm > 0)
                        DragSrc.Items[idxDragItm - 1].Selected = true;
                    else if (DragSrc.Items.Count > 0)
                        DragSrc.Items[0].Selected = true;
                }
            }
        }
    }
    private void DragTgt_DragOver(object sender, DragEventArgs e)
    {
        if ((e.KeyState & 8) == 8 && (e.AllowedEffect & DragDropEffects.Copy)
                == DragDropEffects.Copy)
            e.Effect = DragDropEffects.Copy;
        else if ((e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move)
            e.Effect = DragDropEffects.Move;
        else e.Effect = DragDropEffects.None;
        idxDropItm = DragTgt.IndexFromPoint(
            DragTgt.PointToClient(new Point(e.X, e.Y)));
    }
    private void DragTgt_DragDrop(object sender, DragEventArgs e)
    {
        var item = e.Data.GetData(typeof(ListViewItem));
        if (e.Effect == DragDropEffects.Copy || e.Effect == DragDropEffects.Move)
        {
            if (idxDropItm != ListBox.NoMatches)
                DragTgt.Items.Insert(idxDropItm, ((ListViewItem)item).ToString());
            else
                DragTgt.Items.Add(((ListViewItem)item).ToString());
        }
    }
}
    internal static class Program 
    {
        
    }
}
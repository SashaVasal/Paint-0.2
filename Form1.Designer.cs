namespace Graph
{
    partial class WindowsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowsForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Line = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BrokenLine = new System.Windows.Forms.Button();
            this.Pen = new System.Windows.Forms.Button();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.ColorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.DropDownMenu = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.Line);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.BrokenLine);
            this.panel1.Controls.Add(this.Pen);
            this.panel1.Location = new System.Drawing.Point(15, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 216);
            this.panel1.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.Location = new System.Drawing.Point(130, 119);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Hand";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Hand_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Location = new System.Drawing.Point(130, 74);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Zoom";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Zoom_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(15, 177);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 0;
            this.button5.Text = "Pie";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.PieClick);
            // 
            // Line
            // 
            this.Line.Location = new System.Drawing.Point(15, 148);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(75, 23);
            this.Line.TabIndex = 0;
            this.Line.Text = "Line";
            this.Line.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Line.UseVisualStyleBackColor = true;
            this.Line.Click += new System.EventHandler(this.LineClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Square";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SquareClick);
            // 
            // BrokenLine
            // 
            this.BrokenLine.Location = new System.Drawing.Point(15, 75);
            this.BrokenLine.Name = "BrokenLine";
            this.BrokenLine.Size = new System.Drawing.Size(75, 23);
            this.BrokenLine.TabIndex = 0;
            this.BrokenLine.Text = "Ellipse";
            this.BrokenLine.UseVisualStyleBackColor = true;
            this.BrokenLine.Click += new System.EventHandler(this.EllipseClick);
            // 
            // Pen
            // 
            this.Pen.Location = new System.Drawing.Point(15, 14);
            this.Pen.Name = "Pen";
            this.Pen.Size = new System.Drawing.Size(75, 23);
            this.Pen.TabIndex = 0;
            this.Pen.Text = "pen";
            this.Pen.UseVisualStyleBackColor = true;
            this.Pen.Click += new System.EventHandler(this.PenClick);
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.SystemColors.Control;
            this.canvas.Location = new System.Drawing.Point(293, 34);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(839, 526);
            this.canvas.TabIndex = 4;
            this.canvas.TabStop = false;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
            // 
            // ColorDialog1
            // 
            this.ColorDialog1.AnyColor = true;
            this.ColorDialog1.Color = System.Drawing.Color.Gray;
            this.ColorDialog1.FullOpen = true;
            this.ColorDialog1.ShowHelp = true;
            this.ColorDialog1.SolidColorOnly = true;
            this.ColorDialog1.HelpRequest += new System.EventHandler(this.Form1_Load);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1154, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // DropDownMenu
            // 
            this.DropDownMenu.Location = new System.Drawing.Point(0, 0);
            this.DropDownMenu.Name = "DropDownMenu";
            this.DropDownMenu.Size = new System.Drawing.Size(75, 23);
            this.DropDownMenu.TabIndex = 0;
            // 
            // checkBox2
            // 
            this.checkBox2.Location = new System.Drawing.Point(0, 0);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(104, 24);
            this.checkBox2.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(0, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 24);
            this.checkBox1.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(0, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 0;
            // 
            // WindowsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1154, 582);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.panel1);
            this.Name = "WindowsForm";
            this.Text = "WindowsForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Button Line;
        private System.Windows.Forms.Button BrokenLine;
        private System.Windows.Forms.Button Pen;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ColorDialog ColorDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Button DropDownMenu;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.CheckBox checkBox2;
        //private System.Windows.Forms.mous
    }
}
namespace Graph
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.Number = new System.Windows.Forms.Label();
            this.Width_Bar = new System.Windows.Forms.TrackBar();
            this.Line = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BrokenLine = new System.Windows.Forms.Button();
            this.Pen = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ChangeColor = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.ColorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Width_Bar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.Number);
            this.panel1.Controls.Add(this.Width_Bar);
            this.panel1.Controls.Add(this.Line);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.BrokenLine);
            this.panel1.Controls.Add(this.Pen);
            this.panel1.Location = new System.Drawing.Point(15, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 216);
            this.panel1.TabIndex = 1;
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
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.Location = new System.Drawing.Point(151, 46);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(13, 13);
            this.Number.TabIndex = 5;
            this.Number.Text = "5";
            // 
            // Width_Bar
            // 
            this.Width_Bar.Location = new System.Drawing.Point(115, 3);
            this.Width_Bar.Minimum = 1;
            this.Width_Bar.Name = "Width_Bar";
            this.Width_Bar.Size = new System.Drawing.Size(104, 45);
            this.Width_Bar.TabIndex = 5;
            this.Width_Bar.TickFrequency = 2;
            this.Width_Bar.Value = 5;
            this.Width_Bar.Scroll += new System.EventHandler(this.Width_Bar_Click);
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "broken line";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BrokenClick);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.ChangeColor);
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Location = new System.Drawing.Point(12, 266);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 216);
            this.panel2.TabIndex = 2;
            // 
            // ChangeColor
            // 
            this.ChangeColor.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.ChangeColor.Location = new System.Drawing.Point(25, 28);
            this.ChangeColor.Name = "ChangeColor";
            this.ChangeColor.Size = new System.Drawing.Size(75, 23);
            this.ChangeColor.TabIndex = 1;
            this.ChangeColor.Text = "Color";
            this.ChangeColor.UseCompatibleTextRendering = true;
            this.ChangeColor.UseVisualStyleBackColor = true;
            this.ChangeColor.UseWaitCursor = true;
            this.ChangeColor.Click += new System.EventHandler(this.ChangeColor_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(252, 210);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
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
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.Location = new System.Drawing.Point(130, 119);
            this.button4.Name = "Hand";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Hand";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Hand_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1154, 582);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Width_Bar)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Button Line;
        private System.Windows.Forms.Button BrokenLine;
        private System.Windows.Forms.Button Pen;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label Number;
        public System.Windows.Forms.TrackBar Width_Bar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button ChangeColor;
        public System.Windows.Forms.ColorDialog ColorDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        //private System.Windows.Forms.mous
    }
}
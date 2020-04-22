using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace Graph
{
    enum States
    {
        MouseUp = 0,
        MouseDown = 1      
    }

    
    public partial class Form1 : Form
    {
        readonly Tool tool;     
        readonly ToolPicker picker = new ToolPicker();
        PaintEventArgs e; 

        public Form1()
        {
            
            InitializeComponent();
            tool = new Tool(canvas.Height, canvas.Width)
            {
                bit = new Bitmap(3000, 3000),
                drawable = new Draw_Ellipse()
            };
        }
 
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // Event
        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {

            if (tool.IsMouseDown == true)
            {
                if(tool.drawable.GetName() == "Pen")
                {
                    tool.AddH(tool);
                    tool.OldMovePoint = tool.MovePoint;
                }
                
                tool.MovePoint = e.Location;              
                Refresh();

                
            }
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {           
            if (e.Button == MouseButtons.Left)
            {              
                tool.StartPoint = e.Location;
                tool.MovePoint = e.Location;
                tool.OldMovePoint = tool.MovePoint;
                tool.IsMouseDown = true;
                if (tool.drawable.GetName() == "Zoom") tool.drawable.Draw(this.e, tool);


            }
        }
        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            
            if (tool.IsMouseDown == true)
            {
                tool.OldMovePoint = tool.MovePoint;
                tool.MovePoint = e.Location;

                if (tool.drawable.GetName() != "Zoom") tool.AddH(tool);
                tool.IsMouseDown = false;             
                canvas.Image = tool.bit;                   
            }
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {

            if (tool.drawable.GetName() != "Zoom") tool.drawable.Draw(e, tool);
            
            foreach (Tool f in tool.h)
            {            
                 f.drawable.Draw(e, f);
            }
            this.e = e;
        }

        // Button
        public void PenClick(object sender, EventArgs e)
        {
            picker.PickPen(ref tool.drawable);
        }
        private void SquareClick(object sender, EventArgs e)
        {
            picker.PickSquare(ref tool.drawable);
        }
        private void EllipseClick(object sender, EventArgs e)
        {
            picker.PickEllipse(ref tool.drawable);
        }
        private void LineClick(object sender, EventArgs e)
        {
            picker.PickLine(ref tool.drawable);
        }
        public void BrokenClick(object sender, EventArgs e)
        {
            //picker.PickPolyline(tool.drawable);
        }
        
        

        private void ChangeColor_Click(object sender, EventArgs e)
        {
           
            if (ColorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            tool.color = ColorDialog1.Color;
            
        }
        private void Width_Bar_Click(object sender, EventArgs e)
        {
            tool.width = Width_Bar.Value;         
            Number.Text = Convert.ToString(Width_Bar.Value);         
            
        }

        private void Zoom_Click(object sender, EventArgs e)
        {
            picker.PickZoom(ref tool.drawable);
        }
        private void Hand_Click(object sender, EventArgs e)
        {
            picker.PickHand(ref tool.drawable);
        }
    }
}


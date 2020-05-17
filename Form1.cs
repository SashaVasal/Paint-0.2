using System;
using System.Drawing;
using System.Windows.Forms;


namespace Graph
{
    
    public partial class WindowsForm : Form
    {
        readonly History history = new History();
        readonly Parametr tool;
        readonly ToolPicker picker = new ToolPicker();
        PaintEventArgs e;
        readonly Buttons buttons = new Buttons();
        
        public WindowsForm()
        {
           
            InitializeComponent();
            tool = new Parametr()
            {            
                bit = new Bitmap(3000, 3000),
                drawable = new Draw_Ellipse()
            };
            tool.viewSize.Height = canvas.Height;
            tool.viewSize.Width = canvas.Width;
            buttons.ColorDialog1 = ColorDialog1;
            buttons.tool = tool;
            buttons.panel1 = panel1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {

            if (tool.IsMouseDown == true)
            {
                tool.drawable.ClickMove(this.e, tool, history);               
                tool.MovePoint = e.Location;
                Refresh();
            }
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {         
            tool.StartPoint = e.Location;
            tool.MovePoint = e.Location;
            tool.OldMovePoint = tool.MovePoint;
            if(e.Button == MouseButtons.Left)
            {
                tool.drawable.ClickDownLeft(this.e, tool, history);
            }
            else
            {
                tool.drawable.ClickDownRight(this.e, tool, history);
            }                     
            tool.IsMouseDown = true;                                  

        }
        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {

            if (tool.IsMouseDown == true)
            {
                tool.OldMovePoint = tool.MovePoint;
                tool.MovePoint = e.Location;
                if (e.Button == MouseButtons.Left)
                {
                    tool.drawable.ClickUp(this.e, tool, history);
                }
                
                tool.IsMouseDown = false;
                canvas.Image = tool.bit;                                
            }
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            
            tool.drawable.Draw(e, tool, history);                    
            foreach (Parametr f in history.history)
            {
                f.drawable.Draw(e, f, history);
            }
            this.e = e;
        }

        // Button
        public void PenClick(object sender, EventArgs e)
        {
            
          

            foreach (Control f in buttons.buttons)
            {
                Controls.Remove(f);
            }
            picker.PickPen(ref tool.drawable);
            buttons.PenClick();
            foreach (Control f in buttons.buttons)
            {
                Controls.Add(f);
            }
            
        }
        private void SquareClick(object sender, EventArgs e)
        {
            foreach (Control f in buttons.buttons)
            {
                Controls.Remove(f);
            }
            picker.PickSquare(ref tool.drawable);
            buttons.SquareClick();
            foreach (Control f in buttons.buttons)
            {
                Controls.Add(f);              
            }

        }
        private void EllipseClick(object sender, EventArgs e)
        {
            
            foreach (Control f in buttons.buttons)
            {
                Controls.Remove(f);
            }
            picker.PickEllipse(ref tool.drawable);
            buttons.EllipseClick();
            foreach (Control f in buttons.buttons)
            {
                Controls.Add(f);
            }
        }
        private void LineClick(object sender, EventArgs e)
        {
            
            foreach (Control f in buttons.buttons)
            {
                Controls.Remove(f);
            }
            picker.PickLine(ref tool.drawable);
            buttons.LineClick();
            foreach (Control f in buttons.buttons)
            {
                Controls.Add(f);
            }
        }
        private void PieClick(object sender, EventArgs e)
        {
            foreach (Control f in buttons.buttons)
            {
                Controls.Remove(f);
            }
            picker.PickPie(ref tool.drawable);
            buttons.PieClick();
            foreach (Control f in buttons.buttons)
            {
                Controls.Add(f);
            }
        }
        public void BrokenClick(object sender, EventArgs e)
        {
            //picker.PickPolyline(tool.drawable);
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


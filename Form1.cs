using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Graph
{
    
   
    
    public partial class Form1 : Form
    {
        Tool tool = new Tool();
        Figure draw = new Figure();
        
        public Form1()
        {
            tool.bit = new Bitmap(1000,1000);
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // Event
        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            
            if(tool.IsMouseDown == true)
            {
                tool.MovePoint = e.Location;
                Refresh();
                if(tool.count == 1)
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        Graphics g = Graphics.FromImage(tool.bit);
                        tool.Draw(g);
                        canvas.Image = tool.bit;
                        tool.newPoint = tool.MovePoint;
                    }
                }
                

            }    
            
        }


        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                
                tool.IsMouseDown = true;
                tool.StartPoint = e.Location;

                if (tool.count != 5 || tool.ActiveBrake == false)
                {
                    tool.newPoint = e.Location;
                    tool.ActiveBrake = true;
                }
                
            }
            
              
        }
        
        

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            if(tool.IsMouseDown == true)
            {
                tool.MovePoint = e.Location;        
                tool.IsMouseDown = false;  
                
                Graphics g = Graphics.FromImage(tool.bit);               
                tool.Draw(g);          
                if(tool.count == 5)
                {
                    tool.newPoint = tool.MovePoint;
                }
                canvas.Image =tool.bit;
            }
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            
            tool.Draw(e);    
            
        }


        // Buttons
        public void PenClick(object sender, EventArgs e)
        {
            tool.count = 1;
            tool.ActiveBrake = false;
        }
        private void SquareClick(object sender, EventArgs e)
        {
            tool.count = 2;
            tool.ActiveBrake = false;
        }
        private void EllipseClick(object sender, EventArgs e)
        {
            tool.count = 3;
            tool.ActiveBrake = false;
        }
        private void LineClick(object sender, EventArgs e)
        {
            tool.count = 4;
            tool.ActiveBrake = false;
        }
        public void BrokenClick(object sender, EventArgs e)
        {
            tool.count = 5;
            tool.ActiveBrake = false;
        }



        private void ChangeColor_Click(object sender, EventArgs e)
        {

            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            tool._color = colorDialog1.Color;
            tool.pen = new Pen(tool._color, tool.width_pen);

        }
        private void Width_Bar_Click(object sender, EventArgs e)
        {
            tool.width_pen = Width_Bar.Value;
            Number.Text = Convert.ToString(Width_Bar.Value);
            tool.pen = new Pen(tool._color, tool.width_pen);
        }
    }
}

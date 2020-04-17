using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace Graph
{



    public partial class Form1 : Form
    {
        Tool tool = new Tool();
        Figure draw = new Figure();
        //List<draw> draws;
        Graphics g;
        List<Figure> draws = new List<Figure>();
        List<Figure> remove_draws = new List<Figure>();
        public Form1()
        {
            //draws.Add(draw);
            //draws.Add(draw);
            draw.bit = new Bitmap(1000, 1000);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // Event
        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {

            if (draw.IsMouseDown == true)
            {
                draw.MovePoint = e.Location;

                Refresh();
                if (draw.count == 1)
                {
                    if (e.Button == MouseButtons.Left)
                    {                                                             
                        draws.Add(new Figure() { count = draw.count, newPoint = draw.newPoint, StartPoint = draw.StartPoint, MovePoint = draw.MovePoint, pen = draw.pen });
                        draw.newPoint = draw.MovePoint;
                       
                    }
                }


            }

        }


        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            remove_draws.Clear();
            if (e.Button == MouseButtons.Left)
            {

                draw.IsMouseDown = true;
                draw.StartPoint = e.Location;

                if (draw.count != 5 || draw.ActiveBrake == false)
                {

                    draw.newPoint = e.Location;

                    draw.ActiveBrake = true;
                }

            }


        }



        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
         
            if (draw.IsMouseDown == true)
            {

                draw.MovePoint = e.Location;
                draw.IsMouseDown = false;

                draws.Add(new Figure() { count = draw.count, newPoint = draw.newPoint, StartPoint = draw.StartPoint, MovePoint = draw.MovePoint, pen = draw.pen , });

                

                         
                if (draw.count == 5)
                {
                    draw.newPoint = draw.MovePoint;
                }
                canvas.Image =draw.bit;
            }
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {    
               foreach (Figure d in draws)
               {
                    d.Draw(e);
               }
               draw.Draw(e);
        }


        // Buttons
        public void PenClick(object sender, EventArgs e)
        {
            draw.count = 1;
            draw.ActiveBrake = false;
        }
        private void SquareClick(object sender, EventArgs e)
        {
            draw.count = 2;
            draw.ActiveBrake = false;
        }
        private void EllipseClick(object sender, EventArgs e)
        {
            draw.count = 3;
            draw.ActiveBrake = false;
        }
        private void LineClick(object sender, EventArgs e)
        {
            draw.count = 4;
            draw.ActiveBrake = false;
        }
        public void BrokenClick(object sender, EventArgs e)
        {
            draw.count = 5;
            draw.ActiveBrake = false;
        }
        public void Delete_LastClick(object sender, EventArgs e)
        {
            Refresh();
            if (draws.Count > 0)
            {
                remove_draws.Add(draws[draws.Count - 1]);
                draws.RemoveAt(draws.Count - 1);
                
            }
            Refresh();

        }
        public void Restore_LastClick(object sender, EventArgs e)
        {
            Refresh();
            if (remove_draws.Count > 0)
            {
                draws.Add(remove_draws[remove_draws.Count - 1]);
                remove_draws.RemoveAt(remove_draws.Count - 1);

            }
            Refresh();
        }
        

        private void ChangeColor_Click(object sender, EventArgs e)
        {

            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            draw._color = colorDialog1.Color;
            draw.pen = new Pen(draw._color, draw.width_pen);

        }
        private void Width_Bar_Click(object sender, EventArgs e)
        {
            draw.width_pen = Width_Bar.Value;
            Number.Text = Convert.ToString(Width_Bar.Value);
            draw.pen = new Pen(draw._color, draw.width_pen);
        }
    }
}

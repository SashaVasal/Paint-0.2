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

   
    public class Figure
    {
        public Point newPoint = new Point(0,0);
        public bool ActiveBrake = false;

        public int count = 1;
        //Square
        public void DrawSquare(PaintEventArgs e, Pen pen, Point StartPoint, Point MovePoint)
        {
            //e.Graphics.DrawRectangle(pen, StartPoint.X, StartPoint.Y, StartPoint.X - MovePoint.X, StartPoint.Y - MovePoint.Y);
            if(MovePoint.X > StartPoint.X && MovePoint.Y > StartPoint.Y)
            {
                e.Graphics.DrawRectangle(pen, StartPoint.X, StartPoint.Y, MovePoint.X - StartPoint.X, MovePoint.Y - StartPoint.Y);
            }
            else if (MovePoint.X < StartPoint.X && MovePoint.Y < StartPoint.Y)
            {
                e.Graphics.DrawRectangle(pen, MovePoint.X, MovePoint.Y,  StartPoint.X - MovePoint.X , StartPoint.Y - MovePoint.Y);
            }
            if (MovePoint.X > StartPoint.X && MovePoint.Y < StartPoint.Y)
            {
                e.Graphics.DrawRectangle(pen, StartPoint.X, MovePoint.Y,  MovePoint.X - StartPoint.X, StartPoint.Y - MovePoint.Y);
            }
            else if (MovePoint.X < StartPoint.X && MovePoint.Y > StartPoint.Y)
            {
                e.Graphics.DrawRectangle(pen, MovePoint.X, StartPoint.Y, StartPoint.X - MovePoint.X, MovePoint.Y - StartPoint.Y);
            }
        }
        public void DrawSquare(Graphics g, Pen pen, Point StartPoint, Point MovePoint)
        {
            if (MovePoint.X > StartPoint.X && MovePoint.Y > StartPoint.Y)
            {
                g.DrawRectangle(pen, StartPoint.X, StartPoint.Y, MovePoint.X - StartPoint.X, MovePoint.Y - StartPoint.Y);
            }
            else if (MovePoint.X < StartPoint.X && MovePoint.Y < StartPoint.Y)
            {
                g.DrawRectangle(pen, MovePoint.X, MovePoint.Y, StartPoint.X - MovePoint.X, StartPoint.Y - MovePoint.Y);
            }
            if (MovePoint.X > StartPoint.X && MovePoint.Y < StartPoint.Y)
            {
                g.DrawRectangle(pen, StartPoint.X, MovePoint.Y, MovePoint.X - StartPoint.X, StartPoint.Y - MovePoint.Y);
            }
            else if (MovePoint.X < StartPoint.X && MovePoint.Y > StartPoint.Y)
            {
               g.DrawRectangle(pen, MovePoint.X, StartPoint.Y, StartPoint.X - MovePoint.X, MovePoint.Y - StartPoint.Y);
            }
        }
        //Line
        public void DrawLine(PaintEventArgs e, Pen pen, Point StartPoint, Point MovePoint)
        {
            e.Graphics.DrawLine(pen, StartPoint.X, StartPoint.Y, MovePoint.X, MovePoint.Y);
        }
        public void DrawLine(Graphics g, Pen pen, Point StartPoint, Point MovePoint)
        {
            g.DrawLine(pen, StartPoint.X, StartPoint.Y, MovePoint.X, MovePoint.Y);
        }
        //Pen 
        public void Pen(Graphics g, Pen pen, Point MovePoint)
        {
            g.DrawLine(pen, MovePoint.X, MovePoint.Y, newPoint.X, newPoint.Y);
            g.DrawLine(pen, MovePoint.X, MovePoint.Y, newPoint.X, newPoint.Y + 1);
            g.DrawLine(pen, MovePoint.X, MovePoint.Y, newPoint.X + 1, newPoint.Y);
            g.DrawLine(pen, MovePoint.X, MovePoint.Y, newPoint.X, newPoint.Y);
        }
        //Ellipse
        public void DrawEllipse(PaintEventArgs e, Pen pen, Point StartPoint, Point MovePoint)
        {
            e.Graphics.DrawEllipse(pen, StartPoint.X, StartPoint.Y, MovePoint.X - StartPoint.X, MovePoint.Y - StartPoint.Y);
        }
        public void DrawEllipse(Graphics g, Pen pen, Point StartPoint, Point MovePoint)
        {
            g.DrawEllipse(pen, StartPoint.X, StartPoint.Y, MovePoint.X - StartPoint.X, MovePoint.Y - StartPoint.Y);
        }
        //Polyline
        public void DrawPolyline(PaintEventArgs e, Pen pen, Point StartPoint, Point MovePoint)
        {
            e.Graphics.DrawLine(pen, newPoint.X, newPoint.Y, MovePoint.X, MovePoint.Y);
        }
        public void DrawPolyline(Graphics g, Pen pen,  Point StartPoint, Point MovePoint)
        {
            g.DrawLine(pen, newPoint.X, newPoint.Y, MovePoint.X, MovePoint.Y);
        }
    }
    public class Tool : Figure
    {
        
           
        public int width_pen = 5;    
        public Color _color = Color.Black;
        public bool IsMouseDown = false;

        public Point StartPoint = new Point();
        public Point MovePoint = new Point();
       

        public Pen pen = new Pen(Color.Black, 5);

        public Bitmap bit;
        public void Draw(PaintEventArgs e)
        {
            switch (count)
            {
                          
                case 2:
                    DrawSquare(e, pen, StartPoint, MovePoint);
                    break;
                case 3:
                    DrawEllipse(e, pen, StartPoint, MovePoint);
                    break;
                case 4:
                    DrawLine(e, pen, StartPoint, MovePoint);
                    break;
                case 5:
                    DrawPolyline(e, pen, StartPoint, MovePoint);
                    break;
            }
        }
        public void Draw(Graphics g)
        {
            switch (count)
            {
                case 1:
                    Pen(g, pen, MovePoint);
                    break;
                case 2:
                    DrawSquare(g, pen, StartPoint, MovePoint);
                    break;
                case 3:
                    DrawEllipse(g, pen, StartPoint, MovePoint);
                    break;
                case 4:
                    DrawLine(g, pen, StartPoint, MovePoint);
                    break;
                case 5:
                    DrawPolyline(g, pen, StartPoint, MovePoint);
                    break;
            }
        }
    }
}

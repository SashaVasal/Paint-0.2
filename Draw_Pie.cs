using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph
{
    public class Draw_Pie : IDrawable
    {
        public string GetName()
        {
            return "Figure";
        }
        public void Draw(PaintEventArgs e, Parametr tool, History history)
        {
            if (tool.brush)
            {
                if (tool.hatchBrush)
                {
                    HatchBrush pen = new HatchBrush(HatchStyle.Vertical, Color.Green, tool.color);
                    List<HatchStyle> hatchStyles = new List<HatchStyle>();
                    //hatchStyles.Add(HatchStyle.)
                    if (tool.MovePoint.X > tool.StartPoint.X && tool.MovePoint.Y > tool.StartPoint.Y)
                    {
                        e.Graphics.FillPie(pen, tool.StartPoint.X, tool.StartPoint.Y, tool.MovePoint.X - tool.StartPoint.X, tool.MovePoint.Y - tool.StartPoint.Y, tool.startAngle, tool.sweepAngle);
                    }
                    else if (tool.MovePoint.X < tool.StartPoint.X && tool.MovePoint.Y < tool.StartPoint.Y)
                    {
                        e.Graphics.FillPie(pen, tool.MovePoint.X, tool.MovePoint.Y, tool.StartPoint.X - tool.MovePoint.X, tool.StartPoint.Y - tool.MovePoint.Y, tool.startAngle, tool.sweepAngle);
                    }
                    if (tool.MovePoint.X > tool.StartPoint.X && tool.MovePoint.Y < tool.StartPoint.Y)
                    {
                        e.Graphics.FillPie(pen, tool.StartPoint.X, tool.MovePoint.Y, tool.MovePoint.X - tool.StartPoint.X, tool.StartPoint.Y - tool.MovePoint.Y, tool.startAngle, tool.sweepAngle);
                    }
                    else if (tool.MovePoint.X < tool.StartPoint.X && tool.MovePoint.Y > tool.StartPoint.Y)
                    {
                        e.Graphics.FillPie(pen, tool.MovePoint.X, tool.StartPoint.Y, tool.StartPoint.X - tool.MovePoint.X, tool.MovePoint.Y - tool.StartPoint.Y, tool.startAngle, tool.sweepAngle);
                    }

                }
                else
                {
                    SolidBrush pen = new SolidBrush(tool.color);

                    if (tool.MovePoint.X > tool.StartPoint.X && tool.MovePoint.Y > tool.StartPoint.Y)
                    {
                        e.Graphics.FillPie(pen, tool.StartPoint.X, tool.StartPoint.Y, tool.MovePoint.X - tool.StartPoint.X, tool.MovePoint.Y - tool.StartPoint.Y, tool.startAngle, tool.sweepAngle);
                    }
                    else if (tool.MovePoint.X < tool.StartPoint.X && tool.MovePoint.Y < tool.StartPoint.Y)
                    {
                        e.Graphics.FillPie(pen, tool.MovePoint.X, tool.MovePoint.Y, tool.StartPoint.X - tool.MovePoint.X, tool.StartPoint.Y - tool.MovePoint.Y, tool.startAngle, tool.sweepAngle);
                    }
                    if (tool.MovePoint.X > tool.StartPoint.X && tool.MovePoint.Y < tool.StartPoint.Y)
                    {
                        e.Graphics.FillPie(pen, tool.StartPoint.X, tool.MovePoint.Y, tool.MovePoint.X - tool.StartPoint.X, tool.StartPoint.Y - tool.MovePoint.Y, tool.startAngle, tool.sweepAngle);
                    }
                    else if (tool.MovePoint.X < tool.StartPoint.X && tool.MovePoint.Y > tool.StartPoint.Y)
                    {
                        e.Graphics.FillPie(pen, tool.MovePoint.X, tool.StartPoint.Y, tool.StartPoint.X - tool.MovePoint.X, tool.MovePoint.Y - tool.StartPoint.Y, tool.startAngle, tool.sweepAngle);
                    }
                }
            }
            else
            {
                Pen pen = new Pen(tool.color, tool.width);
                if (tool.dashPattern == true)
                {
                    pen.DashCap = System.Drawing.Drawing2D.DashCap.Round;
                    pen.DashPattern = new float[] { 4.0F, 2.0F, 1.0F, 3.0F };
                }

                if (tool.MovePoint.X > tool.StartPoint.X && tool.MovePoint.Y > tool.StartPoint.Y)
                {
                    e.Graphics.DrawPie(pen, tool.StartPoint.X, tool.StartPoint.Y, tool.MovePoint.X - tool.StartPoint.X, tool.MovePoint.Y - tool.StartPoint.Y, tool.startAngle, tool.sweepAngle);
                }
                else if (tool.MovePoint.X < tool.StartPoint.X && tool.MovePoint.Y < tool.StartPoint.Y)
                {
                    e.Graphics.DrawPie(pen, tool.MovePoint.X, tool.MovePoint.Y, tool.StartPoint.X - tool.MovePoint.X, tool.StartPoint.Y - tool.MovePoint.Y, tool.startAngle, tool.sweepAngle);
                }
                if (tool.MovePoint.X > tool.StartPoint.X && tool.MovePoint.Y < tool.StartPoint.Y)
                {
                    e.Graphics.DrawPie(pen, tool.StartPoint.X, tool.MovePoint.Y, tool.MovePoint.X - tool.StartPoint.X, tool.StartPoint.Y - tool.MovePoint.Y, tool.startAngle, tool.sweepAngle);
                }
                else if (tool.MovePoint.X < tool.StartPoint.X && tool.MovePoint.Y > tool.StartPoint.Y)
                {
                    e.Graphics.DrawPie(pen, tool.MovePoint.X, tool.StartPoint.Y, tool.StartPoint.X - tool.MovePoint.X, tool.MovePoint.Y - tool.StartPoint.Y, tool.startAngle, tool.sweepAngle);
                }
            }
            
            
        }
        public void ClickDownRight(PaintEventArgs e, Parametr tool, History history)
        {

        }
        public void ClickDownLeft(PaintEventArgs e, Parametr tool, History history)
        {

        }
        public void ClickUp(PaintEventArgs e, Parametr tool, History history)
        {
           
            history.AddElement(tool);
        }
        public void ClickMove(PaintEventArgs e, Parametr tool, History history)
        {
            
        }
    }
}

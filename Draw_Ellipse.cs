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
    public class Draw_Ellipse : IDrawable
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
                    _ = new List<HatchStyle>();
                    e.Graphics.FillEllipse(pen, tool.StartPoint.X, tool.StartPoint.Y, tool.MovePoint.X - tool.StartPoint.X, tool.MovePoint.Y - tool.StartPoint.Y);
                }
                else
                {
                    SolidBrush pen = new SolidBrush(tool.color);
                    e.Graphics.FillEllipse(pen, tool.StartPoint.X, tool.StartPoint.Y, tool.MovePoint.X - tool.StartPoint.X, tool.MovePoint.Y - tool.StartPoint.Y);
                }

            }
            else
            {
                Pen pen = new Pen(tool.color, tool.width);
                if (tool.dashPattern)
                {
                    pen.DashCap = System.Drawing.Drawing2D.DashCap.Round;
                    pen.DashPattern = new float[] { 4.0F, 2.0F, 1.0F, 3.0F };
                }
                e.Graphics.DrawEllipse(pen, tool.StartPoint.X, tool.StartPoint.Y, tool.MovePoint.X - tool.StartPoint.X, tool.MovePoint.Y - tool.StartPoint.Y);
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

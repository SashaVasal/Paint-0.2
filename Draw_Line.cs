using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph
{
    public class Draw_Line : IDrawable
    {

        public string GetName()
        {
            return "Figure";
        }
        public void Draw(PaintEventArgs e, Parametr tool, History history)
        {
            Pen pen = new Pen(tool.color, tool.width);
            if (tool.dashPattern == true)
            {
                pen.DashCap = System.Drawing.Drawing2D.DashCap.Round;
                pen.DashPattern = new float[] { 4.0F, 2.0F, 1.0F, 3.0F };
            }


            e.Graphics.DrawLine(pen, tool.StartPoint.X, tool.StartPoint.Y, tool.MovePoint.X, tool.MovePoint.Y);
            
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

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph
{
    class Draw_Square: IDrawable
    {
        public string GetName()
        {
            return "Figure";
        }
        public void Draw(PaintEventArgs e, Parametr tool, History history)
        {
            if (tool.MovePoint.X > tool.StartPoint.X && tool.MovePoint.Y > tool.StartPoint.Y)
            {
                e.Graphics.DrawRectangle(new Pen(tool.color, tool.width), tool.StartPoint.X, tool.StartPoint.Y, tool.MovePoint.X - tool.StartPoint.X, tool.MovePoint.Y - tool.StartPoint.Y);
            }
            else if (tool.MovePoint.X < tool.StartPoint.X && tool.MovePoint.Y < tool.StartPoint.Y)
            {
                e.Graphics.DrawRectangle(new Pen(tool.color, tool.width), tool.MovePoint.X, tool.MovePoint.Y, tool.StartPoint.X - tool.MovePoint.X, tool.StartPoint.Y - tool.MovePoint.Y);
            }
            if (tool.MovePoint.X > tool.StartPoint.X && tool.MovePoint.Y < tool.StartPoint.Y)
            {
                e.Graphics.DrawRectangle(new Pen(tool.color, tool.width), tool.StartPoint.X, tool.MovePoint.Y, tool.MovePoint.X - tool.StartPoint.X, tool.StartPoint.Y - tool.MovePoint.Y);
            }
            else if (tool.MovePoint.X < tool.StartPoint.X && tool.MovePoint.Y > tool.StartPoint.Y)
            {
                e.Graphics.DrawRectangle(new Pen(tool.color, tool.width), tool.MovePoint.X, tool.StartPoint.Y, tool.StartPoint.X - tool.MovePoint.X, tool.MovePoint.Y - tool.StartPoint.Y);
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

using System;
using System.Drawing;
using System.Windows.Forms;


namespace Graph
{
    public class Draw_Pen : IDrawable
    {
        
        public string GetName()
        {
            return "Pen";
        }
        public void Draw(PaintEventArgs e, Parametr tool, History history)
        {
            e.Graphics.DrawLine(new Pen(tool.color, tool.width), tool.OldMovePoint.X, tool.OldMovePoint.Y, tool.MovePoint.X, tool.MovePoint.Y);
        }
        public void ClickDownRight(PaintEventArgs e, Parametr tool, History history)
        {

        }
        public void ClickDownLeft(PaintEventArgs e, Parametr tool, History history)
        {

        }
        public void ClickUp(PaintEventArgs e, Parametr tool, History history)
        {

        }
        public void ClickMove(PaintEventArgs e, Parametr tool, History history)
        {
            history.AddElement(tool);
            tool.OldMovePoint = tool.MovePoint;                   
        }
    }
}

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
        public void Draw(PaintEventArgs e, Tool tool)
        {
            if(tool.OldMovePoint.X > 0 && tool.OldMovePoint.Y > 0 && tool.MovePoint.Y > 0 && tool.MovePoint.Y > 0)
            {
                e.Graphics.DrawLine(new Pen(tool.color, tool.width), tool.OldMovePoint.X, tool.OldMovePoint.Y, tool.MovePoint.X, tool.MovePoint.Y);
            }
                       
        }

    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph
{
    class Hand : IDrawable
    {
        public string GetName()
        {
            return "Hand";
        }
        public void Draw(PaintEventArgs e, Tool tool)
        {
            Point HandPoint = new Point();
            HandPoint.X = (tool.StartPoint.X - tool.MovePoint.X)/5;
            HandPoint.Y = (tool.StartPoint.Y - tool.MovePoint.Y)/5;
            foreach (Tool f in tool.h)
            {
               
                f.StartPoint.X = Convert.ToInt32(Convert.ToSingle(f.StartPoint.X)) - HandPoint.X;
                f.StartPoint.Y = Convert.ToInt32(Convert.ToSingle(f.StartPoint.Y)) - HandPoint.Y;
                f.MovePoint.X = Convert.ToInt32(Convert.ToSingle(f.MovePoint.X)) - HandPoint.X;
                f.MovePoint.Y = Convert.ToInt32(Convert.ToSingle(f.MovePoint.Y)) - HandPoint.Y;
                f.OldMovePoint.X = Convert.ToInt32(Convert.ToSingle(f.OldMovePoint.X)) - HandPoint.X;
                f.OldMovePoint.Y = Convert.ToInt32(Convert.ToSingle(f.OldMovePoint.Y)) - HandPoint.Y;          
            }
        }
    }
}

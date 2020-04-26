using System;
using System.Drawing;
using System.Windows.Forms;

namespace Graph
{
    class ZoomTool:IDrawable
    {
        public string GetName()
        {
            return "Zoom";
        }
        public void Draw(PaintEventArgs e, Parametr tool, History history)
        {
            tool.ZoomPoint = tool.MovePoint;
            if (tool.MovePoint.X > tool.StartPoint.X && tool.MovePoint.Y > tool.StartPoint.Y)
            {
                e.Graphics.DrawRectangle(new Pen(Color.Black, 1), tool.StartPoint.X, tool.StartPoint.Y, tool.MovePoint.X - tool.StartPoint.X, tool.MovePoint.Y - tool.StartPoint.Y);
                tool.ZoomPoint.X = Convert.ToInt32(Convert.ToSingle(tool.ZoomPoint.X / 1)) - (tool.MovePoint.X - tool.StartPoint.X)/2;
                tool.ZoomPoint.Y = Convert.ToInt32(Convert.ToSingle(tool.ZoomPoint.Y / 1)) - (tool.MovePoint.Y - tool.StartPoint.Y)/2;
            }
            else if (tool.MovePoint.X < tool.StartPoint.X && tool.MovePoint.Y < tool.StartPoint.Y)
            {
                e.Graphics.DrawRectangle(new Pen(Color.Black, 1), tool.MovePoint.X, tool.MovePoint.Y, tool.StartPoint.X - tool.MovePoint.X, tool.StartPoint.Y - tool.MovePoint.Y);
                tool.ZoomPoint.X = Convert.ToInt32(Convert.ToSingle(tool.ZoomPoint.X / 1)) + (tool.StartPoint.X - tool.MovePoint.X) / 2;
                tool.ZoomPoint.Y = Convert.ToInt32(Convert.ToSingle(tool.ZoomPoint.Y / 1)) - (tool.MovePoint.Y - tool.StartPoint.Y) / 2;
            }
            if (tool.MovePoint.X > tool.StartPoint.X && tool.MovePoint.Y < tool.StartPoint.Y)
            {
                e.Graphics.DrawRectangle(new Pen(Color.Black, 1), tool.StartPoint.X, tool.MovePoint.Y, tool.MovePoint.X - tool.StartPoint.X, tool.StartPoint.Y - tool.MovePoint.Y);
                tool.ZoomPoint.X = Convert.ToInt32(Convert.ToSingle(tool.ZoomPoint.X / 1)) - (tool.MovePoint.X - tool.StartPoint.X) / 2;
                tool.ZoomPoint.Y = Convert.ToInt32(Convert.ToSingle(tool.ZoomPoint.Y / 1)) + (tool.StartPoint.Y - tool.MovePoint.Y) / 2;
            }
            else if (tool.MovePoint.X < tool.StartPoint.X && tool.MovePoint.Y > tool.StartPoint.Y)
            {
                e.Graphics.DrawRectangle(new Pen(Color.Black, 1), tool.MovePoint.X, tool.StartPoint.Y, tool.StartPoint.X - tool.MovePoint.X, tool.MovePoint.Y - tool.StartPoint.Y);
                tool.ZoomPoint.X = Convert.ToInt32(Convert.ToSingle(tool.ZoomPoint.X / 1)) + (tool.StartPoint.X - tool.MovePoint.X) / 2;
                tool.ZoomPoint.Y = Convert.ToInt32(Convert.ToSingle(tool.ZoomPoint.Y / 1)) + (tool.MovePoint.Y - tool.StartPoint.Y) / 2;
            }

            
            
            
        }
        
        public void ClickUp(PaintEventArgs e, Parametr tool, History history)
        {
            float loupe = 2f;

            

            foreach (Parametr f in history.history)
            {
                f.StartPoint.X = Convert.ToInt32(Convert.ToSingle(f.StartPoint.X) * loupe) - tool.ZoomPoint.X;
                f.StartPoint.Y = Convert.ToInt32(Convert.ToSingle(f.StartPoint.Y) * loupe) - tool.ZoomPoint.Y;
                f.MovePoint.X = Convert.ToInt32(Convert.ToSingle(f.MovePoint.X) * loupe) - tool.ZoomPoint.X;
                f.MovePoint.Y = Convert.ToInt32(Convert.ToSingle(f.MovePoint.Y) * loupe) - tool.ZoomPoint.Y;
                f.OldMovePoint.X = Convert.ToInt32(Convert.ToSingle(f.OldMovePoint.X) * loupe) - tool.ZoomPoint.X;
                f.OldMovePoint.Y = Convert.ToInt32(Convert.ToSingle(f.OldMovePoint.Y) * loupe) - tool.ZoomPoint.Y;
                f.width *= loupe;
            }




        }
        public void ClickDownRight(PaintEventArgs e, Parametr tool, History history)
        {
            float loupe = 2f;
            
                tool.ZoomPoint = tool.MovePoint;
                tool.ZoomPoint.X = Convert.ToInt32(Convert.ToSingle(tool.ZoomPoint.X / 1));
                tool.ZoomPoint.Y = Convert.ToInt32(Convert.ToSingle(tool.ZoomPoint.Y / 1));
               
                foreach (Parametr f in history.history)
                {
                    f.StartPoint.X = Convert.ToInt32((Convert.ToSingle(f.StartPoint.X) + tool.ZoomPoint.X) / loupe);
                    f.StartPoint.Y = Convert.ToInt32((Convert.ToSingle(f.StartPoint.Y) + tool.ZoomPoint.Y) / loupe);
                    f.MovePoint.X = Convert.ToInt32((Convert.ToSingle(f.MovePoint.X) + tool.ZoomPoint.X) / loupe);
                    f.MovePoint.Y = Convert.ToInt32((Convert.ToSingle(f.MovePoint.Y) + tool.ZoomPoint.Y) / loupe);
                    f.OldMovePoint.X = Convert.ToInt32((Convert.ToSingle(f.OldMovePoint.X) + tool.ZoomPoint.X) / loupe);
                    f.OldMovePoint.Y = Convert.ToInt32((Convert.ToSingle(f.OldMovePoint.Y) + tool.ZoomPoint.Y) / loupe);
                    f.width /= loupe;
                }
            
        }
        public void ClickDownLeft(PaintEventArgs e, Parametr tool, History history)
        {

        }
        public void ClickMove(PaintEventArgs e, Parametr tool, History history)
        {

        }
    }
}

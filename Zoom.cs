using System;
using System.Windows.Forms;

namespace Graph
{
    class Zoom:IDrawable
    {
        public string GetName()
        {
            return "Zoom";
        }
        public void Draw(PaintEventArgs e, Tool tool)
        {
            float loupe = 2f;
            if (tool.WasClick == 1)
            {
                foreach (Tool f in tool.h)
                {
                    tool.ZoomPoint = tool.MovePoint;
                    tool.ZoomPoint.X = Convert.ToInt32(Convert.ToSingle(tool.ZoomPoint.X / 1));
                    tool.ZoomPoint.Y =Convert.ToInt32(Convert.ToSingle(tool.ZoomPoint.Y / 1));  
                    
                    f.StartPoint.X = Convert.ToInt32(Convert.ToSingle(f.StartPoint.X) * loupe) - tool.ZoomPoint.X;
                    f.StartPoint.Y = Convert.ToInt32(Convert.ToSingle(f.StartPoint.Y) * loupe) - tool.ZoomPoint.Y;
                    f.MovePoint.X = Convert.ToInt32(Convert.ToSingle(f.MovePoint.X) * loupe) - tool.ZoomPoint.X;
                    f.MovePoint.Y = Convert.ToInt32(Convert.ToSingle(f.MovePoint.Y) * loupe) - tool.ZoomPoint.Y;
                    f.OldMovePoint.X = Convert.ToInt32(Convert.ToSingle(f.OldMovePoint.X) * loupe) - tool.ZoomPoint.X;
                    f.OldMovePoint.Y = Convert.ToInt32(Convert.ToSingle(f.OldMovePoint.Y) * loupe) - tool.ZoomPoint.Y;
                    f.width *= loupe;
                }
                

            }
            else{
                foreach (Tool f in tool.h)
                {
                    f.StartPoint.X = Convert.ToInt32((Convert.ToSingle(f.StartPoint.X) + tool.ZoomPoint.X)/loupe);
                    f.StartPoint.Y = Convert.ToInt32((Convert.ToSingle(f.StartPoint.Y) + tool.ZoomPoint.Y) / loupe);
                    f.MovePoint.X = Convert.ToInt32((Convert.ToSingle(f.MovePoint.X)  + tool.ZoomPoint.X) / loupe);
                    f.MovePoint.Y = Convert.ToInt32((Convert.ToSingle(f.MovePoint.Y) + tool.ZoomPoint.Y) / loupe);
                    f.OldMovePoint.X = Convert.ToInt32((Convert.ToSingle(f.OldMovePoint.X) + tool.ZoomPoint.X) / loupe);
                    f.OldMovePoint.Y = Convert.ToInt32((Convert.ToSingle(f.OldMovePoint.Y)  + tool.ZoomPoint.Y) / loupe);
                    f.width /= loupe;
                }
                
            }

            tool.WasClick *= -1;
        }
    }
}

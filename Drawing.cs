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
    public interface IDrawable
    {
        void Draw(PaintEventArgs e, Tool tool);
        string GetName();
    }
    public class ViewSize
    {
        public int Height;
        public int Width;
        public ViewSize(int Height, int Width)
        {
            this.Width = Width;
            this.Height = Height;
        }
    }
    public class Tool
    {

        public ViewSize viewSize;
        public PictureBox pictureBox;
        public Tool(int Height, int Width)
        {
            viewSize = new ViewSize(Height, Width);
        }
        public Bitmap bit;
        public IDrawable drawable = new Draw_Ellipse();
        public PaintEventArgs e;
        public List<Tool> h = new List<Tool>();
        public void AddH(Tool tool)
        {
            Tool q = new Tool(viewSize.Height,viewSize.Width)
            {
                drawable = tool.drawable,
                MovePoint = tool.MovePoint,
                StartPoint = tool.StartPoint,
                width = tool.width,
                color = tool.color,
                e = tool.e,
                OldMovePoint = tool.OldMovePoint
            };
            h.Add(q);
        }       
        public float width = 5;
        public Color color = Color.Black;
        public int WasClick = 1;
        public bool IsMouseDown = false;
        public Point StartPoint = new Point();
        public Point MovePoint = new Point();
        public Point OldMovePoint = new Point();
        public Point ZoomPoint = new Point();
       
        
       
    }
    

    


    

}

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
        void Draw(PaintEventArgs e, Parametr tool, History history);
        string GetName();
        void ClickDownLeft(PaintEventArgs e, Parametr tool, History history);
        void ClickDownRight(PaintEventArgs e, Parametr tool, History history);
        void ClickUp(PaintEventArgs e, Parametr tool, History history);
        void ClickMove(PaintEventArgs e, Parametr tool, History history);

    }  
    public class ViewSize
    {
        public int Height;
        public int Width;       
    }
    public class Parametr
    {

        public ViewSize viewSize = new ViewSize();
        public PictureBox pictureBox;  
        public Bitmap bit;
        public IDrawable drawable = new Draw_Ellipse();
        public int Choose = 0;
        public PaintEventArgs e;      
        public float width = 5;
        public Color color = Color.Black;
        public int WasClick = 1;
        public bool IsMouseDown = false;
        public Point StartPoint = new Point();
        public Point MovePoint = new Point();
        public Point OldMovePoint = new Point();
        public Point ZoomPoint = new Point();
        public int startAngle = 0;
        public int sweepAngle = 0;
        public bool brush = false;
        public bool dashPattern = false;
        public bool hatchBrush = false;
        public Color hatchColor = Color.Green;
        public int TypeHatch = 0;

    }
    

    


    

}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Graph
{
 
    public enum StateMouse
    {   MouseIdle = 0,    
        MouseLeftUp = 1,
        MouseRightUp,   
        MouseLeft,
        MouseRight
    }
    public interface IDrawable
    {
        
        void Draw(bool SaveElem, Graphics canvas);
        
    }
    public class PenPicker 
    {
        public int penBool = 1;
        public int brushBool = -1;
        float[] dashValues = { 5, 2, 15, 4 };
        public Color colorFill = Color.Black;
        public Color colorLine = Color.Black;
        public int width = 5;
        public HatchStyle[] hatchStyle = { HatchStyle.Horizontal, HatchStyle.Vertical, HatchStyle.Percent50 };
        public int ChooseHatch = 0;
        public bool hatchBool = false;
        public Color colorHatch = Color.Black;
        public bool animate = false;
        public int animateValue = 0;
       
        public bool dashBool = false;
        public PenPicker()
        {
            
        }
        public void PickPen()
        {
            penBool *= -1;
        }
        public void PickBrush()
        {
            brushBool *= -1;
        }
        public void PickHatchBrush()
        {
            //brushes = hatchBrush;
        }
        public Pen GetPen()
        {
            Pen pen = new Pen(colorLine, width);
            if (dashBool)
            {
                pen.DashPattern = dashValues;
            }
            return pen;
        }
        public Brush GetBrush()
        {
            Brush brush;
            if (!hatchBool)
            {
                brush = new SolidBrush(colorFill);
            }
            else
            {
                brush = new HatchBrush(hatchStyle[ChooseHatch], colorHatch, colorFill);
            }
            return brush;
        }

    }
   
    public class ViewSize
    { 
        public int Height;
        public int Width;
        public ViewSize(int Height, int Width)
        {
            this.Height = Height;
            this.Width = Width;
        }              
    }
   
    public class Parametr
    {
        public History history;
        public ViewSize viewSize = new ViewSize(1000, 1000);

      
        public StateMouse stateMouse = StateMouse.MouseIdle;
        public int Choose = 0;
      
        
        public Point StartPoint = new Point();
        public Point MovePoint = new Point();
        public Point OldMovePoint = new Point();
        public PictureBox canvas;
        public Bitmap bitmap;
        public Shape drawable;
        
        public Color hatchColor = Color.Green;

        public int startAngle = 0;
        public int sweepAngle = 0;
        public Point ZoomPoint = new Point();

       
        public PenPicker penPicker = new PenPicker();
    }



}




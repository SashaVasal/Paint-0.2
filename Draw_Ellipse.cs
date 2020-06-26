using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph
{
    [DataContract]
    public class Draw_Ellipse : Shape
    {
        
        public Draw_Ellipse(PenPicker penPicker, History history) : base(penPicker, history)
        {
            NameFigure = "Ellipse";
        }
        public override void Draw(bool SaveElem, Graphics canvas)
        {
            if (!SaveElem)
            {
                if (penPicker.penBool == 1)
                {
                    canvas.DrawEllipse(penPicker.GetPen(), StartPoint.X, StartPoint.Y, MovePoint.X - StartPoint.X, MovePoint.Y - StartPoint.Y);
                }

                if (penPicker.brushBool == 1)
                {
                    canvas.FillEllipse(penPicker.GetBrush(), StartPoint.X, StartPoint.Y, MovePoint.X - StartPoint.X, MovePoint.Y - StartPoint.Y);
                }
            }
            if (stateMouse == StateMouse.MouseLeft)
            {
                if(penPicker.penBool == 1)
                {
                    canvas.DrawEllipse(penPicker.GetPen(), StartPoint.X, StartPoint.Y, MovePoint.X - StartPoint.X, MovePoint.Y - StartPoint.Y);
                }
               
                if(penPicker.brushBool == 1)
                {
                    canvas.FillEllipse(penPicker.GetBrush(), StartPoint.X, StartPoint.Y, MovePoint.X - StartPoint.X, MovePoint.Y - StartPoint.Y);
                }
            }
            if (stateMouse == StateMouse.MouseLeftUp)
            {             
                if (penPicker.penBool == 1)
                {
                    canvas.DrawEllipse(penPicker.GetPen(), StartPoint.X, StartPoint.Y, MovePoint.X - StartPoint.X, MovePoint.Y - StartPoint.Y);
                }
                if (penPicker.brushBool == 1)
                {
                    canvas.FillEllipse(penPicker.GetBrush(), StartPoint.X, StartPoint.Y, MovePoint.X - StartPoint.X, MovePoint.Y - StartPoint.Y);
                }
                if (SaveElem)
                {
                    history.AddElement(new Draw_Ellipse(penPicker, history), StartPoint, MovePoint, OldMovePoint, penPicker);
                }
                
            }
           
            
        }
       

    }
}

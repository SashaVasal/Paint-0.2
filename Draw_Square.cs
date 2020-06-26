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
    class Draw_Square: Shape
    {
        
        public Draw_Square(PenPicker penPicker,History history) : base(penPicker, history)
        {
            NameFigure = "Rectangle";
        }
        public override void Draw(bool SaveElem, Graphics canvas)
        {
            if (!SaveElem)
            {
                if (penPicker.penBool == 1)
                {
                    canvas.DrawRectangle(penPicker.GetPen(), Math.Min(StartPoint.X, MovePoint.X), Math.Min(StartPoint.Y, MovePoint.Y), Math.Abs(StartPoint.X - MovePoint.X), Math.Abs(MovePoint.Y - StartPoint.Y));
                }
                if (penPicker.brushBool == 1)
                {
                    canvas.FillRectangle(penPicker.GetBrush(), Math.Min(StartPoint.X, MovePoint.X), Math.Min(StartPoint.Y, MovePoint.Y), Math.Abs(StartPoint.X - MovePoint.X), Math.Abs(MovePoint.Y - StartPoint.Y));
                }
            }
            if (stateMouse == StateMouse.MouseLeft)
            {

                if (penPicker.penBool == 1)
                {
                    canvas.DrawRectangle(penPicker.GetPen(), Math.Min(StartPoint.X, MovePoint.X), Math.Min(StartPoint.Y, MovePoint.Y), Math.Abs(StartPoint.X - MovePoint.X), Math.Abs(MovePoint.Y - StartPoint.Y));
                }
                if (penPicker.brushBool == 1)
                {
                    canvas.FillRectangle(penPicker.GetBrush(), Math.Min(StartPoint.X, MovePoint.X), Math.Min(StartPoint.Y, MovePoint.Y), Math.Abs(StartPoint.X - MovePoint.X), Math.Abs(MovePoint.Y - StartPoint.Y));
                }
            }
            if (stateMouse == StateMouse.MouseLeftUp)
            {
                if (penPicker.penBool == 1)
                {
                    canvas.DrawRectangle(penPicker.GetPen(), Math.Min(StartPoint.X, MovePoint.X), Math.Min(StartPoint.Y, MovePoint.Y), Math.Abs(StartPoint.X - MovePoint.X), Math.Abs(MovePoint.Y - StartPoint.Y));
                }
                if (penPicker.brushBool == 1)
                {
                    canvas.FillRectangle(penPicker.GetBrush(), Math.Min(StartPoint.X, MovePoint.X), Math.Min(StartPoint.Y, MovePoint.Y), Math.Abs(StartPoint.X - MovePoint.X), Math.Abs(MovePoint.Y - StartPoint.Y));
                }
                if (SaveElem)
                {
                    history.AddElement(new Draw_Square(penPicker, history), StartPoint, MovePoint, OldMovePoint, penPicker);
                }
                
            }
        }
       

    }
}

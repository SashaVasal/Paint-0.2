using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.Serialization;
using System.Windows.Forms;


namespace Graph
{
    [DataContract]
    public class Draw_Pen : Shape
    {

        public Draw_Pen(PenPicker penPicker, History history) : base(penPicker, history)
        {
            NameFigure = "Pen";
        }
        public override void Draw(bool SaveElem, Graphics canvas)
        {
 
            if (stateMouse == StateMouse.MouseLeft || stateMouse == StateMouse.MouseLeftUp || stateMouse == StateMouse.MouseIdle)
            {
                canvas.DrawLine(penPicker.GetPen(), OldMovePoint.X, OldMovePoint.Y, MovePoint.X, MovePoint.Y);
              
            }
            
            if (SaveElem)
            {
                history.AddElement(new Draw_Pen(penPicker, history),StartPoint,MovePoint,OldMovePoint, penPicker);
            }
             
        }
       
        
    }
}

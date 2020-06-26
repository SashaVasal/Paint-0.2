using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace Graph
{
    [DataContract]
    public class Draw_Line : Shape
    {

        public Draw_Line(PenPicker penPicker,  History history) : base(penPicker, history)
        {
            NameFigure = "Line";
        }
        public override void Draw(bool SaveElem, Graphics canvas)
        {
            if(!SaveElem)
            {
                canvas.DrawLine(penPicker.GetPen(), StartPoint.X, StartPoint.Y, MovePoint.X, MovePoint.Y);
            }
            if(stateMouse == StateMouse.MouseLeft)
            {
                canvas.DrawLine(penPicker.GetPen(), StartPoint.X, StartPoint.Y, MovePoint.X, MovePoint.Y);
                
            }
            if(stateMouse == StateMouse.MouseLeftUp)
            {
                canvas.DrawLine(penPicker.GetPen(), StartPoint.X, StartPoint.Y, MovePoint.X, MovePoint.Y);
                if (SaveElem)
                {
                    history.AddElement(new Draw_Line(penPicker, history ), StartPoint, MovePoint, OldMovePoint, penPicker);
                }
           }
        }
        
        


    }
}

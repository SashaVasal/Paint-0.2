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
    public class Draw_Pie : Shape
    {
        [DataMember]
        int startAngle;
        [DataMember]
        int sweepAngle;
        public Draw_Pie(PenPicker penPicker, int startAngle, int sweepAngle, History history) : base(penPicker, history)
        {
            this.startAngle = startAngle;
            this.sweepAngle = sweepAngle;
            NameFigure = "Pie";
        }
        public override void Draw(bool SaveElem, Graphics canvas)
        {
        
            
            if (stateMouse == StateMouse.MouseLeftUp || stateMouse == StateMouse.MouseLeft)
            {
                if (penPicker.penBool == 1)
                {
                    canvas.DrawPie(penPicker.GetPen(), Math.Min(StartPoint.X, MovePoint.X), Math.Min(StartPoint.Y, MovePoint.Y), Math.Abs(StartPoint.X - MovePoint.X) + 1, Math.Abs(MovePoint.Y - StartPoint.Y) + 1, startAngle, startAngle + sweepAngle);
                }
                if (penPicker.brushBool == 1)
                {
                    canvas.FillPie(penPicker.GetBrush(), Math.Min(StartPoint.X, MovePoint.X), Math.Min(StartPoint.Y, MovePoint.Y), Math.Abs(StartPoint.X - MovePoint.X) + 1, Math.Abs(MovePoint.Y - StartPoint.Y) + 1, startAngle, startAngle + sweepAngle);
                }
                if (SaveElem)
                {
                    history.AddElement(new Draw_Pie(penPicker, startAngle, sweepAngle, history), StartPoint, MovePoint, OldMovePoint, penPicker);
                }
                
            }
            
        }

        
    }
}

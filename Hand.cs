using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph
{
        class Hand : Shape
        {

            Point HandPoint;
            public Hand(PenPicker penPicker, History history) : base(penPicker, history)
            {
                HandPoint = new Point((StartPoint.X - MovePoint.X) / 5, (StartPoint.Y - MovePoint.Y) / 5);
            }
   
        public override void Draw(bool SaveElem, Graphics canvas)
        {
            if (stateMouse == StateMouse.MouseLeft)
            {
                HandPoint = new Point((StartPoint.X - MovePoint.X) / 5, (StartPoint.Y - MovePoint.Y) / 5);
            }
            if (stateMouse == StateMouse.MouseLeftUp)
            {
                HandPoint = new Point(0,0);
            }
            canvas.Clear(Color.White);
            foreach (Shape s in history.h)
            {
                s.MovePoint.X = Convert.ToInt32(Convert.ToSingle(s.MovePoint.X)) - HandPoint.X;
                s.MovePoint.Y = Convert.ToInt32(Convert.ToSingle(s.MovePoint.Y)) - HandPoint.Y;
                s.StartPoint.X = Convert.ToInt32(Convert.ToSingle(s.StartPoint.X)) - HandPoint.X;
                s.StartPoint.Y = Convert.ToInt32(Convert.ToSingle(s.StartPoint.Y)) - HandPoint.Y;
                s.OldMovePoint.X = Convert.ToInt32(Convert.ToSingle(s.OldMovePoint.X)) - HandPoint.X;
                s.OldMovePoint.Y = Convert.ToInt32(Convert.ToSingle(s.OldMovePoint.Y)) - HandPoint.Y;
                s.Draw(false, canvas);
                
            }
            HandPoint = new Point(0, 0);
        }
        
    }
}

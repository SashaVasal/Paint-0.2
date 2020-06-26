using System;
using System.Drawing;
using System.Windows.Forms;
namespace Graph
{
    class ZoomTool:Shape
    {
        
        
        Rectangle rec;
        float zoomPower = 2;
        
        public ZoomTool(PenPicker penPicker, History history) : base(penPicker, history)
        {
            
        }
       
        public override void Draw(bool SaveElem, Graphics canvas)
        {
            if(stateMouse == StateMouse.MouseLeft)
            {
                rec = new Rectangle(Math.Min(StartPoint.X, MovePoint.X), Math.Min(StartPoint.Y, MovePoint.Y), Math.Abs(StartPoint.X - MovePoint.X), Math.Abs(MovePoint.Y - StartPoint.Y));
                if (!rec.IsEmpty)
                {
                    if (stateMouse == StateMouse.MouseLeft)
                    {
                        canvas.Clear(Color.White);
                        foreach (Shape s in history.h)
                        {
                            s.Draw(false, canvas);

                        }
                        canvas.DrawRectangle(new Pen(Color.Black,1), Math.Min(StartPoint.X, MovePoint.X), Math.Min(StartPoint.Y, MovePoint.Y), Math.Abs(StartPoint.X - MovePoint.X), Math.Abs(MovePoint.Y - StartPoint.Y));

                    }
                }
                
            }
            

            if (stateMouse == StateMouse.MouseLeftUp)
            {

                canvas.Clear(Color.White);
                foreach (Shape s in history.h)
                {
                    s.StartPoint.X = Convert.ToInt32(Convert.ToSingle(s.StartPoint.X) * zoomPower) - rec.X;
                    s.StartPoint.Y = Convert.ToInt32(Convert.ToSingle(s.StartPoint.Y) * zoomPower) - rec.Y;
                    s.MovePoint.X = Convert.ToInt32(Convert.ToSingle(s.MovePoint.X) * zoomPower) - rec.X;
                    s.MovePoint.Y = Convert.ToInt32(Convert.ToSingle(s.MovePoint.Y) * zoomPower) - rec.Y;
                    s.OldMovePoint.X = Convert.ToInt32(Convert.ToSingle(s.OldMovePoint.X) * zoomPower) - rec.X;
                    s.OldMovePoint.Y = Convert.ToInt32(Convert.ToSingle(s.OldMovePoint.Y) * zoomPower) - rec.Y;
                    s.penPicker.width = Convert.ToInt32(Convert.ToSingle(s.penPicker.width * zoomPower));
                    s.Draw(false, canvas);

                }               
            }
            if (stateMouse == StateMouse.MouseRightUp)
            {

                canvas.Clear(Color.White);
                foreach (Shape s in history.h)
                {
                    s.StartPoint.X = Convert.ToInt32(Convert.ToSingle((s.StartPoint.X) + rec.X) / zoomPower);
                    s.StartPoint.Y = Convert.ToInt32(Convert.ToSingle((s.StartPoint.Y) + rec.Y) / zoomPower);
                    s.MovePoint.X = Convert.ToInt32(Convert.ToSingle((s.MovePoint.X) + rec.X) / zoomPower);
                    s.MovePoint.Y = Convert.ToInt32(Convert.ToSingle((s.MovePoint.Y) + rec.Y) / zoomPower);
                    s.OldMovePoint.X = Convert.ToInt32(Convert.ToSingle((s.OldMovePoint.X) + rec.X) / zoomPower);
                    s.OldMovePoint.Y = Convert.ToInt32(Convert.ToSingle((s.OldMovePoint.Y) + rec.Y) / zoomPower);
                    s.penPicker.width = Convert.ToInt32(Convert.ToSingle(s.penPicker.width / zoomPower));
                    s.Draw(false, canvas);

                }
            }


            
        }




    }
}

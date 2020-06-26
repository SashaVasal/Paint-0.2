using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shapes;

namespace Graph

{
    [KnownType(typeof(Draw_Ellipse))]
    [KnownType(typeof(Draw_Pen))]
    [KnownType(typeof(Draw_Pie))]
    [KnownType(typeof(Draw_Line))]
    [KnownType(typeof(Draw_Square))]
    [DataContract]
    public abstract class Shape : IDrawable
    {
        
        [DataMember]
        public Point StartPoint;
        [DataMember]
        public Point MovePoint;
        [DataMember]
        public Point OldMovePoint;
        public StateMouse stateMouse = StateMouse.MouseIdle;
        public History history;
        [DataMember]
        public PenPicker penPicker = new PenPicker();
        public string NameFigure;
        public double tick = 0;

        public Shape(PenPicker penPicker,  History history)
        {
            this.history = history;
            this.penPicker = penPicker;
                      
        }
        public void Animate()
        {
            tick++;
            switch (penPicker.animateValue)
            {
                /*  case 1:
                      if (tick < 10)
                      {
                          StartPoint.X += 10;
                          StartPoint.Y += 10;
                          MovePoint.X += 10;
                          MovePoint.Y += 10;

                      }
                      else
                      {
                          penPicker.animateValue = 0;
                      }                  
                      break;
                  case 2:
                      if(tick < 10)
                      {
                          StartPoint.X = Convert.ToInt32(StartPoint.X * Math.Cos(tick * Math.PI / 180) - StartPoint.Y * Math.Sin(tick * Math.PI / 180));
                          StartPoint.Y = Convert.ToInt32(StartPoint.X * Math.Sin(tick * Math.PI / 180) + StartPoint.Y * Math.Cos(tick * Math.PI / 180));
                          MovePoint.X = Convert.ToInt32(MovePoint.X * Math.Cos(tick * Math.PI / 180) - MovePoint.Y * Math.Sin(tick * Math.PI / 180));
                          MovePoint.Y = Convert.ToInt32(MovePoint.X * Math.Sin(tick * Math.PI / 180) + MovePoint.Y * Math.Cos(tick * Math.PI / 180));
                      }
                      else
                      {
                          penPicker.animateValue = 0;
                      }

                      break; */
            }
        }
        public void SetStartPoint(Point StartPoint)
        {
            this.StartPoint = StartPoint;
        }
        public void SetMovePoint(Point MovePoint)
        {
            this.MovePoint = MovePoint; 
        }
        public void SetMouseState(StateMouse stateMouse)
        {
            this.stateMouse = stateMouse;
        }
        public void SetOldPoint(Point OldPoint)
        {
            OldMovePoint = OldPoint;
        }
        abstract public void Draw(bool SaveElem, Graphics canvas);

       
    }
}

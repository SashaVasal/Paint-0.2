using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph
{

    public class ToolPicker
    {
        public Parametr parametr;
       
        public void PickPen(ref Shape figures)
        {          
            figures = new Draw_Pen(parametr.penPicker, parametr.history);                      
        }
        public void PickSquare(ref Shape figures)
        {

            figures = new Draw_Square(parametr.penPicker, parametr.history);
        }
        public void PickLine(ref Shape figures)
        {

            figures = new Draw_Line(parametr.penPicker, parametr.history);
        }
       
        public void PickEllipse(ref Shape figures)
        {

            figures = new Draw_Ellipse(parametr.penPicker, parametr.history);
        }
        public void PickZoom(ref Shape figures)
        {

            figures = new ZoomTool(parametr.penPicker, parametr.history);
        }
        public void PickHand(ref Shape figures)
        {

            figures = new Hand(parametr.penPicker, parametr.history);
        }
        public void PickPie(ref Shape figures)
        {

            figures = new Draw_Pie(parametr.penPicker, parametr.startAngle,parametr.sweepAngle, parametr.history);
        }
    }

}

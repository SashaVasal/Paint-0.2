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
        
 

        
        public void PickPen(ref IDrawable figures)
        {
           
            figures = new Draw_Pen();
        }
        public void PickSquare(ref IDrawable figures)
        {
         
            figures = new Draw_Square();
        }
        public void PickLine(ref IDrawable figures)
        {
         
            figures = new Draw_Line();
        }
        public void PickPolyline(List<IDrawable> figures)
        {
            figures.Clear();
            figures.Add(new Draw_Square());
        }
        public void PickEllipse(ref IDrawable figures)
        {       
        
            figures = new Draw_Ellipse();
        }
        public void PickZoom(ref IDrawable figures)
        {

            figures = new ZoomTool();
        }
        public void PickHand(ref IDrawable figures)
        {

            figures = new Hand();
        }
    }

}

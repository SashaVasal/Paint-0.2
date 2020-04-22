﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph
{
    public class Draw_Line : IDrawable
    {

        public string GetName()
        {
            return "Figure";
        }
        public void Draw(PaintEventArgs e, Tool tool)
        {
            
            e.Graphics.DrawLine(new Pen(tool.color, tool.width), tool.StartPoint.X, tool.StartPoint.Y, tool.MovePoint.X, tool.MovePoint.Y);
            
        }
        
    }
}

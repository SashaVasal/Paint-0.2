using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class History : Parametr
    {
        public List<Parametr> history = new List<Parametr>();
        public void AddElement(Parametr tool)
        {
            Parametr q = new Parametr()
            {
                viewSize = tool.viewSize,
                drawable = tool.drawable,
                MovePoint = tool.MovePoint,
                StartPoint = tool.StartPoint,
                width = tool.width,
                color = tool.color,
                e = tool.e,
                OldMovePoint = tool.OldMovePoint
            };
            history.Add(q);
        }
    }
}

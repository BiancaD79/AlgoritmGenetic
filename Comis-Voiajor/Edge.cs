using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Comis_Voiajor
{
    internal class Edge
    {
        Vertex start;
        Vertex end;
        float cost;
        public Edge(Vertex start, Vertex end, float cost)
        {
            this.start = start;
            this.end = end;
            this.cost = cost;
        }

        public void Draw(Graphics handler)
        {
            handler.DrawLine(Pens.Black, start.location, end.location);
            float midX = (start.location.X + end.location.X) / 2;
            float midY = (start.location.Y + end.location.Y) / 2;
            handler.DrawString(cost.ToString("0.00"), new Font("Arial",
                8, FontStyle.Bold), new SolidBrush(Color.Blue),
                new PointF(midX, midY));
        }

        public override string ToString() 
        {
            return start.idx + " " + end.idx + " " + cost;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmGenetic
{
    public class Edge
    {
        Vertex start, end;
        public float pond;
        public string info;
        public float Absdist() 
        {
            return (float)Math.Sqrt((start.loc.X - end.loc.X)*(start.loc.X - end.loc.X) + (start.loc.Y - end.loc.Y) *(start.loc.Y - end.loc.Y));
        }
        public Edge(string data, List<Vertex> vertices)
        {
            info = data;
            string[] datasplit = data.Split(' ');
            start = vertices[int.Parse(datasplit[0])];
            end = vertices[int.Parse(datasplit[1])];
            pond = float.Parse(datasplit[2]);
        }



        public void Draw(Graphics handler)
        {
            handler.DrawLine(Pens.Black, start.loc, end.loc);
        }


    }
}

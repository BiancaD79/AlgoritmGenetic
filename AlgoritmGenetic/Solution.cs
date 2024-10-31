using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmGenetic
{
    public class Solution
    {
        public Graph graph;
        public static float k = 2;
        public static Random rnd = new Random();
        public Solution(Graph graph) 
        { 
            this.graph = graph.Clone();
        }

        public float Fadec()
        {
            float toR = 0;
            foreach(Edge edge in graph.edges)
            {
                toR += ((edge.Absdist() - edge.pond * k)
                    *(edge.Absdist() - edge.pond * k));
            }
            return toR;
        }

        public void Mutate(float radius)
        {
            int r = rnd.Next(this.graph.vertices.Count);

            float alpha = (float)(rnd.NextDouble()
                * 2 * Math.PI);

            float xp = this.graph.vertices[r].loc.X 
                + radius * (float)Math.Cos(alpha);

            float yp = this.graph.vertices[r].loc.Y 
                + radius * (float)Math.Sin(alpha);

            this.graph.vertices[r].loc.X = xp;
            this.graph.vertices[r].loc.Y = yp;
        }

        public void Draw(Graphics handler)
        {
            graph.Draw(handler);
        }
    }
}

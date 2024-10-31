using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmGenetic
{
    public class Graph
    {
        //xml reader

        public List<Vertex> vertices;
        public List<Edge> edges;

        public Graph(string fileName) 
        { 
            TextReader sr = new StreamReader(fileName);
            
            int n = int.Parse(sr.ReadLine());
            vertices = new List<Vertex>();
            for (int i = 0; i < n; i++)
            {
                vertices.Add(new Vertex(i.ToString()));
            }

            edges = new List<Edge>();
            string line;
            while ((line = sr.ReadLine() )!= null)
            {
                edges.Add(new Edge(line,vertices));
            }
            sr.Close();
        }

        public void Draw(Graphics handler)
        {
            foreach(Vertex v in vertices)
                v.Draw(handler);
            foreach(Edge e in edges)
                e.Draw(handler);
        }

        public Graph()
        {
            vertices = new List<Vertex>();
            edges = new List<Edge>();
        }
        public Graph Clone() 
        {
            Graph clone = new Graph();
            for (int i = 0; i < this.vertices.Count; i++)
            {
                clone.vertices.Add(new Vertex(i.ToString()));
            }

            foreach (Edge edge in this.edges)
            {
                clone.edges.Add(new Edge(edge.info, clone.vertices));
            }

            return clone;
        }
    }
}

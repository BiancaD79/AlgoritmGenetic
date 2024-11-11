using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comis_Voiajor
{
    internal class Graf
    {
        public static Random rnd = new Random();

        List<Vertex> vertices;
        List<Edge> edges;
        public float[,] mC;
        public int k { get { return edges.Count; } }
        public int n { get { return vertices.Count; } }

        public Graf()
        {
            vertices = new List<Vertex>();
            edges = new List<Edge>();
        }
        public Graf(int n, int k)
        {
            mC = new float[n,n];
            vertices = new List<Vertex>();
            edges = new List<Edge>();
            for (int i = 0; i < n; i++)
            {
                vertices.Add(new Vertex(i.ToString(),i));
            }

            int idx1, idx2;
            for (int i = 0; i < k; i++)
            {
                do
                {
                    idx1 = rnd.Next(n);
                    idx2 = rnd.Next(n);
                } while (idx1 == idx2 || mC[idx1, idx2] != 0);
                float t = MyMath.Distance(
                    vertices[idx1].location, vertices[idx2].location);
                mC[idx1, idx2] = mC[idx2, idx1] = t;
                edges.Add(new Edge(vertices[idx1], vertices[idx2],t));
            }
        }

        public void Draw(Graphics handler)
        {
            foreach (Vertex v in vertices)
                v.Draw(handler);
            foreach (Edge e in edges)
                e.Draw(handler);
        }

        public void SaveToFile(string fileName)
        {
            TextWriter save = new StreamWriter(fileName);
            save.WriteLine(n);
            foreach (Vertex v in vertices)
                save.WriteLine(v.ToString());
            foreach (Edge e in edges)
                save.WriteLine(e.ToString());
            save.Close();
        }

        public void Load(string fileName)
        {
            TextReader sr = new StreamReader(fileName);

            int n = int.Parse(sr.ReadLine());
            vertices = new List<Vertex>();
            for (int i = 0; i < n; i++)
            {
                Vertex t = new Vertex(sr.ReadLine());
                t.idx = i; 
                vertices.Add(t);
            }

            edges = new List<Edge>();
            string line;
            mC = new float[n,n];
            while ((line = sr.ReadLine()) != null)
            {
                string[] data = line.Split(' ');
                int idx1 = int.Parse(data[0]);
                int idx2 = int.Parse(data[1]);
                float cost = float.Parse(data[2]);
                edges.Add(new Edge(vertices[idx1],
                    vertices[idx2], cost));
                mC[idx1,idx2] = mC[idx2,idx1] = cost;
            }
            sr.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmGenetic
{
    public class Population
    {
        static int N = 5000;
        static int K = 30;

        public static Random rnd = new Random();

        public List<Solution> solutions;
        public List<Solution> par;
        public Population()
        {
            solutions = new List<Solution>();
            par = new List<Solution>();
            for (int i = 0; i < N; i++)
            {
                solutions.Add(new Solution(AG.THEgraph));
            }
        }

        public void Sort()
        {
            solutions.Sort(delegate (Solution A, Solution B) { return A.Fadec().CompareTo(B.Fadec()); });
        }

        public void Selection()
        {
            par.Clear();
            for (int i = 0; i < K; i++)
            {
                par.Add(solutions[i]);
            }
        }

        public Solution Crossover(Solution A, Solution B)
        {
            Solution toR = new Solution(AG.THEgraph);
            int t = rnd.Next(1,toR.graph.vertices.Count - 1);
            for (int i = 0; i < t; i++)
            {
                toR.graph.vertices[i].loc.X = A.graph.vertices[i].loc.X;
                toR.graph.vertices[i].loc.Y = A.graph.vertices[i].loc.Y;
            }

            for (int i = t; i < B.graph.vertices.Count; i++)
            {
                toR.graph.vertices[i].loc.X = B.graph.vertices[i].loc.X;
                toR.graph.vertices[i].loc.Y = B.graph.vertices[i].loc.Y;
            }

            return toR;
        }
    }
}

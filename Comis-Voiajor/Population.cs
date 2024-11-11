using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comis_Voiajor
{
    internal class Population
    {
        int N;
        List<Solution> pop;
        Graf local;
        public Population(int n, Graf local)
        {
            this.local = local;
            pop = new List<Solution> ();
            this.N = n;
            for (int i = 0; i < N; i++)
            {
                pop.Add(new Solution (local));
            }
        }

        public List<string> View()
        {
            List<string> toR = new List<string>();
            foreach (Solution s in pop) 
            {
                toR.Add(s.ToString());
            }
            return toR;
        } 
    }
}

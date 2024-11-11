using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comis_Voiajor
{
    internal class Solution
    {
        Graf local;
        int[] sol;
        public Solution(Graf local) 
        {
            this.local = local;
            int n = local.n;
            sol = new int[n];
            for (int i = 0; i < n; i++)
            {
                sol[i] = i;
            }
            for (int i = 0; i < n; i++)
            {
                int idx = Graf.rnd.Next(n);
                (sol[i], sol[idx]) = (sol[idx], sol[i]);
            }

            //todo: fitness function
        }

        public override string ToString()
        {
            string t = "";
            for (int i = 0; i < local.n; i++)
            {
                t += sol[i] + " ";
            }
            return t; 
        }
    }
}

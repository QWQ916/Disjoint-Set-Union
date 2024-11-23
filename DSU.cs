using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Referat1
{
    public class DSU
    {
        int size; int[] p; int rank_a, rank_b;
        public DSU(int size, int[] p, int rank_a, int rank_b)
        {
            this.size = size; this.p = new int[size]; this.p = p;
            this.rank_a = rank_a; this.rank_b = rank_b;
        }
        public int Find(int x)
        {
            if (p[x - 1] == x) return x;
            else return p[x - 1] = Find(p[x - 1]);
        }
        public void Unite(int x, int y)
        {
            int x0 = Find(x);
            int y0 = Find(y); 
            if (x0 != y0)
            {
                if (rank_a > rank_b)
                {
                    p[x0 - 1] = y0;
                }
                else if (rank_a < rank_b)
                {
                    p[y0 - 1] = x0;
                }
                else
                {
                    p[x0 - 1] = y0;
                    rank_a++;
                }
            }
        }
    }
}

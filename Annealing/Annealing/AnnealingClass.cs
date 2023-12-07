using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annealing
{
    class AnnealingClass
    {
         private String way = "";

        internal Graph Graph
        {
            get => default;
            set
            {
            }
        }

        public int Property
        {
            get => default;
            set
            {
            }
        }

        public String getWay()
        {
            return way;
        }
        public String Annealing(double tMin,
        double tMax,
        double alpha,String length,Graph graph)
        {
            List<int> S = new List<int>();
            int p1 = 0; int p2 = 0;
            double probability = 0;
            List<List<int>> was = new List<List<int>>();
            Random rnd = new Random();
            int probabilityK = 0;
            List<int> changeVert = new List<int>();
            int deltaS = 0;
            S = randomizer(S,graph);
            
            was.Add(S);
            p1 = weightS(S,graph);
            while (tMax > 1)
            {
                int value = rnd.Next(1, graph.getVertex() - 1);
                changeVert.Add(value);
                while (true)
                {
                    value = rnd.Next(1, graph.getVertex());
                    if (value != changeVert[0])
                    {
                        changeVert.Add(value);
                        break;
                    }
                }
                int first = S[changeVert[0]];
                S[changeVert[0]] = S[changeVert[1]];
                S[changeVert[1]] = first;
                changeVert.Clear();
                was.Add(S);
                p2 = weightS(S, graph);
                deltaS = p2 - p1;
                tMax = alpha * tMax;

                if (deltaS < 0)
                {
                    was.Clear();
                    was.Add(S);
                    p1 = p2;
                }
                else
                {
                    probabilityK = rnd.Next(1, Convert.ToInt32(tMax));
                    probability = 100 * Math.Exp(-deltaS / tMax);
                    if (probability > probabilityK)
                    {
                        p1 = p2;
                        was.Clear();
                        was.Add(S);
                    }
                    else
                    {
                        S = was[0];
                        was.Clear();
                        was.Add(S);
                    }
                }
                if (tMax < 1)
                {
                    for (int i = 0; i <= graph.getVertex(); i++)
                    {
                        way += S[i].ToString() + " ";
                    }
                    if (p1 < p2)
                    {
                        S = was[0];
                        length = Convert.ToString(p1);
                    }
                    else length = Convert.ToString(p2);
                    
                }
            }
            return length;
        }
        private List<int> randomizer(List<int> S, Graph graph)
        {
            Random rnd = new Random();
            int value = rnd.Next(1, graph.getVertex() + 1);
            S.Add(value);
            for (int i = 0; i < graph.getVertex() - 1; i++)
            {
                int was = 0;
                value = rnd.Next(1, graph.getVertex() + 1);
                for (int j = 0; j < S.Count(); j++)
                {
                    if (S[j] == value)
                    {
                        was++;
                    }
                }
                if (was == 0)
                    S.Add(value);
                else { i--; was = 0; }
            }
            S.Add(S[0]);
            return S;
        }
        private int weightS(List<int> S, Graph graph)
        {
            int p = 0;
            List<List<int>> matrixWeight = graph.getEdges();
            Console.Write(matrixWeight[0][0]);
            for (int i = 0; i < S.Count() - 1; i++)
            {
                p += matrixWeight[S[i] - 1][S[i + 1] - 1];
            }
            return p;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDN___MadeInTJ
{
    internal class Map
    {
        public int N { get; } = 0; // Cuando usar get set;
        public int M { get; } = 0;
        private string[,] map { get; set; }

        public Map (int n, int m)
        {
            N = n;
            M = m;
            map = new string[N, M];

        }



        public void Init()
        {
            for (int i = 0; i < N; i++) 
            {
                for(int j = 0; j < M; j++)
                {
                    map[i, j] = "X";
                }
            }
        }

        public void Print()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(map[i,j]+ " ");
                }
                Console.WriteLine();
            }

        }

        public void SetPosition(int col, int row, string value)
        {
            map[col,row] = value;

        }


        public string[,] GetMap()
        {
            return map;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDN___MadeInTJ
{
    public class Map
    {
        public int N { get; } = 0; // Cuando usar get set;
        public int M { get; } = 0;
        private string[,] map { get; set; }

        public string[,] items { get; set; }

        public bool foundOut;

        int[,] round = { { -1, -1 }, { -1, 0 }, { -1, 1 }, { 0, -1 }, { 0, 1 }, { 1, -1 }, { 1, 0 }, { 1, 1 } };

        public Map(int n, int m)
        {
            N = n;
            M = m;
            map = new string[N, M];
            items = new string[N, M];
        }



        public void Init()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    map[i, j] = "X";
                    items[i, j] = "O";
                }
            }

            items[0, 0] = "S";
            items[N - 1, M - 1] = "F";

            for (int i = 1; i < 8; i++)
            {
                items[i, 3] = "L";
                //items[3, i] = "L";
                if (i == 7)
                {
                    for (int j = 3; j < 9; j++)
                    {
                        items[i, j] = "L";
                        //items[j, i] = "L";
                    }
                }
            }


            for (int i = 1; i < 8; i++)
            {
                items[i, 8] = "L";
                //items[3, i] = "L";
                if (i == 7)
                {
                    for (int j = 3; j < 9; j++)
                    {
                        items[12, j] = "L";
                        if (j == 8)
                        {


                            for (int k = 0; k < 6; k++)
                            {
                                items[k, 12] = "L";
                            }
                        }
                        //items[j, i] = "L";
                    }
                }
            }

            items[10, 10] = "W";
            items[11, 11] = "A";
            items[12, 12] = "H";
            items[13, 13] = "P";
            items[14, 14] = "E";





        }

        public void Print()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(map[i, j] + " ");
                }
                Console.WriteLine();
            }

        }

        public void SetPosition(int row, int col, string value)
        {
            //System.Console.WriteLine(items[row, col]);
            if (items[row, col] != "L")
            {
                map[row, col] = value;
                if (items[row, col] == "F")
                {
                    foundOut = true;
                }

                for (int i = 0; i < round.GetLength(0); i++)
                {
                    if (row + round[i, 0] >= 0 && row + round[i, 0] < map.GetLength(0) && col + round[i, 1] >= 0 && col + round[i, 1] < map.GetLength(1))
                    {
                        map[row + round[i, 0], col + round[i, 1]] = items[row + round[i, 0], col + round[i, 1]];

                    }

                }
            }
            else
            {
                return;
            }



        }


        public string[,] GetMap()
        {
            return map;
        }

        public bool FindOut()
        {
            return foundOut;
        }


        public string getItems(int col, int row)
        {
            return items[col, row];
        }

        public void RemoveElement(int col, int row)
        {
            items[col, row] = "O";
        }

    }



}



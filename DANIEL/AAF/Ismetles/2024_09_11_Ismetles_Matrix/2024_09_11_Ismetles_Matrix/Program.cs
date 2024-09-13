using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _2024_09_11_Ismetles_Matrix
{
    internal class Program
    {
        ~ Program() { 
            static List<List<int>> matrix = new List<List<int>>();
            static List<List<int>> pirosak = new List<List<int>>();
            static int maxx = 0;
            static int maxy = 0;
        }
        static void Main(string[] args)
        {
            ListaElkeszites();
        }

        static void ListaElkeszites()
        {
            Console.Clear();
            matrix.Clear();
            pirosak.Clear();
            Bekeres();
            Feltolt();
            Bepakolas();
            PirosKijeloles();
        }

        static void PirosKijeloles()
        {
            pirosak.Add(new List<int>());
            pirosak[0].Add(1);
            pirosak[0].Add(1);
            int pirosakdb = 1;
            int ji = 1;
            int jj = 1;
            while (!Vege(ji, jj))
            {
                if (matrix[ji+1][jj] < matrix[ji][jj+1])
                {
                    pirosak.Add(new List<int>());
                    pirosak[pirosakdb].Add(ji + 1);
                    pirosak[pirosakdb].Add(jj);
                    ji++;
                    pirosakdb++;
                } else
                {
                    pirosak.Add(new List<int>());
                    pirosak[pirosakdb].Add(ji + 1);
                    pirosak[pirosakdb].Add(jj);
                    jj++;
                    pirosakdb++;
                }
            }
            Console.WriteLine();
            MatrixKiiras();
            if (Console.ReadLine() == "ujra")
            {
                ListaElkeszites();
            }
        }

        static bool Vege(int ji, int jj)
        {
            if (matrix[ji + 1][jj] == -1 || matrix[ji][jj + 1] == -1)
            {
                return true;
            }
            return false;
        }

        static void Bekeres()
        {
            Console.Write("Adja meg a magasságát: ");
            maxx = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adja meg a szélességét: ");
            maxy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < maxx + 2; i++)
            {
                matrix.Add(new List<int>());
            }
        }

        static void Feltolt()
        {
            for (int i = 0; i < matrix.Count; i++)
            {
                for(int j = 0; j < maxy + 2; j++)
                {
                    matrix[i].Add(-1);
                }
            }
        }

        static void Bepakolas()
        {
            Random r = new Random();

            for (int i = 1; i < matrix.Count-1; i++)
            {
                for (int j = 1; j < matrix[i].Count-1; j++)
                {
                    int szam = r.Next(3, 126) * 20;
                    while (Check(i, j, szam))
                    {
                        szam = r.Next(3, 126) * 20;
                    }

                    matrix[i][j] = szam;
                }
            }

            MatrixKiiras();
        }

        static bool Check(int i, int j, int szam)
        {
            for(int k = i-1; k < i+2; k++)
            {
                for (int h = j - 1; h < j + 2; h++)
                {
                    if (Math.Abs(matrix[k][h] - szam) >= 300 && matrix[k][h] != -1)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        static void MatrixKiiras()
        {
            Console.WriteLine("A csodás mátrix:");
            for (int i = 1; i < matrix.Count-1; i++)
            {
                for(int j = 1; j < matrix[i].Count-1; j++)
                {
                    if (Piros(i, j))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    Console.Write((matrix[i][j] + " ").PadRight(5, ' '));
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Console.WriteLine();
            }
        }

        static bool Piros(int i, int j)
        {
            for(int h = 0; h < pirosak.Count; h++)
            {
                if (pirosak[h][0] == i && pirosak[h][1] == j)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

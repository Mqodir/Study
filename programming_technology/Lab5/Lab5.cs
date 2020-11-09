using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab5
{
    class Log5
    {
        static void Main(string[] args)
        {
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"input.txt");
            Console.SetIn(new_in);
            Console.SetOut(new_out);
            int N = Convert.ToInt32(Console.ReadLine());
            int M = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[N, M];
            Console.WriteLine("**Исходная матрица**");
            for(int i=0; i<N; i++)
            {
                String inputData = Console.ReadLine();
                String[] str_arr = inputData.Split(' ');
                for (int j = 0; j < M; j++)
                {
                    arr[i, j] = Convert.ToInt32(str_arr[j]);
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("**Cумма элементов по каждой строке**");
            for (int i = 0; i < N; i++)
            {
                int summ = 0;
                for (int j = 0; j < M; j++)
                {
                    summ += arr[i, j];
                }
                Console.WriteLine(summ);
            }
            Console.WriteLine("**Cумма элементов по каждому столбцу**");
            for (int j = 0; j < M; j++)
            {
                int summ = 0;
                for (int i = 0; i < N; i++)
                {
                    summ += arr[i, j];
                }
                Console.Write(summ+" ");
            }

            Console.SetIn(new_in);
            Console.SetOut(new_out);
            new_in.Close();
            new_out.Close();
        }

        static void generateMatrix(int N, int M)
        {
            TextWriter save_out = Console.Out;
            var new_out = new StreamWriter(@"input.txt");
            Console.SetOut(new_out);
            Console.SetOut(new_out);
            Random rnd = new Random();
            Console.WriteLine(N);
            Console.WriteLine(M);
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(rnd.Next(-100, 100) + " ");
                }
                Console.WriteLine();
            }
            Console.SetOut(new_out);
            new_out.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab4
{
    class Program
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
            String inputData = Console.ReadLine();
            String[] str_arr = inputData.Split(' ');
            int[] arr = new int[N];
            for(int i = 0; i < N; i++)
            {
                arr[i] = Convert.ToInt32(str_arr[i]);
            }
            // сумма элементов, не превышающих по модулю 1000
            int summ = 0;
            for (int i = 0; i < N; i++)
            {
                if (Math.Abs(arr[i]) < 1000)
                {
                    summ += arr[i];
                }
            }
            Console.WriteLine(summ);
            // разность максимального и минимального элемента
            int max_min = arr.Max() - arr.Min();
            Console.WriteLine(max_min);
            // список отрицательных элементов
            for (int i = 0; i < N; i++)
            {
                if (arr[i] < 0)
                {
                    Console.Write(arr[i] + " ");
                }
            }

            Console.SetIn(new_in);
            Console.SetOut(new_out);
            new_in.Close();
            new_out.Close();
        }

        static void generateInput(int N)
        {
            TextWriter save_out = Console.Out;
            var new_out = new StreamWriter(@"input.txt");
            Console.SetOut(new_out);
            Console.SetOut(new_out);
            Random rnd = new Random();
            Console.WriteLine(N);
            for (int i=0; i<N; i++)
            {
                Console.Write(rnd.Next(-10000, 10000)+" ");
            }
            Console.SetOut(new_out);
            new_out.Close();
        }
    }
}

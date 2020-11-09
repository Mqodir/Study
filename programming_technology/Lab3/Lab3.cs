using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab3
{
    class Lab3
    {
        static void Main(string[] args)
        {
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"input.txt");
            Console.SetIn(new_in);
            Console.SetOut(new_out);

            int t = 0, N = 1;
            Double X = 0, Y = 0;
            t = Convert.ToInt32(Console.ReadLine());
            N = Convert.ToInt32(Console.ReadLine());
            X = Convert.ToDouble(Console.ReadLine());
            Y = Convert.ToDouble(Console.ReadLine());
            
            int i = 1, step = 1, s_ = 1;
            Double Z = 0;
            switch (t)
            {
                case 0:
                    for (i = 1; i <= N; i++)
                    {
                        if(i%2 != 0)
                        {
                            Z += (Math.Pow(X, i) + Math.Pow(Y, i)) / step * (step + 2 - s_);
                        }
                        else
                        {
                            Z -= (Math.Pow(X, i) - Math.Pow(Y, i)) / step * (step + 2 - s_);
                        }
                        step += 2 - s_;
                        s_ = 0;
                    }
                    Console.WriteLine(Z);
                    break;
                case 1:
                    while (i <= N)
                    {
                        if (i % 2 != 0)
                        {
                            Z += (Math.Pow(X, i) + Math.Pow(Y, i)) / step * (step + 2 - s_);
                        }
                        else
                        {
                            Z -= (Math.Pow(X, i) - Math.Pow(Y, i)) / step * (step + 2 - s_);
                        }
                        step += 2 - s_;
                        s_ = 0;
                        i++;
                    }
                    Console.WriteLine(Z);
                    break;
                case 2:
                    do
                    {
                        if (i % 2 != 0)
                        {
                            Z += (Math.Pow(X, i) + Math.Pow(Y, i)) / step * (step + 2 - s_);
                        }
                        else
                        {
                            Z -= (Math.Pow(X, i) - Math.Pow(Y, i)) / step * (step + 2 - s_);
                        }
                        step += 2 - s_;
                        s_ = 0;
                        i++;
                    } while (i <= N);
                    Console.WriteLine(Z);
                    break;
            }
            Console.SetIn(new_in);
            Console.SetOut(new_out);
            new_in.Close();
            new_out.Close();
        }
    }
}

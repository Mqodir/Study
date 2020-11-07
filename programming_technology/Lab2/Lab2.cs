using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab2
{
    class Lab2
    {
        static void Main(string[] args)
        {
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"input.txt");
            Console.SetIn(new_in);
            Console.SetOut(new_out);
            Double apo, boo, css, ddd, ew;
            apo = Convert.ToDouble(Console.ReadLine());
            boo = Convert.ToDouble(Console.ReadLine());
            css = Convert.ToDouble(Console.ReadLine());
            ddd = Convert.ToDouble(Console.ReadLine());
            ew = Convert.ToDouble(Console.ReadLine());
            if (boo != 0 && css != 0 && ddd != 0)
            {
                double f = (apo / boo) + (boo + css) + (css + ddd);
                Console.WriteLine(f);
            }
            else
            {
                Console.WriteLine("ERROR");
            }
            if (ddd > Math.Sqrt(Math.Abs(ew - apo)))
            {
                double g = Math.Sqrt(ddd - Math.Sqrt(Math.Abs(ew - apo)));
                Console.WriteLine(g);
            }
            else
            {
                Console.WriteLine("ERROR");
            }
            Console.SetIn(new_in);
            Console.SetOut(new_out);
            new_in.Close();
            new_out.Close();
        }
    }
}

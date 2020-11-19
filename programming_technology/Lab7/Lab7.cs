using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Lab7
    {
        static void Main(string[] args)
        {
            PrTr prtr = new PrTr(15, 5);
            prtr.printInfo();
            Console.WriteLine("Прошадь триугольника: " + prtr.calculateSquare());
            Console.ReadKey();
        }
    }

    class PrTr
    {
        int a; //первый катет
        int b; //первый катет
        int c; //гипотенуза
        public void setA(int a_)
        {
            this.a = a_;
        }
        public void setB(int b_)
        {
            this.b = b_;
        }

        public int getA()
        {
            return a;
        }
        public int getB()
        {
            return b;
        }
        public int getC()
        {
            return c;
        }

        public PrTr(int a_, int b_)
        {
            this.a = a_;
            this.b = b_;
            this.c = calculateC();
        }

        public void printInfo()
        {
            Console.WriteLine("Первый катет: " + a);
            Console.WriteLine("Второй катет: " + b);
            Console.WriteLine("Гипотенуза: " + c);
        }

        public float calculateSquare()
        {
            return 0.5f * a * c;
        }
        public int calculateC()
        {
            return Convert.ToInt32( Math.Sqrt((a*a)+(b*b)));
        }
    }
}

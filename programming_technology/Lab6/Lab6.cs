using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Lab6
    {
        static void Main(string[] args)
        {
            MatrixNM matrix = new MatrixNM();
            matrix.initMatrixNM(5, 8);
            matrix.printInfo();
            Console.WriteLine();
            matrix.printMatrix();
            Console.WriteLine();
            matrix.printTranspon(matrix.transpon());
            Console.WriteLine();
            Console.WriteLine("Ср. ариметическая:" + matrix.sr_ar());
            Console.ReadKey();
        }
    }

    class MatrixNM
    {
        int N, M;
        int[,] matrix;
        public void initMatrixNM(int N, int M)
        {
            Random rnd = new Random();
            this.N = N;
            this.M = M;
            matrix = new int[N, M];
            for (int i=0; i < N; i++)
            {
                for (int j=0; j < M; j++)
                {
                    matrix[i, j] = rnd.Next(-100, 100);
                }
            }
        }

        public int[,] transpon()
        {
            int[,] matrixTranspon = new int[M, N];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Random rnd = new Random();
                    matrixTranspon[i, j] = matrix[j, i];
                }
            }
            return matrixTranspon;
        }

        public float sr_ar()
        {
            int summ = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    summ = matrix[i, j];
                }
            }
            return summ / matrix.Length;
        }

        public void printTranspon(int[,] transpon)
        {
            for (int i = 0; i < M; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < N; j++)
                {
                    Console.Write( transpon[i, j]+" ");
                }
            }
        }

        public void printInfo()
        {
            Console.WriteLine("**************************");
            Console.WriteLine("*                        *");
            Console.WriteLine("*     Матрица N на M     *");
            Console.WriteLine("*                        *");
            Console.WriteLine("**************************");
        }

        public void printMatrix()
        {
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < M; j++)
                {
                    Console.Write( matrix[i, j]+" ");
                }
            }
        }
    }
}
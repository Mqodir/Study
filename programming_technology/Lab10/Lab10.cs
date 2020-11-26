using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab10
{
    class Lab10
    {
        static void Main(string[] args)
        {
            Matrix m1 = new Matrix();
            if (m1.LoadMatrix("C:/Users/MQ/Desktop/uchyoba/с#/Lab10/Lab10/bin/Debug/Matrix1.txt"))
            {
                Console.WriteLine("Первая матрица:");
                ShowMatrix(m1.getMatrix(), m1.getSize());
            }
            else
            {
                Console.WriteLine("Ошибка при чтении файла");
            }

            Matrix m2 = new Matrix();
            if (m2.LoadMatrix("C:/Users/MQ/Desktop/uchyoba/с#/Lab10/Lab10/bin/Debug/Matrix2.txt"))
            {
                Console.WriteLine("Вторая матрица:");
                ShowMatrix(m2.getMatrix(), m2.getSize());
            }
            else
            {
                Console.WriteLine("Ошибка при чтении файла");
            }

            Console.WriteLine("Матрица транспонированная относительно второй: ");
            ShowMatrix(m2.getTransponMatrix(), m2.getSize());

            Console.WriteLine("Сумма матриц: ");
            ShowMatrix(SummMatrix(m1.getSize(), m1.getMatrix(), m2.getTransponMatrix()), m1.getSize());
            Console.ReadKey();
        }

        static void ShowMatrix(float[,] matrix, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static float[,] SummMatrix(int size, float[,] m1, float[,] m2)
        {
            float[,] summ = new float[size, size];
            for (int i=0; i<size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    summ[i, j] = m1[i, j] + m2[i, j];
                }
            }
            return summ;
        }
        
    }


    class Matrix
    {
        int m;
        int n;
        float[,] matrix;
        public Boolean LoadMatrix(string pFileName)
        {
            if (File.Exists(pFileName))
            {
                try
                {
                    TextReader tr = File.OpenText(pFileName);
                    m = Convert.ToInt32(tr.ReadLine());
                    n = Convert.ToInt32(tr.ReadLine());

                    matrix = new float[m, n];
                    string line;
                    string[] substring;

                    for(int i=0; i<m; i++)
                    {
                        line = tr.ReadLine();
                        for (int j=0; j<n; j++)
                        {
                            substring = line.Split(new char[] { ' ' }, 3);
                            matrix[i, j] = Convert.ToSingle(substring[j]);
                        }
                    }
                    tr.Close();
                    return true;
                }
                catch
                {
                    Console.WriteLine("Error on load Matrix");
                    return false;
                }
            }else
            {
                Console.WriteLine("File Not Exist");
                return false;
            }
        }

        public int getSize()
        {
            return m;
        }
        public float[,] getMatrix()
        {
            return matrix;
        }

        public float[,] getTransponMatrix()
        {
            float[,] transponMatrix = new float[m, n];
            for(int i=0; i<m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    transponMatrix[i, j] = matrix[j, i];
                }
            }
            return transponMatrix;
        }

    }
}

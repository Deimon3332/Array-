using System;
using System.Linq;


//Задача 29. Переворот


namespace array11_33
{
    internal class Class29
    {
        public static void main()
        {
            int N = 0, M = 0;

            int[] arr = new int[2];
            arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            N = arr[0];
            M = arr[1];



            int[,] array = new int[N, M];
            int[] array1 = new int[N];
            for (int i = 0; i < N; i++)
            {
                array1 = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int j = 0; j < M; j++)
                {
                    array[i, j] = array1[j];
                }
            }

            int[,] array2 = new int[M, N];
            int i2 = 0, j2 = N - 1;
            for (int i = 0; i < N; i++)
            {
                i2 = 0;
                for (int j = 0; j < M; j++)
                {
                    array2[i2, j2] = array[i, j];
                    i2++;
                }
                j2--;
            }

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(array2[i, j] + "\t");
                }
                Console.Write("\n");
            }


        }
    }
}
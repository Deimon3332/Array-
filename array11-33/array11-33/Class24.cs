using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Завдання 24. Трикутник Паскаля


namespace array11_33
{
    internal class Class24
    {
        public static void main()
        {
            int N = 0, M = 0;

                int[] arr = new int[2];
                arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                N = arr[0];
                M = arr[1];


            int[,] array = new int[N, M];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (i == 0 || j == 0) array[i, j] = 1;
                    else array[i, j] = array[i, j - 1] + array[i - 1, j];
                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.Write("\n");
            }


        }
    }
}
using System;
using System.Linq;


//Завдання 20. Змагання – 3


namespace array11_33
{
    internal class Class20
    {

        public static void main()
        {
            int N = 0, M = 0, Max = 0, maxI = 0;


            int[] arr = new int[2];
            arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            N = arr[0];
            M = arr[1];

            int[,] array = new int[N, M];
            int[] array1 = new int[M];
            for (int i = 0; i < N; i++)
            {

                array1 = Console.ReadLine().Split().Select(int.Parse).ToArray();


                for (int j = 0; j < M; j++)
                {
                    array[i, j] = array1[j];
                }
            }


            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (Max < array[i, j])
                    {
                        Max = array[i, j];
                        maxI = i;
                    }
                }
            }

            Console.WriteLine(maxI);

        }
    }
}
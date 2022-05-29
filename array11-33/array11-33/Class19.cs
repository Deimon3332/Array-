using System;
using System.Linq;


//Завдання 19. Змагання – 2


namespace array11_33
{
    internal class Class19
    {
        public static void main()
        {
            int N = 0, M = 0, max = 0, maxI = 0, maxJ = 0;

            try
            {
                int[] arr = new int[2];
                arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                N = arr[0];
                M = arr[1];
            }
            catch (System.FormatException)
            {
                Console.WriteLine("error FormatException" + '\a');
                Environment.Exit(0);//прервать выполнение
            }

            int[,] array = new int[N, M];
            int[] tempArray = new int[M];
            for (int i = 0; i < N; i++)
            {

                    tempArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int j = 0; j < M; j++)
                {
                    array[i, j] = tempArray[j];
                }
            }


            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (max < array[i, j])
                    {
                        max = array[i, j];
                        maxI = i;
                        maxJ = j;
                    }
                }
            }

            Console.WriteLine(max + "\n" + maxI + " " + maxJ);

        }
    }
}
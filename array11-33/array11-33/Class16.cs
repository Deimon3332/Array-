using System;


//Завдання 16. Побічна діагональ


namespace array11_33
{
    internal class Class16
    {
        public static void main()
        {
            int N = 0;


            N = Convert.ToInt32(Console.ReadLine());

            int[,] array = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (i + j == N - 1) array[i, j] = 1;
                    else if (i + j > N - 1) array[i, j] = 2;
                    else array[i, j] = 0;
                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.Write("\n");
            }
        }
    }
}
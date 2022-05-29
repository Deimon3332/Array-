using System;
using System.Linq;


//Завдання 14. Суперсдвиг

namespace array11_33
{
    internal class Class14
    {
        public static void main()
        {
            int N = 0, K = 0;

            N = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[N];

            array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            K = Convert.ToInt32(Console.ReadLine());



            for (int i = 0; i < N; i++)
            {
                if (K > 0) K %= N;
                else K = N - ((-K) % N);
            }

            for (int i = N - K; i < N; i++)
            {
                Console.Write(array[i] + " ");
            }

            for (int i = 0; i < N - K; i++)
            {
                Console.Write(array[i] + " ");
            }


        }
    }
}
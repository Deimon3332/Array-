using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Завдання 26. Заповнення змійкою


namespace array11_33
{
    internal class Class26
    {
        public static void main()
        {
            int N = 0, M = 0;
            char a = 'd'; 


                int[] arr = new int[2];
                arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                N = arr[0];
                M = arr[1];


            int[,] array = new int[N, M];



            int i = 0, j = 0;
            int k = 0;
            while (k < N * M)
            {
                array[i, j] = k;

                if (a == 'd')
                {
                    j++;
                    if (j == M)
                    {
                        i++;
                        a = 'a';
                    }
                }

                if (a == 'a')
                {
                    j--;
                    if (j == -1)
                    {
                        j++;
                        i++;
                        a = 'd';
                    }
                }

                k++;
            }

            for (i = 0; i < N; i++)
            {
                for (j = 0; j < M; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.Write("\n");
            }


        }


    }
}
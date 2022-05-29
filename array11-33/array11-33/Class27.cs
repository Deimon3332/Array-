using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Завдання 27. Заповнення діагоналями


namespace array11_33
{
    internal class Class27
    {
        public static void main()
        {
            int N = 0, M = 0;


                int[] arr = new int[2];
                arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                N = arr[0];
                M = arr[1];


            int[,] array = new int[N, M];
            int k = 0;
            int i = 0;
            int j = 0;
            int ik = 0;
            int jk = 1;


            while (k < N * M)
            {
                array[i, j] = k;

                if (i + 1 < N && j - 1 > -1)
                {
                    i++;
                    j--;
                }
                else
                {
                    i = ik;
                    j = jk;
                    if (jk + 1 < M)
                    {
                        jk++;
                    }
                    else ik++;
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
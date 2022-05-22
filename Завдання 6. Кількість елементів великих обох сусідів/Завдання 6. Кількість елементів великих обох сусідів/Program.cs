using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Завдання 6. Кількість елементів великих обох сусідів

namespace Task6
{
    internal class Array
    {
        static void Main()
        {
            int N = 0, j = 0;
            string str = Console.ReadLine();

            N = Convert.ToInt32(str);
            int[] array = new int[N];


            array = Console.ReadLine().Split().Select(int.Parse).ToArray();


            for (int i = 1; i < N; i++)
            {
                if (i + 1 < N)
                {
                    if (array[i] > array[i - 1] && array[i] > array[i + 1])
                    {
                        j++;
                    }
                }
            }
            Console.WriteLine(j); ;
        }
    }
}


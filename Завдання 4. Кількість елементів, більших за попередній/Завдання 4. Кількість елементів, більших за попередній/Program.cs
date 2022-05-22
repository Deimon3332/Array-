using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Завдання 4. Кількість елементів, більших за попередній


namespace Task4
{
    internal class Array
    {
        static void Main()
        {
            int N = 0, j = 0 ;
            string str = Console.ReadLine();

            N = Convert.ToInt32(str);
            int[] array = new int[N];


            array = Console.ReadLine().Split().Select(int.Parse).ToArray();


            for (int i = 1; i < N; i++)
            {
               // Console.Write(array[i] + " ");
                if (array[i-1] < array[i])

                {
                    j++;
                } 
            }
            Console.WriteLine("Количество эллементов больше за следующие = " + j);
        }
    }
}
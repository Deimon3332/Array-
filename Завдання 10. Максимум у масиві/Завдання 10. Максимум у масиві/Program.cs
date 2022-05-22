using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Завдання 10. Максимум у масиві

namespace Task10
{
    internal class Array
    {
        static void Main()
        {
            int N = 0;
            string str = Console.ReadLine();

            N = Convert.ToInt32(str);
            int[] array = new int[N];


            array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int maxarray = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] > maxarray)
                {
                    maxarray = array[i];
                }
            }
            Console.WriteLine( maxarray);
        }
    }
}


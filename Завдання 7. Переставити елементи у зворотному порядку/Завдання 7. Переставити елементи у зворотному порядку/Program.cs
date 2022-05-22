using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Завдання 7. Переставити елементи у зворотному порядку

namespace Task7
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


            for (int i = array.Length-1; i>=0; i--)
            {
                Console.WriteLine(array[i]);
            }
            
        }
    }
}
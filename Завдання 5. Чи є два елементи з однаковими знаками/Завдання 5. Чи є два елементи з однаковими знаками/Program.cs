using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Завдання 5. Чи є два елементи з однаковими знаками


namespace Task5
{
    internal class Array
    {
        static void Main()
        {
            int N = 0, j=0;
            string str = Console.ReadLine();

            N = Convert.ToInt32(str);
            int[] array = new int[N];


            array = Console.ReadLine().Split().Select(int.Parse).ToArray();


            for (int i = 1; i < N; i++)
            {
                if (array[i - 1] > 0 && array[i] > 0 || array[i - 1] < 0 && array[i] < 0)
                {
                    j++;
                }

            }
            if (j > 0)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}

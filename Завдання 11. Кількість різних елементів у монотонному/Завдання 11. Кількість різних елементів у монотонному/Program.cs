using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Завдання 11. Кількість різних елементів у монотонному масиві



namespace Task11
{
    internal class Array
    {
        static void Main()
        {
            int N = 0, j = 1;
            bool rand = true;
            string str = Console.ReadLine();

            N = Convert.ToInt32(str);
            int[] array = new int[N];


            array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < N; i++)
            {
                rand = true;
                for (int d = 0; d < N; d++)
                {
                    if (d != i)
                    {
                        if (array[i] == array[d])
                        {
                            rand = false;
                        }
                    }
                }
                if (rand)
                {
                    j++;
                }
               
            }
            Console.WriteLine(j);
        }
    }
}
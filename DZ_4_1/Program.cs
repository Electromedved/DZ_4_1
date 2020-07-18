using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_4_1
{
    class Program
    {
        //9. Используя датчик случайных чисел, заполнить массив из двадцати элементов НЕПОВТОРЯЮЩИМИСЯ числами.

        static void Main(string[] args)
        {
            Random rand = new Random();

            int[] numbArr = new int[20];

            for (int i = 0; i < numbArr.Length; i++)
            {
                numbArr[i] = rand.Next(1, 100);

                for (int j = 0; j < numbArr.Length; j++)
                {
                    if (numbArr[j] == numbArr[i])
                    {
                        numbArr[i] = rand.Next(1, 100);
                    }
                }
            }

            foreach (int i in numbArr)
            {
                Console.Write($"{i} ");
                //Console.WriteLine(numbArr[i]);
            }

            Console.ReadLine();

            //Это не работает и я не знаю почему.
        }
    }
}

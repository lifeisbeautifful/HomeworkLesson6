using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
   /* Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
Создайте программу, в которой создайте массив размерностью в 5 элементов, выведите на экран все элементы массива в обратном порядке.*/

    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }

           foreach (var item in numbers.Reverse())
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}

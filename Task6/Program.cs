using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    /*Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
Создайте программу, в которой создайте массив размера N элементов(размер массива задет пользователь), заполнить его произвольными 
    целыми значениями.Вывести на экран: наибольшее значение массива, наименьшее значение массива, общую сумму всех элементов, 
    среднее арифметическое всех элементов, вывести все нечетные значения.*/

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of array: ");
            int size = int.Parse(Console.ReadLine());

            int[] overalArray = new int[size];
            int[] oddNumbers = new int[size];
            int counter = 0;

            int maxValue = 0;
            int minValue = 20;
            int sumOfNumbers = 0;
            double average = 0;

            Random rand = new Random();

            for (int i = 0; i < overalArray.Length; i++)
            {
                int num = rand.Next(1, 20);
                overalArray[i] = num;
                if (num > maxValue)
                {
                    maxValue = num;
                }
                if (num < minValue)
                {
                    minValue = num;
                }

                Console.Write(overalArray[i]+", ");
                sumOfNumbers += num;
                average = (double)sumOfNumbers / size;

                if (overalArray[i] % 2 != 0)
                {
                    oddNumbers[counter] = overalArray[i];
                    counter++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Max value = {0}",maxValue);
            Console.WriteLine("Min value = {0}",minValue);
            Console.WriteLine("The sum of numbers = {0}",sumOfNumbers);
            Console.WriteLine("The average = {0}",average);
            Console.WriteLine("Odd numbers in array:");

            for (int i = 0; i < oddNumbers.Length; i++)
            {
                if (oddNumbers[i] > 0)
                {
                    Console.WriteLine(oddNumbers[i]);
                }
            }
            Console.ReadLine();
        }
    }
}

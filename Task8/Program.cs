using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    /*Используя Visual Studio, создайте проект по шаблону ConsoleApplication.Создайте программу, в которой создайте метод, который 
    будет выполнять увеличение длины массива переданного в качестве аргумента, на 1 элемент.Метод, должен принимает два аргумента, 
    первый аргумент - типа int[] array, второй аргумент - типа int value.В теле метода реализуйте возможность добавления второго аргумента 
    метода в массив по индексу – 0, при этом длина нового массива, должна увеличиться на 1 элемент, а элементы получаемого массива в 
    качестве первого аргумента должны скопироваться в новый массив начиная с индекса - 1.*/
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i;
            }
           
            copyArray(numbers, 10);
            Console.ReadLine();
        }
        static void copyArray(int[] array, int value)
        {
            int[] copiedArray = new int[array.Length+1];
            copiedArray[0] = value;
            array.CopyTo(copiedArray, 1);

            foreach (var item in copiedArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}

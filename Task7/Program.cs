using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    /*Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
Создайте программу, в которой создает метод, который в качестве аргументов принимает: 1)целочисленный массив(int[] array), 2)целочисленный
    индекс(int index), 3)количество элементов(int count), возвращает целочисленный массив элементов(int[] subArray). 
    Метод возвращает часть полученного в качестве аргумента массива, начиная с позиции указанной в аргументе index, размерностью, 
    которая соответствует значению аргумента count*/

    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[30];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i;
            }
            
            int count = 10;
            int index = 5;
            fillSubArray(index, count, numbers);

          Console.ReadLine();
        }
        static void fillSubArray(int index,int count,int[] array)
        {
            int[] subArray = new int[count];

            for (int i = 0; i < subArray.Length; i++)
            {
                subArray[i] = array[index];
                Console.WriteLine(subArray[i]);
                index++;
            }
        }
    }
}

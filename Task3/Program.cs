using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    /*Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
Создайте программу, в которой создайте два строковых массива с именами A и B(размерностью 4 элемента). Массив A заполняется в цикле 
    пользователем.Получить результирующий массив B, обратный к исходному массиву A (элементы массива B идут в обратном порядке по 
    отношению к массиву A).*/

    class Program
    {
        static void Main(string[] args)
        {
            string[] A = new string[4];
            int counter = 0;

            for (int i = 0; i < A.Length; i++)
            {
                A[i] = Console.ReadLine();
            }

            string[] B = new string[4];
            foreach (var item in A.Reverse())
            {
                B[counter] = item;
                counter++;
            }

            foreach (var item in B)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}

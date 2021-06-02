using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    /*Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
Создайте программу, в которой создайте массив целых чисел размерности 10х10 и заполните его случайными элементами.Выведете на консоль
    полученный массив. Найдите суммы элементов каждой строки, произведения элементов каждого столбца, и максимальный элемент главной 
    диагонали (подсказка: все элементы, для которых номер строки совпадает с номером столбца). */

    class Program
    {
        static void Main(string[] args)
        {
            int[,] randomNumbers = new int[10, 10];
            Random random = new Random();
            int multiplied = 1;
            int rowCount = 0;
            int maxDiagonalNumber = 0;

            for (int i = 0; i < 10; i++)
            {
                int sum = 0;
                
                for (int j = 0; j < 10; j++)
                {
                    randomNumbers[i, j] = random.Next(1, 10);
                    Console.Write(randomNumbers[i, j] + "  ");
                    sum = sum + randomNumbers[i, j];
                    if (i == j)
                    {
                        if (maxDiagonalNumber < randomNumbers[i, j])
                        {
                            maxDiagonalNumber = randomNumbers[i, j];
                        }
                    }
                }
                Console.WriteLine("  "+"The sum of {0} column = {1}",i+1,sum);
            }

            Console.WriteLine();
            while (rowCount < 10)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (j == rowCount)
                        {
                            multiplied = multiplied * randomNumbers[i, j];
                        }
                    } 
                }
                Console.WriteLine("The multiplication of {0} row = {1}",rowCount+1, multiplied);
                rowCount++;
                multiplied = 1;
            }

            Console.WriteLine();
            Console.WriteLine("Maximun main diagonal number = {0}",maxDiagonalNumber);
            Console.ReadLine();
        }
    }
}

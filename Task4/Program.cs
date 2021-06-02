using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    /*Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
Создайте программу, в которой создайте метод, который в качестве параметра принимает слово, а возвращает тоже слово, но с измененным 
    порядком букв в слове на обратный*/

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter word: ");
            string word = Console.ReadLine();
            Reverse(word);

            Console.ReadLine();
        }
        static void Reverse(string word)
        {
            for (int i = word.Length-1; i >= 0; i--)
            {
                Console.WriteLine(word[i]);
            }
        }
    }
}

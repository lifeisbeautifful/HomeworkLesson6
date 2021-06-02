using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    /*Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
Создайте программу, в которой пользователь вводит прибыль фирмы за 12 месяцев.После чего пользователь вводит диапазон
    (например, 3 и 6 – поиск между 3-м и 6-м месяцем). Необходимо определить месяц, в котором прибыль была максимальна и месяц, 
    в котором прибыль была минимальна с учетом выбранного диапазона.*/

    class Program
    {
        static void Main(string[] args)
        {
            double[] yearProfit = new double[12];

            for (int i = 0; i < 12; i++)
            {
                Console.Write("profit for {0} month: ",i+1);
                yearProfit[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Enter the range of months: ");

            Console.Write("Start with: ");
            int firstInrange = int.Parse(Console.ReadLine());

            Console.Write("End with: ");
            int lastInRange = int.Parse(Console.ReadLine());

            CalcProfit(firstInrange,lastInRange,yearProfit);
            Console.ReadLine();
        }
        static void CalcProfit(int first,int last, params double[] profit)
        {
            double maxValue = 0;
            double minValue = profit[first-1];
           
            for (int i = first-1; i < last; i++)
            {
                 if (profit[i] > maxValue)
                {
                    maxValue = profit[i];
                }
                if (profit[i] <= minValue)
                {
                    minValue = profit[i];
                } 
            }

           Console.Write("Maximum profit was in: ");
             for (int i = 0; i < profit.Length; i++)
            {
                if (profit[i] == maxValue)
                {
                    Console.Write(i+1+" ");
                }   
            }
            Console.Write("month(s)");
            Console.WriteLine();

            Console.Write("Minimum profit was in: ");
            for (int i = 0; i < profit.Length; i++)
            {
                if (profit[i] == minValue)
                    {
                        Console.Write(i+1+" ");
                    }
            }
            Console.WriteLine("month(s)");   
        }
    }
}

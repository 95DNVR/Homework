using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h.w._8._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int triesCount;

            Console.Write("Введите текст пожалуйста ");
            userInput = Console.ReadLine();
            Console.Write("Введите количество вывода текста ");
            triesCount = Convert.ToInt32(Console.ReadLine());

            for (int finalValue = 1; finalValue <= triesCount; triesCount --)
            {
                Console.WriteLine(triesCount + ") " + userInput);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_8._17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int triesCount;

            Console.WriteLine("введите текст пожалуйста ");
            userInput = Console.ReadLine();
            Console.WriteLine("Введите количество выводов ");
            triesCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 1;  i <= triesCount; i++)
            {
                Console.WriteLine( i + ") " + userInput);
            }
        }
    }
}

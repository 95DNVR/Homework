using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace аааа
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int numberOfUserInput;

            Console.Write("Введите ваш текст ");
            userInput = Console.ReadLine();
            Console.Write("Введите количество выводов текста ");
            numberOfUserInput = Convert.ToInt32(Console.ReadLine());

            while (numberOfUserInput >= 1)
            {
                Console.WriteLine(numberOfUserInput-- + ")" + userInput);
            }
        }
    }
}

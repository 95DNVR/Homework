using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h.w._8._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int numberOfUserImput;

            Console.Write("Введите текст пожалуйста ");
            userInput = Console.ReadLine();
            Console.Write("Введите количество вывода текста ");
            numberOfUserImput = Convert.ToInt32(Console.ReadLine());

            while (numberOfUserImput >= 1)
            {
                Console.WriteLine(numberOfUserImput + ") " + userInput);
                numberOfUserImput--;
            }
        }
    }
}

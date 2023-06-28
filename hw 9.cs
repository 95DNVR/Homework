using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stopWord = "exit";
            string userInput;

            while (true)
            {
                Console.WriteLine("Введите ,пожалуйста, пароль ");
                userInput = Console.ReadLine();
                if (stopWord == userInput) 
                {
                    Console.WriteLine("- Вот пароль");
                    break;
                }
                else
                {
                    Console.WriteLine("- Это по твоему пароль?");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stopWord = "exit";
            string userInput;

            while (true)
            {
                Console.WriteLine("Введите код, пожалуйста: ");
                userInput = Console.ReadLine();
                if (userInput == stopWord)
                {
                    Console.WriteLine("Ну вот можешь же когда захочешь");
                    break;
                }
                else
                {
                    Console.WriteLine(" Не,не,не давай по новой");
                }
            }
        }
    }
}

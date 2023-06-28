using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw9._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stopWord = "exit";
            string userInput;
            bool isContinue = false;

            while (isContinue == false)
            {
                Console.WriteLine("Введите пароль ");
                userInput = Console.ReadLine();

                if (userInput == stopWord) 
                {
                    isContinue = true;
                    Console.WriteLine("Отлично");
                }
                else
                {
                    Console.WriteLine("Не верно");
                }
            }
        }
    }
}

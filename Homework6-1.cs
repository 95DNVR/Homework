using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int availableGold;
            int numberOfCrystals;
            int crystalCost = 2;

            Console.Write(" Здравствуйте. Проходите не стесняйтесь сегодня акция все товары по " + crystalCost + " золотых.");
            Console.Write(" Сколько у вас золотых? ");
            availableGold = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Сколько желаете взять кристаллов? ");
            numberOfCrystals = Convert.ToInt32(Console.ReadLine());
            availableGold -= numberOfCrystals * crystalCost;
            Console.WriteLine(" Ваши " + numberOfCrystals + " кристалов. Ваша сдача " + availableGold + " золотых.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPicture = 52;
            int numberOfPicturesInOneRow = 3;
            int numberOfCompletedRow;
            int numberOfRemainingPicture;
            numberOfCompletedRow = numberOfPicture / numberOfPicturesInOneRow;
            numberOfRemainingPicture = numberOfPicture % numberOfPicturesInOneRow;
            Console.WriteLine("                       Специальная зона)" );
            Console.WriteLine(" (Ricardo Milos.jpg) (Billy Harington.jpg) (Van Darkholme.jpg)" );
            Console.WriteLine("                Картинок отображено - 3 из 3" );
            Console.WriteLine("                         Ряд 1 из " + numberOfCompletedRow );
            Console.WriteLine("                Картинок сверх меры - " + numberOfRemainingPicture );
        }
    }
}

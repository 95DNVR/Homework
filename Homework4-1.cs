using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hgjhgcj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPictures = 52;
            int numberOfPicturesInOneRow = 3;
            int numberOfCompletedRows;
            int numberOfRemainingPictures;

            numberOfCompletedRows = numberOfPictures / numberOfPicturesInOneRow;
            numberOfRemainingPictures = numberOfPictures % numberOfPicturesInOneRow;
            Console.WriteLine("                       Специальная зона)");
            Console.WriteLine(" (Ricardo Milos.jpg) (Billy Harington.jpg) (Van Darkholme.jpg)");
            Console.WriteLine("                Картинок отображено - 3 из " + numberOfPicturesInOneRow);
            Console.WriteLine("                         Ряд 1 из " + numberOfCompletedRows);
            Console.WriteLine("                Картинок сверх меры - " + numberOfRemainingPictures);
        }
    }
}

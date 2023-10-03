using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите максимально целое число диапозона");
            int max = int.Parse(Console.ReadLine());
            Random rand = new Random();
            int iiNumber = rand.Next(1,max);
            int count = 0;
            int usernumber; 
            while (true)
            {
                Console.WriteLine("\nВведите число");
                count++;
                usernumber = int.Parse(Console.ReadLine());
                if (usernumber < iiNumber)
                {
                    Console.WriteLine("Ваше число меньше загаданного");
                }
                else if (usernumber > iiNumber)
                {
                    Console.WriteLine("Ваше число больше загаданного");
                }
                else if (usernumber ==  iiNumber)
                {
                    Console.WriteLine("Вы угадали");
                    Console.ReadKey();
                    break;
                }
            }
        }
    }
}

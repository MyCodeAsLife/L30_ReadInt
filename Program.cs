using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L30_ReadInt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userNumber = NumberRequest();

            Console.WriteLine($"\nПользователь ввел число: {userNumber}");
        }

        static int NumberRequest()
        {
            int number = 0;
            bool correctAction = false;

            while (correctAction == false)
            {
                Console.Clear();
                Console.Write("Введите число: ");
                correctAction = int.TryParse(Console.ReadLine(), out number);
            }

            return number;
        }
    }
}

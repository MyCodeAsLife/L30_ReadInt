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
            int userNumber = GetNumber();

            Console.WriteLine($"\nПользователь ввел число: {userNumber}");
        }

        static int GetNumber()
        {
            int number = 0;
            bool isCorrectAction = false;

            while (isCorrectAction == false)
            {
                Console.Clear();
                Console.Write("Введите число: ");
                isCorrectAction = int.TryParse(Console.ReadLine(), out number);
            }

            return number;
        }
    }
}

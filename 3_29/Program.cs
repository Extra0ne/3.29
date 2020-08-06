using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_29
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Введите число :");
            double num = 0;
            try
            {
                num = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException err)
            {

                Console.WriteLine("Введеное число не являеться целым");
                Console.ReadKey();
                return;
            }
            if (num % 1 == 0)
            {
                Console.WriteLine("Введеное число целое");
            }

            Console.ReadLine();
        }
    }
}
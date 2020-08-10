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

            var num = Convert.ToDouble(Console.ReadLine());
            if (num%1==0)
            {
                Console.WriteLine("Введеное число целое");
            }
            else
            {
                Console.WriteLine("Введеное число не являеться целым");
              
            }

            Console.ReadLine();
        }
    }
}
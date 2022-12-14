using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reversenumber
{
    internal class Program
    {
         static void Main(string[]args)
        {
            Program.reverse( 123);
        }
        public static void reverse(int num )

        {
            Console.WriteLine("enter the input number");
            num = Convert.ToInt32(Console.ReadLine());

            int remainder = 0, reverse = 0;
            while (num != 0)
            {
                remainder = num % 10;
                reverse = (reverse * 10) + remainder;
                num = num / 10;

            }
            Console.WriteLine("the reverse num is :" + reverse);
            Console.ReadLine();
        

        }
    }
}

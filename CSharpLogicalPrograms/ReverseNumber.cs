using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLogicalPrograms
{
    public class ReverseNumber
    {
        public void GetReverseNumber()
        {
            int remainder, reverse = 0;
            Console.WriteLine("Enter the number to be Reversed");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Original Number: " + number);
            while (number != 0)
            {
                remainder = number % 10;
                reverse = (reverse * 10) + remainder;
                number = number / 10;
            }
            Console.WriteLine("Reverse number: " + reverse);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLogicalPrograms
{
    public class PrimeNumber
    {
        public void CheckPrime()
        {
            int count = 0;
            Console.WriteLine("\nEnter the numbers to find Prime");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
                Console.WriteLine("{0} is a Prime Number", num);           
            else            
                Console.WriteLine("{0} is not a Prime Number", num);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLogicalPrograms
{
    public class PerfectNumber
    {
        //perfect number is a number whose sum of its divisor is equal to the original number
        public void CheckPerfectNumber()
        {
            int sum = 0;
            Console.WriteLine("\nEnter the Number");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <=number/2; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (number == sum)
                Console.WriteLine("{0} is a Prefect number",number);
            else
                Console.WriteLine("{0} is not a Prefect number",number);
        }
    }
}

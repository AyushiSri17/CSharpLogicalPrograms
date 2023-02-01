using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLogicalPrograms
{
    public class Fibonacci
    {
        int firstNum = 0, secondNum = 1, thirdNum=0;
        public void FibonacciSerirs(int n)
        {
            Console.WriteLine("Fibonacci Series: ");
            while (n>0)
            {
                Console.Write(firstNum);
                thirdNum = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = thirdNum;
                n--;
            }
        
        }

    }
}

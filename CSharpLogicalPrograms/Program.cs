using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLogicalPrograms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C# logical Programs");

            Console.WriteLine("Enter the option to perform perticular program");
            Console.WriteLine("1. Fibonacci Series");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    Console.WriteLine("Enter the number to terms want to print");
                    int term= Convert.ToInt32(Console.ReadLine());
                    Fibonacci fibonacci = new Fibonacci();
                    fibonacci.FibonacciSerirs(term);
                    break;
                default:
                    Console.WriteLine("Enter the correct option");
                    break;
            }

            Console.ReadLine();
        }
    }
}

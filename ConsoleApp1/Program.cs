
using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
           int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Press + for Addition");
            Console.WriteLine("Press - for Subtraction");
            Console.WriteLine("Press * for Multiplication");
            Console.WriteLine("Press / for Division \n");


           string operation;
            operation = Console.ReadLine();

            if (operation == "+")
            {

                int result = Add(num1, num2);

                Console.WriteLine(result);
            }
            else if (operation == "-")
            {

                int result = Subtract(num1, num2);

                Console.WriteLine(result);
            }

            else if (operation == "*")
            {

                int result = Multiply(num1, num2);

                Console.WriteLine(result);
            }
            else if (operation == "/")
            {

                int result = Subtract(num1, num2);

                Console.WriteLine(result);
            }
            else
            {


            }
        }
        //addition
        public static int Add(int a, int b)
        {
            return a + b;
        }
         //subtraction
        public static int Subtract (int a, int b)
        {
            return a - b;
        }
        // Multiplication
        public static int Multiply (int a, int b)
        {
            return a*b;
        }
        // Division
        public static int Divide(int a, int b)
        {
            return a /b;
        }
    }
    
       

       

    
}

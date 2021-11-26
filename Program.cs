using System;

namespace fizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Write a starting number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write ending number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            for (int i=num1;i<=num2;i++)
            {
                if (i%3==0 && i%5==0)
                {
                    Console.WriteLine("FizzBuzz");

                }
                else if (i%3==0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i%5==0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            
            
            Console.Read();

        }
    }
}

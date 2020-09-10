using System;
using System.Globalization;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *write a program that aceppts two numbers (integers)
             *and checks wheter they are equal orn not and display feedback.
             *int a;
             *int b;
             *if(a == b)
             */


            Console.WriteLine("What is your first number?");
            string UserInput = Console.ReadLine();
            int Num1 = Int32.Parse(UserInput);
            Console.WriteLine("What is yor second number?");
            UserInput = Console.ReadLine();
            int Num2 = Int32.Parse(UserInput);

            if (Num1 == Num2)
            {
                Console.WriteLine("the numbers you provided are equal");
            } else
            {
                Console.WriteLine("thenumbers you provided are NOT equal");
            }
          

                    








    }
    }
}

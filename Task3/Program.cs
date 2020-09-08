using System;
using System.Globalization;

namespace Task3
{
    class Program
    {
        static void Main(string[] args, string UserInput2, int NumberFormatInfo, string UserInput1)
        {
            /*
             *write a program that aceppts two numbers (integers)
             *and checks wheter they are equal orn not and display feedback.
             *int a;
             *int b;
             *if(a == b)
             */
            

            Console.WriteLine("What is the first number?");
            UserInput1 = Console.ReadLine();
            Console.WriteLine("What is the second number?");
            UserInput2 = Console.ReadLine();

            int X;
            int Y;
            X = Int32.Parse(UserInput1);
            Y = Int32.Parse(UserInput2);

            if (X > Y)
            {
                Console.WriteLine($"{X} is bigger than {Y}");
            }else if (Y > X)
            {
                Console.WriteLine($"{Y} is bigger than {X}");
            }else
            {
                Console.WriteLine($"{X} and {Y} are equal");
            }

                    
            
              

         







    }
    }
}

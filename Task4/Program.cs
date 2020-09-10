using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that checks wheter a given number
             * is positive or negative.
             */

            Console.WriteLine("What`s your number?");
            string UserImput = Console.ReadLine();
            int Number = Int32.Parse(UserImput);
            if(Number > 0)
            {
                Console.WriteLine("the number is positive.");
            }else if (Number < 0)
            {
                Console.WriteLine("The number is negative.");
            }else
            {
                Console.WriteLine("the number is 0.");
            }


        }
    }
}

using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             write a program that asks user`s year of birth
            *And decides if the user is old enought to get permanted
            *driving license
             */
            Console.WriteLine("What is you birth of year?");
            string UserInput;
            UserInput = Console.ReadLine();
            int Year;
            Year = Int32.Parse(UserInput);
            int Age = 2020 - Year;
            Console.WriteLine("you are" + Age);
            if (Age < 18)
            {
                Console.WriteLine($"you are {Age}, you are too young for driving license.");
            }
            else if (Age > 18)
            {
                Console.WriteLine($"you are {Age}, you are old enought for driving license.");
            }
            else
            {
                Console.WriteLine($"Congratulations! you are {Age}");

            }




        }
    }
}

using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Personality Tests
             * People who love cats are homebirds
             * People who love dogs are partygoers
             * People who love other animals are just animal friends
             */
            string UserInput;
            Console.WriteLine("What is your favorite animal?");
            UserInput = Console.ReadLine();

            if(UserInput == "cat")
            {
                Console.WriteLine("You are homebird.");
            }else if(UserInput == "dog")
            {
                Console.WriteLine("You are partygoer.");
            }else
            {
                Console.WriteLine($"You are a {UserInput} friend.");
            }        
        }
    }
}

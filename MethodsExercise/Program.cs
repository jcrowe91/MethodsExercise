using System;

namespace MethodsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I'd like to tell you a story...(Press Enter to continue!)");

            Console.ReadLine();
            
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            string userColor = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            string userAnimal = Console.ReadLine();

            Console.WriteLine("What is your favorite band?");
            string userBand = Console.ReadLine();

            Console.WriteLine($"{userName} wakes up early one sunny day. They make breakfast," +
                $"and feed their {userAnimal}. They put on their favorite {userColor} shirt and turn on " +
                $"some music. To their surprise, {userBand} comes on the radio! Today is gonna be a good day!");
        }
    }
}

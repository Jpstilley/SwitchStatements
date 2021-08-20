using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What was your favorite subject in school?");
            string userInput = Console.ReadLine();

            FavClass(userInput);  
        }
        public static void FavClass(string userInput)
        {
            switch (userInput)
            {
                case "Math":
                    Console.WriteLine("Nerd!");
                    break;
                case "Science":
                    Console.WriteLine("Dweeb!");
                    break;
                case "English":
                    Console.WriteLine("Bookworm!");
                    break;
                case "History":
                    Console.WriteLine("Loser!");
                    break;
                case "Home Ec":
                    Console.WriteLine("You're kind of dumb huh?!");
                    break;
                default:
                    Console.WriteLine("Cool kid right here. Hates school and is going nowhere!!!");
                    break;
            }
        }


    }
}

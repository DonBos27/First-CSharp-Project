// See https://aka.ms/new-console-template for more information
using System;
using System.Threading.Channels;

namespace FirstProgram
{
    class Question1
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("\n");
            //Console.WriteLine("I love coding");
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine("\n");
            //Console.WriteLine("Let'gooooo !!!");
            //Console.ForegroundColor = ConsoleColor.White;


            bool isCorrectGuess = false;
            Random random = new Random();
            int RandomNumber = random.Next(1, 21);
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("                                           WELCOME TO THE GUESSING NUMBER GAME");
            Console.WriteLine("                                           ===================================");
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("      Rules: You are going to guess a number between 1 and 20 if you got the correct number, you'll win the game. ");
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("            Please Enter Your Surname: ");
            string surName = (Console.ReadLine());
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("                                              Welcome To The Game " + surName);
            Console.WriteLine("                                         ====================================");
            Console.WriteLine("\n");
            while (!isCorrectGuess)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("      Guess a number between 1 and 20: ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                int numberGuessed = Convert.ToInt32(Console.ReadLine());
                if(numberGuessed > 20 || numberGuessed < 1)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("            Your Number is out of range");
                    Console.WriteLine("\n");
                }
                else if (RandomNumber > numberGuessed)
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("            Oups, the number you've guessed is low, Try again");
                    Console.WriteLine("\n");
                }
                else if (RandomNumber < numberGuessed)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("            Oups, the number you've guessed is high, Try again");
                    Console.WriteLine("\n");
                }
                else if (RandomNumber == numberGuessed)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("            Houra!!! You got it :) ");
                    Console.WriteLine("\n");
                    isCorrectGuess = true;
                }

            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                                         Congratulations, " + surName + " you've won the game. ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n");
            Console.WriteLine("      Press twice the 'ENTER' to exit the game. ");
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.White;

            Console.ReadLine();

        }
    }
}


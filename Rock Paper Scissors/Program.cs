//Student Name: Daniel Perusse
//Student ID: 200551990
//Student Email: daniel.perusse@mygeorgian.ca
//Date: November 7, 2023
//Course Code: COMP1030-23F-11351

using System;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using Microsoft.VisualBasic;
namespace Game
{

    class Program
    {
        static bool PlayGame(string value)
        {
            //0 is Rock, 1 is Paper, 2 is Scissors
            string[] moves = { "Rock", "Paper", "Scissors" };
            //Declare random object for CPU and integer for user 
            Random rand = new Random();
            int player = -1;

            if (value == "R")
            {
                player = 0;
            }
            if (value == "P")
            {
                player = 1;
            }
            if (value == "S")
            {
                player = 2;
            }
            //Cpu picks a move
            int cpu = rand.Next(3);
            //Print cpu and user moves
            Console.WriteLine("\nYou chose: " + moves[player]);
            Console.WriteLine("Computer chose: " + moves[cpu]);
            //Game win/loss/tie conditions and display who won
            if (player == 0 && cpu == 1)
            {
                Console.WriteLine("Paper beats Rock! You lost!");
            }
            if (player == 0 && cpu == 2)
            {
                Console.WriteLine("Rock beats Scissors! You won!");
            }

            if (player == 1 && cpu == 2)
            {
                Console.WriteLine("Scissors beats Paper! You lost!");
            }
            if (player == 1 && cpu == 0)
            {
                Console.WriteLine("Paper beats Rock! You won!");
            }

            if (player == 2 && cpu == 0)
            {
                Console.WriteLine("Rock beats Scissors! lost!");
            }
            if (player == 2 && cpu == 1)
            {
                Console.WriteLine("Scissors beats Paper! You won!");
            }

            if (player == cpu)
            {
                Console.WriteLine("Both players picked " + moves[cpu] + ". It's a tie!");
            }

            Console.WriteLine("\nWould you like to play again?");
            Console.Write("Enter \"y\" for yes, anything else for no: ");

            if (Console.ReadLine().ToUpper() == "Y")
            {
                return true;
            }
            else
            {
                Console.WriteLine("Thanks for playing!");
                return false;
            }

        }
        static void Main(string[] args)
        {
            //To store the users choice
            string userInput;
            //used to check user input
            bool valid;
            // if true, will continue the game
            bool playAgain = false;

            //ASCII Art title for fun
            Console.WriteLine(@" _____            _      _____                         _____      _                        ");
            Console.WriteLine(@"|  __ \          | |    |  __ \                       / ____|    (_)                       ");
            Console.WriteLine(@"| |__) |___   ___| | __ | |__) |_ _ _ __   ___ _ __  | (___   ___ _ ___ ___  ___  _ __ ___ ");
            Console.WriteLine(@"|  _  // _ \ / __| |/ / |  ___/ _` | '_ \ / _ \ '__|  \___ \ / __| / __/ __|/ _ \| '__/ __|");
            Console.WriteLine(@"| | \ \ (_) | (__|   <  | |  | (_| | |_) |  __/ |     ____) | (__| \__ \__ \ (_) | |  \__ \");
            Console.WriteLine(@"|_|  \_\___/ \___|_|\_\ |_|   \__,_| .__/ \___|_|    |_____/ \___|_|___/___/\___/|_|  |___/");
            Console.WriteLine(@"                                   | |                                                     ");
            Console.WriteLine(@"                                   |_|                                                     ");
            Console.WriteLine("A simple console game written in C#\nby Daniel Perusse"); //That's me!

            do
            {
                //reset flag on replay
                valid = false;

                //Ask for the user's move
                Console.WriteLine("\nType \"R\" for Rock, \"P\" for Paper or \"S\" for Scissors.\n");
                Console.Write("Pick your move: ");
                //Read input from console then set to uppercase for ease of checking
                userInput = Console.ReadLine();
                userInput = userInput.ToUpper();
                //Check for valid input
                if (userInput == "R" || userInput == "P" || userInput == "S")
                {   //set flag to true and call PlayGame method.
                    valid = true;
                    playAgain = PlayGame(userInput);
                }

                else
                {   //Error message
                    Console.WriteLine("Invalid Input! Try again.");
                }
                //Will loop when input is incorrect or if user wishes to play again
            } while (valid == false || playAgain == true);
        }
    }


}
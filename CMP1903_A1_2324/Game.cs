﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Game_OOP_Assessment
{
    /// <summary>
    /// Represents main game logic and UI.
    /// </summary>
    internal class Game
    {
        /// <summary>
        /// Method that displays User-Interface and Takes User Input to Navigate Menus. 
        /// </summary>
        private Dice roll1;
        private Dice roll2;
        private Dice roll3;
        static void UI() 
        {
            string gameChoice; 
            Console.WriteLine("--------------------------------"); 
            Console.WriteLine("Welcome To the Dice Rolling Game");
            Console.WriteLine("Press 1 to Start the Game");
            Console.WriteLine("Enter 2 to Enter testing mode");
            Console.WriteLine("Press 3 to Exit");
            Console.WriteLine("--------------------------------");
            gameChoice = Console.ReadLine();
            switch (gameChoice) 
            {
                case "1":
                    GameStart();
                    break;
                case "2":
                    DebugMode();
                    break;

                case "3":
                    CloseGame();
                    break;
                default:
                    Console.WriteLine("\"Invalid input, returning to start screen.\"");
                    break;
                    
            
            }
            
        }

        /// <summary>
        /// Starts game by instantiating three dice objects, calling their method.Roll and displaying the results, sum and Game Total.
        /// </summary>
        static void GameStart()
        {
            Game game = new Game();
            (game.roll1, game.roll2, game.roll3) = CreateObjects();
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"The First dice rolled a: {game.roll1.Roll}");
            Console.WriteLine($"The Second dice rolled a: {game.roll2.Roll}");
            Console.WriteLine($"The Third dice rolled a: {game.roll3.Roll}");
            Console.WriteLine($"The sum of the rolls is: {game.roll1.Roll + game.roll2.Roll + game.roll3.Roll}");
            Console.WriteLine($"Game Total: {game.roll1.RoundTotal}");
            Console.WriteLine("--------------------------------");
            RestartGame();

        }

        /// <summary>
        /// Class that creates three new Dice Objects.
        /// </summary>
        /// <returns>Tuple of three dice Objects</returns>
        public static (Dice, Dice, Dice) CreateObjects() 
        {
            Dice roll1 = new Dice();
            Dice roll2 = new Dice();
            Dice roll3 = new Dice();

            return (roll1, roll2, roll3);
        
        }

        /// <summary>
        /// Displays options for restarting game, returning to Main Menu or closing game.
        /// </summary>
        static void RestartGame()
        {
            string restartChoice;
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Enter 1 to Play Again");
            Console.WriteLine("Enter 2 to Return to Main Menu");
            Console.WriteLine("Enter 3 to Exit Game");
            Console.WriteLine("--------------------------------");
            restartChoice = Console.ReadLine();
            switch (restartChoice) 
            {
                case "1":
                    GameStart();
                    break;
                case "2":
                    UI();
                    break;
                case "3":
                    CloseGame();
                    break;
                default:
                    Console.WriteLine("Invalid input, try again.");
                    RestartGame();
                    break;

            
            }
        
        }

        /// <summary>
        ///Displays Goodbye Message. Delays for 2 seconds. Uses Environment.Exit(0) to close Program.
        /// </summary>
        static void CloseGame()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Thank you For playing.\nSee you again soon!\nGoodbye!");
            Console.WriteLine("--------------------------------");
            System.Threading.Thread.Sleep(2000);
            Environment.Exit(0);
        }

        /// <summary>
        /// //Opens Debug Mode Method. Instantiates New Debug Object. Calls method from within the Class.
        /// </summary>
        static void DebugMode() 
        {
            Testing testing = new Testing();
            testing.TestResult(); 
        
        }
        
        /// <summary>
        /// Main entry point of program. Continously displays the UI.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            while (true) 
            {
                UI();
            }
        }
    }
}

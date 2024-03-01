using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Game_OOP_Assessment
{
    internal class Game
    {
        //Method that displays User-Interface and navigate menus 
        static void UI() 
        {
            string gameChoice; //string variable to store user choice 
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
                    UI(); // recursive 
                    break;
                    
            
            }
            
        }
        static void GameStart()
        {
            //creates instance of Dice classes assigned to roll1, roll2 and roll 3
            Dice roll1 = new Dice(); 
            Dice roll2 = new Dice();
            Dice roll3 = new Dice();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("The First dice rolled a: {0}", roll1.Roll);
            Console.WriteLine("The Second dice rolled a: {0}", roll2.Roll);
            Console.WriteLine("The Third dice rolled a: {0}", roll3.Roll);
            Console.WriteLine("The sum of the rolls is: {0}", (roll1.Roll + roll2.Roll + roll3.Roll));
            Console.WriteLine("Round Total: {0}", roll3.RoundTotal);
            Console.WriteLine("--------------------------------");
            RestartGame();//calls restart game method

        }
        //Method to restart the Game
        static void RestartGame() 
        {
            string restartChoice;
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Enter 1 to play again");
            Console.WriteLine("Enter 2 to Return to Main Menu");
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
                default:
                    Console.WriteLine("Invalid input, try again.");
                    RestartGame();
                    break;

            
            }
        
        }
        static void CloseGame() 
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Thank you For playing.\nSee you again soon!\nGoodbye!");
            Console.WriteLine("--------------------------------");
            System.Threading.Thread.Sleep(2000);
            Environment.Exit(0);
        }

        static void DebugMode() 
        {
            Testing testing = new Testing();
            testing.TestResult(); //Call Test Result Method from within the Testing Class
        
        }
        static void Main(string[] args)
        {
            while (true) 
            {
                UI();
            }
        }
    }
}

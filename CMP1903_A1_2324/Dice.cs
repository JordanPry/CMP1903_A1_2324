using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;


namespace Dice_Game_OOP_Assessment
{
    /// <summary>
    /// Class That represents a six sided dice used within the game.
    /// </summary>
    internal class Dice
    {
        private static Random _random = new Random(); //instantiate private static value for Random So same seed generation cannot occour.
        private int _roll; //Private Variable to store the DiceRoll
        private static int _roundTotal; //Private static variable shared between all objects.
       
        /// <summary>
        /// Constructor for the Dice class.
        /// Initializes a new instance of the Dice class with a random roll (1-6).
        /// Updates the sum of total rolls across all Objects.
        /// </summary>
        public Dice()
        {
            _roll = DiceRoller(); 
            _roundTotal += _roll; 
        }

        /// <summary>
        /// Gets the Value of the dice roll. Data is Read Only.
        /// </summary>
        public int Roll
        {
            get { return _roll; } 
        }

        /// <summary>
        /// gets the total value of dice rolls within the game. Data is Read Only.
        /// </summary>
        public int RoundTotal
        {
            get { return _roundTotal; } 

        }

        /// <summary>
        /// Generates a random integer between 1-6 using Random.
        /// </summary>
        /// <returns>A random integer between 1-6</returns>
        private int DiceRoller()
        {
            return _random.Next(1, 7); 
        }
    }
}

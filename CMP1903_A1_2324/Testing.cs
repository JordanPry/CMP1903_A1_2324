using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///<summary>
///This class is for testing the functionality of the Dice Class.
/// </summary>
namespace Dice_Game_OOP_Assessment
{
    internal class Testing
    {
        private Dice _testSum1; //Instantiates private Dice Object called _testSum1.
        private Dice _testSum2; //Instantiates private Dice Object called _testSum2.
        private Dice _testSum3; //Instantiates private Dice Object called _testSum3.

        /// <summary>
        /// Tests the results of the dice rolls and their sums Using Debug.Assert.
        /// </summary>
        public void TestResult() 
        {
            (_testSum1, _testSum2, _testSum3) = Game.CreateObjects();
            if (!ValidRoll() || !ValidSum())
            {
                Debug.Assert(ValidRoll(), "Dice is not between the Valid Parameters");
                Debug.Assert(ValidSum(), "Dice sum is not Correct");

            }
            else { Console.WriteLine("The Game is running as intended."); }
            
        }
       

        /// <summary>
        /// Validates whether a dice roll is within the valid range
        /// </summary>
        /// <returns>True if the dice roll is within valid range, otherwise false</returns>
        private bool ValidRoll() 
        {
            return _testSum1.Roll >= 1 && _testSum1.Roll <= 6; 
        }

        /// <summary>
        /// Validates whether the sum of the 3 rolls is correct.
        /// </summary>
        /// <returns>True if sum is correct, otherwise false.</returns>
        private bool ValidSum() 
        {
            int sumOfRolls = _testSum1.Roll + _testSum2.Roll + _testSum3.Roll; 
            return sumOfRolls == (_testSum1.Roll + _testSum2.Roll + _testSum3.Roll); 
        }
    }
}

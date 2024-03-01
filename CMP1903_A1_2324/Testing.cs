using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Game_OOP_Assessment
{
    internal class Testing
    {
        private Dice _testRoll = new Dice();   
        private Dice _testSum1 = new Dice();
        private Dice _testSum2 = new Dice();
        private Dice _testSum3 = new Dice();

        public void TestResult() 
        {
            Debug.Assert(ValidRoll(), "Dice is not between the Valid Parameters" );
            Debug.Assert(ValidSum(), "Dice sum is not Correct");
        }
        private bool ValidRoll() 
        {
            return _testRoll.Roll >= 1 && _testRoll.Roll <= 6; 
        }
        private bool ValidSum() 
        {
            int sumOfRolls = _testSum1.Roll + _testSum2.Roll + _testSum3.Roll;
            return sumOfRolls == (_testSum1.Roll + _testSum2.Roll + _testSum3.Roll);
        }
    }
}

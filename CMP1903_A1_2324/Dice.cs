using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dice_Game_OOP_Assessment
{
    internal class Dice
    {
        private static Random random = new Random(); 
        private int _roll;
        private static int _roundTotal;

        public Dice()
        {
            
            _roll = DiceRoller(); // 
            _roundTotal += UpdateTotal();
        }

        public int Roll
        {
            get { return _roll; }
        }
        public int RoundTotal
        {
            get { return _roundTotal; }

        }


        private int DiceRoller()
        {
            return random.Next(1, 7);
        }
        private int UpdateTotal() 
        {
            return Roll;
        
        }
        



    }
}

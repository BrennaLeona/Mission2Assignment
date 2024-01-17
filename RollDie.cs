using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2Assignment
{
    internal class RollDie
    {
        public int[] RollDice(int numrolls)
        {
            int[] results = new int[13];

            int nRolls = numrolls;

            int die1 = 0;
            int die2 = 0;
            int diecombo = 0;

            Random random = new Random();

            for (int count = 0; count < nRolls; count++)
            {
                die1 = random.Next(1, 7);
                die2 = random.Next(1, 7);

                diecombo = die1 + die2;

                results[diecombo]++;
            }

            return results;

        }
    }
}

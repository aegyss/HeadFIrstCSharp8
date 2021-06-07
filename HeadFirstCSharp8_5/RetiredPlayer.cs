using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstCSharp8_5
{
    class RetiredPlayer
    {
        public string Name { get; private set; }
        public int YearRetired { get; private set; }

        public RetiredPlayer(string player, int yearRetired)
        {
            Name = player;
            YearRetired = yearRetired;
        }
    }
}

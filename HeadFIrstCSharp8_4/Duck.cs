using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstCSharp8_4
{
    class Duck : Bird, IComparable<Duck>
    {
        public int Size { get; set; }
        public KindOfDuck Kind { get; set; }

        public override string ToString()
        {
            return $"A {Size} inch {Kind}";
        }

        public int CompareTo(Duck duckToCompare)
        {
            if (this.Size > duckToCompare.Size)
                return 1;
            else if (this.Size < duckToCompare.Size)
                return -1;
            else
                return 0;
        }
    }

    enum KindOfDuck
    {
        Mallard,
        Muscovy,
        Loon,
    }
}

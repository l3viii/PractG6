using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_6G
{
    class Pair
    {
        public int First { get; private set; }
        public int Second { get; private set; }

        public Pair(int first, int second)
        {
            First = first;
            Second = second;
        }
        public Pair Multiply(Pair multiplication)
        {
            return new Pair(First * multiplication.First, Second * multiplication.Second);
        }

        public static Pair operator ++(Pair pair)
        {
           return new Pair(pair.First * 2, pair.Second * 2);
        }
    }
}

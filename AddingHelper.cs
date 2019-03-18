using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphismExample
{
    class AddingHelper
    {
        public AddingHelper() { }

        public int Add(int x, int y)
        {
            return (x + y);
        }

        public int Add(int x, int y, int z)
        {
            return (x + y + z);
        }

        public int Add(int[] numbers)
        {
            int total = 0;
            foreach (int x in numbers)
            {
                total += x;
            }
            return total;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test01
{
    class TestObject
    {

        internal List<int> Reduce(List<int> input)
        {
            List<int> outCome = new List<int>();

            input.Sort();
            outCome = input.Where(x => x >= 4)
                .Where(x => x < 10)
                .GroupBy(x => x).Select(y => y.First())
                .Take(5).ToList();

            return outCome;
        }
        }
    }


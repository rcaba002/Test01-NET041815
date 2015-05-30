using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Test01
{
    class TestObject
    {
        internal List<int> Reduce(List<int> input)
        {
            List<int> results = input.Where(x => x >= 4 && x < 10).Distinct().Take(5).ToList();

            return results;
        }
    }
}

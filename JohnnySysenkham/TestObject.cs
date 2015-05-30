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
            return input.Where(x => x >= 4 && x < 10).Distinct().Take(5).ToList();
        }

        internal List<int> ReduceLessThanFour(List<int> input)
        {
            return input.Where(x => x >= 4).Select(x => x).ToList();
        }

        internal List<int> RemovesElementsMoreThanTen(List<int> input)
        {
            return input.Where(x => x < 10).Select(x => x).ToList();
        }

        internal List<int> RemovesDuplicateElements(List<int> input)
        {
            return input.GroupBy(x => x).Select(x => x.Key).ToList();
        }

        internal List<int> ReturnsFirstFiveItems(List<int> input)
        {
            return input.GetRange(0, 5).ToList();
        }
    }
}

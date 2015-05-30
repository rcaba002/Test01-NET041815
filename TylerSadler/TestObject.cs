using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test01
{
    class TestObject
    {
        internal List<int> LessThanFour(List<int> input)
        {
            List<int>temp = input.Where(x => x >= 4).ToList();
            return temp;
        }
        internal List<int> MoreThanTen(List<int> input)
        {
            List<int>temp = input.Where(x => x < 10).ToList();
            return temp;
        }
        internal List<int> Duplicates(List<int> input)
        {
            List<int> temp = input.GroupBy(x => x).Select(y => y.First()).ToList();
            return temp;
        }
        internal List<int> ReturnFirsFive(List<int> input)
        {
            List<int> temp = input.Take(5).ToList();
            return temp;
        }
        
    }
}

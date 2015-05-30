using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test01
{
    class TestObject
    {
        //removes elements less than four
        //removes elements more than ten
        //removes duplicates
        //returns first five items

        internal List<int> Reduce(List<int> input)
        {
            List<int> resultsOne = new List<int>();

            input.Sort();

            resultsOne = input.Where(x => x >= 4).Where(x => x < 10)
                .GroupBy(x => x).Select(y => y.First()).Take(5).ToList();

            return resultsOne;
        }
    }
}

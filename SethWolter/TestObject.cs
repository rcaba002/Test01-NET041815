using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace Test01
{
    class TestObject
    {
        internal List<int> Reduce(List<int> input)
        {
            //int[] array = {1, 3, 4, 5, 11, 10, 12, 1, 9, 12, 20, 21};
            var results = input.where( x => x > 10 ).where(y => y < 4).Distinct().
            Take(5);      
            //Reduce_RemovesElementsLessThanFour();
            //Reduce_RemovesElementsMoreThanTen();
            //Reduce_RemovesDuplicateElements();
            //Reduce_ReturnsFirstFiveItems();

            return results;
        }

        //private static void Reduce_ReturnsFirstFiveItems()
        //{
        //    Console.WriteLine();
        //}

        //private static void Reduce_RemovesDuplicateElements()
        //{
        //    throw new NotImplementedException();
        //}

        //private static void Reduce_RemovesElementsMoreThanTen()
        //{
        //    throw new NotImplementedException();
        //}

        //private static void Reduce_RemovesElementsLessThanFour()
        //{
        //    throw new NotImplementedException();
        //}
    }
}

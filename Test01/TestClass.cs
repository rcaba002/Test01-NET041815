using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Test01
{
    public class TestClass
    {
        [Fact]
        public void Reduce_RemovesElementsLessThanThree()
        {
            TestObject testObject = new TestObject();
            List<int> input = new List<int> { 1, 2, 3, 4, 5 };
            List<int> result = testObject.Reduce(input);
            Assert.Collection(result, x => Assert.Equal(4, x), x => Assert.Equal(5, x));
        }

        [Fact]
        public void Reduce_RemovesElementsMoreThanTen()
        {
            TestObject testObject = new TestObject();
            List<int> input = new List<int> { 8, 9, 10, 11, 12 };
            List<int> result = testObject.Reduce(input);
            Assert.Collection(result, x => Assert.Equal(8, x), x => Assert.Equal(9, x));
        }
    }
}

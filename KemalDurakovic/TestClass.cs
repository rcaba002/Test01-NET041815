using System;
using System.Collections.Generic;

using Xunit;


namespace Test01
{
    public class TestClass
    {
        [Fact]
        public void Reduce_RemovesElementsLessThanFour()
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

        [Fact]
        public void Reduce_RemovesDuplicateElements()
        {
            TestObject testObject = new TestObject();
            List<int> input = new List<int> { 4, 6, 4 };
            List<int> result = testObject.Reduce(input);
            Assert.Collection(result, x => Assert.Equal(4, x), x => Assert.Equal(6, x));
        }

        [Fact]
        public void Reduce_ReturnsFirstFiveItems()
        {
            TestObject testObject = new TestObject();
            List<int> input = new List<int> { 4, 5, 6, 7, 8, 9 };
            List<int> result = testObject.Reduce(input);
            Assert.Collection(result,
                x => Assert.Equal(4, x),
                x => Assert.Equal(5, x),
                x => Assert.Equal(6, x),
                x => Assert.Equal(7, x),
                x => Assert.Equal(8, x));
        }
    }
}

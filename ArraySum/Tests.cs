using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace ArraySum
{
    [TestFixture]
    public class Tests
    {
        [TestCase(new int[] { 2, 3, 5, 9, 1 }, 2)]
        [TestCase(new int[] { 1, 2, 3, 5, 9, -8 }, 2)]
        [TestCase(new int[] { 0, 5, 5}, 1)]
        [TestCase(new int[] { 2, -3, -5, 9, 3 }, 3)]
        [TestCase(new int[] { 2, 0, 2 }, 1)]
        public void GetIndex(int[] array, int expectedIndex)
        {
            //int[] array = { 2, 3, 5, 9, 1 };
            ArraySum arraySum = new ArraySum();
            int index = arraySum.GetIndexFromArray(array);
            Assert.AreEqual(expectedIndex, index);
        }
    }
}

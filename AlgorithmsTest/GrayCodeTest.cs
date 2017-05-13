using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class GrayCodeTest
    {
        
        [Theory]
        [InlineData(2, new[]{0,1,3,2})]
        public void TestMethod(int n, IList<int> output)
        {
            Assert.Equal(output, Solution089.GrayCode(n));
        }
    }
}


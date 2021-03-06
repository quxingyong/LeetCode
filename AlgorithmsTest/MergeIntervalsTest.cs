using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class MergeIntervalsTest
    {
        [Theory]
        [MemberData(nameof(InlineData))]
        public void TestMethod(IList<Interval> intervals, IList<Interval> output)
        {
            Assert.Equal(output, Solution056.Merge2(intervals));
        }
        public static IEnumerable<object[]> InlineData
        {
            get
            {
                var driverData = new List<object[]>();
                IList<Interval> intervals = new List<Interval>() {
                    new Interval(1,4),
                    new Interval(0,4)
                };
                IList<Interval> output = new List<Interval>() {
                    new Interval(0,4)
                };
                driverData.Add(new object[] { intervals, output });
                intervals = new List<Interval>() {
                    new Interval(8,10),
                    new Interval(1,3),
                    new Interval(2,6),
                    new Interval(15,18),
                };
                output = new List<Interval>() {
                    new Interval(1,6),
                    new Interval(8,10),
                    new Interval(15,18),
                };
                driverData.Add(new object[] { intervals, output });
                
                return driverData;
            }
        } 
    }
}


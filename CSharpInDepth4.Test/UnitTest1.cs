using CSharpInDepth4.Chapter2;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xunit;

namespace CSharpInDepth4.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            List<int> list = new List<int>();
            list.Add(5);
            list.Add(10);
            list.Add(20);

            GenericSample genericSample = new GenericSample();
            var result = genericSample.CopyAtMost(list, 2);
            Debug.WriteLine(result.Count);
        }
    }
}

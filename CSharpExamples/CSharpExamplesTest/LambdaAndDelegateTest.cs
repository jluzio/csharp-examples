using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CSharpExamplesTest
{
    [TestClass]
    public class LambdaAndDelegateTest
    {
        delegate void log(Object obj);
        delegate String asString<T>(IEnumerable<T> values);

        [TestMethod]
        public void Test()
        {
            log debug = (obj) => System.Diagnostics.Debug.WriteLine(obj);
            asString<int> valuesAsString = values => String.Join(",", values);

            var source = new List<int> { 1, 2, 3 };
            var target = new List<int>();
            source.ForEach(e => target.Add(e));

            Action<int> toString = e => e.ToString();
            Func<int, String> toStringFc = e => e.ToString();

            source.Select(e => e.ToString()).ToList();

            debug(valuesAsString(source));
            debug(valuesAsString(target));
        }
    }
}

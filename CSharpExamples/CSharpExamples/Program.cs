using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamples
{
    class Program
    {
        delegate String toStringFc(object e);

        static void Main(string[] args)
        {
            Console.WriteLine("Test");

            var source = new List<int>{ 1, 2, 3 };
            var target = new List<int>();
            source.ForEach( e => target.Add(e) );

            //del myDelegate = x => x * x;

            Console.WriteLine(source);
            Console.WriteLine(target);

            Console.ReadLine();
        }
    }
}

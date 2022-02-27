using System;

namespace LearnAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //var example = new Array_01();
            //Console.WriteLine(example.DichotomousMethod1(example.arrays, 4));
            //var example = new Array_02();
            //Console.WriteLine(example.RemoveElement(example.arrays, 2));
            // var example = new Array_03();
            // Console.WriteLine(example.SortedSquares(example.arrays));
            
            var example = new Array04();
            Console.WriteLine(example.MinSubArrayLen(7,example.arrays));
        }
    }
}
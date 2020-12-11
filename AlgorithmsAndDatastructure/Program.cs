using AlgorithmsAndDatastructure.SearchingAlgorithms.CodingProblems;
using AlgorithmsAndDatastructure.SearchingAlgorithms.Implimantation;
using System;

namespace AlgorithmsAndDatastructure
{
    class Program
    {
        static void Main(string[] args)
        {
            // Binary Search Recursive
            //var result = BinarySearch.Search(new int[] { 1, 2, 3, 4, 5, 6 }, 2, 0, 5);
            //Console.WriteLine(result);

            // Find missing Number
            Console.WriteLine(FindTheMissingNumber.MissinNumberSecondWay(new int[] { 1,2,3,5}));
        }
    }
}

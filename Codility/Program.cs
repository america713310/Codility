using Codility.Lesson1_Iterations;
using Codility.Lesson10_PrimeAndCompositeNumbers;
using Codility.Lesson11_SieveOfEratosthenes;
using Codility.Lesson12_EuclideanAlgorithm;
using Codility.Lesson2_Arrays;
using Codility.Lesson3_TimeComplexity;
using Codility.Lesson4_CountingElements;
using Codility.Lesson5_PrefixSums;
using Codility.Lesson6_Sorting;
using Codility.Lesson7_StacksAndQueues;
using Codility.Lesson8_Leader;
using Codility.Lesson9_MaximumSliceProblem;
using System;

namespace Codility
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(BinaryGap.Solution(529));
            foreach (var item in CyclicRotation.Solution(new int[] { 3, 8, 9, 7, 6 }, 3))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine(OddOccurrencesInArray.Solution(new int[] { 4, 5, 6, 4, 5, 6, 7 }));
            Console.WriteLine(PermMissingElem.Solution(new int[] { 2, 3, 1, 5 }));
            Console.WriteLine(FrogJmp.Solution(10, 100, 30));
            Console.WriteLine(TapeEquilibrium.Solution(new int[] { 3, 1, 2, 4, 3 }));
            Console.WriteLine(PermCheck.Solution(new int[] { 2, 3, 1, 4, 6 }));
            Console.WriteLine(FrogRiverOne.Solution(5, new int[] { 1, 3, 1, 4, 2, 3, 5, 4 }));
            Console.WriteLine(MissingInteger.Solution(new int[] { 1, 3, 6, 4, 1, 2 }));
            foreach (var item in GenomicRangeQuery.Solution("CAGCCTA", new int[] { 2, 5, 0 }, new int[] { 4, 5, 6 }))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine(MaxProductOfThree.Solution(new int[] { 1, 1, 1, -2, -2 }));
            Console.WriteLine(Distinct.Solution(new int[] { 2, 1, 7, 2, 2, 1 }));
            Console.WriteLine(StoneWall.Solution(new int[] { 8, 8, 5, 7, 9, 8, 7, 4, 8 }));
            Console.WriteLine(Dominator.Solution(new int[] { 3, 4, 3, 2, 3, -1, 3, 3 }));
            Console.WriteLine(EquiLeader.Solution(new int[] { 4, 3, 4, 4, 4, 2 }));
            Console.WriteLine(MaxProfit.Solution(new int[] { 23171, 21011, 21123, 21366, 21013, 21367 }));
            Console.WriteLine(MaxSliceSum.Solution(new int[] { 3, 2, -6, 4, 0 }));
            Console.WriteLine(MaxDoubleSliceSum.Solution(new int[] { 3, 2, 6, -1, 4, 5, -1, 2 }));
            Console.WriteLine(Flags.Solution(new int[] { 1, 5, 3, 4, 3, 4, 1, 2, 3, 4, 6, 2 }));
            Console.WriteLine(ChocolatesByNumbers.Solution(10, 4));
        }
    }
}

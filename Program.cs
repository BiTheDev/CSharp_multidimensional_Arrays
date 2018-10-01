﻿using System;

namespace multidimensional_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Multidimensional array declaration
            // This example contains 3 arrays -- each of these is length 2 -- all initialized to zeroes.
            int[,] array2D = new int[3, 2];
            // This is equivalent to:
            //  int [,] array2D = new int[3,2]  {  { 0,0 }, { 0,0 }, { 0,0 } }; 
            // This example has 2 large rows that each contain 3 arrays -- and each of those arrays is length 4.
            int[,,] array3D = new int[2,3,4]
            {
                { {45,1,16,17}, {4,47,21,68}, {21,28,32,76} },
                { {11,0,85,42}, {9,10,14,96}, {66,99,33,12} }

            };
            // Directly accessing a multidimensional array
            System.Console.WriteLine(array2D[0,1]);
            System.Console.WriteLine(array3D[1,0,3]);


            // Jagged array declaration
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[4];
            jaggedArray[2] = new int[2];
            int [][] jaggedArray2 = new int[][] {
                new int[] {1,3,5,7,9},
                new int[] {0,2},
                new int[] {11,22,33,44}
            };

            //Short-hand form
            int[][] jaggedArray3 = {
                new int[] {1,3,5,7,9},
                new int[] {0,2},
                new int[] {11,22,33,44}
            };

            //mixing jagged and muti-dimensional arrays
            int[][,] jaggedArray4 = new int[3][,]
            {
                new int[,] {{1,3}, {5,7}},
                new int[,] {{0,2}, {4,6}, {8,10}},
                new int[,] {{11,22}, {99,88}, {0,9}}
            };

            //working through each array in a jagged array
            foreach (int[] innerArr in jaggedArray)
            {
                System.Console.WriteLine("Inner array length is {0}", innerArr.Length);
            }

            System.Console.WriteLine(jaggedArray2[0][1]);
            System.Console.WriteLine(jaggedArray3[2][3]);

        }
    }
}



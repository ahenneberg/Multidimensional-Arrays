/* Disclaimer: The examples and comments from this program are from
   C#7 in a Nutshell and are written for learning purposes only. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multidimensional_Arrays
{
    class Program
    {
        static void Main()
        {
            // Multidimensional arrays come in two varieties: rectangular and jagged.
            // Rectangular arrays represent an n-dimensional block of memory
            // Rectangular arrays are declared using commas to separate each dimension.
            int[,] matrix = new int[3, 3];
            // The GetLength method on an array returns the length for a given dimension (starting at 0)
            for (int i = 0; i < matrix.GetLength(0); i++)       // The 1st dimension of the array
                for (int j = 0; j < matrix.GetLength(1); j++)   // The 2nd dimension of the array.
                {
                    matrix[i, j] = i * 3 + j;
                    Console.WriteLine(matrix[i, j]);            // 0 1 2 3 4 5 6 7 8
                }
            // An array can also be initialized like this:
            int[,] matrix2 = new int[,]
            {
                {0, 1, 2},
                {3, 4, 5},
                {6, 7, 8}
            };
            // Jagged arrays are arrays of arrays.
            // Jagged arrays are declared using successive square brackets to represent each dimension. 
            int[][] matrix3 = new int[3][];
            // The inner dimensions aren’t specified in the declaration because,
            // unlike a rectangular array, each inner array can be an arbitrary length. 
            // Each inner array is implicitly initialized to null rather than an empty array.
            // Each inner array must be created manually:
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix3[i] = new int[3];    // Create inner array
                for (int j = 0; j < matrix3[i].Length; j++)
                    matrix3[i][j] = i * 3 + j;
            }
        }
    }
}

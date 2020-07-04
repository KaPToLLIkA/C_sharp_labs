using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LAB8_COM_OBJECT
{
    [Guid("349988BC-2594-46cf-BE83-1F09C25617F3"),
     ClassInterface(ClassInterfaceType.None),
    ComSourceInterfaces(typeof(IEvents)),
        ComVisible(true)]

    public class Math : IMath
    {
        public int findMaxNegativeInIntMatrix(int[,] matrix)
        {
            int max = int.MinValue;
            for (int r = 0; r < matrix.GetLength(0); ++r)
            {
                for (int c = 0; c < matrix.GetLength(1); ++c)
                {
                    if (matrix[r, c] < 0 && matrix[r, c] > max)
                    {
                        max = matrix[r, c];
                    }
                }
            }
            return max;
        }

        public double findMiddleOfPositiveValsInIntMatrix(int[,] matrix)
        {
            double middle = 0;
            int count = 0;

            for (int r = 0; r < matrix.GetLength(0); ++r)
            {

                for (int c = 0; c < matrix.GetLength(1); ++c)
                {
                    if (matrix[r,c] > 0)
                    {
                        middle += matrix[r, c];
                        ++count;
                    }
                }
            }

            if (count == 0) return 0;
            else return middle / count;
        }

        public int findMinPositiveInIntMatrix(int[,] matrix)
        {
            int min = int.MaxValue;
            for (int r = 0; r < matrix.GetLength(0); ++r)
            {
                for (int c = 0; c < matrix.GetLength(1); ++c)
                {
                    if (matrix[r, c] > 0 && matrix[r, c] < min)
                    {
                        min = matrix[r, c];
                    }
                }
            }
            return min;
        }
    }
}

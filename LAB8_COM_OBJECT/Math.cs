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
        public double findMiddleOfNonPositiveValsInIntMatrix(int[,] matrix)
        {
            double middle = 0;
            int count = 0;

            for (int r = 0; r < matrix.GetLength(0); ++r)
            {

                for (int c = 0; c < matrix.GetLength(1); ++c)
                {
                    if (matrix[r,c] < 0)
                    {
                        middle += matrix[r, c];
                        ++count;
                    }
                }
            }

            if (count == 0) return 0;
            else return middle / count;
        }

        public double findMinMiddleOfColumnsInIntMatrix(int[,] matrix)
        {
            double minMiddle = double.MaxValue;

            for (int c = 0; c < matrix.GetLength(1); ++c)
            {
                int cSum = 0;
                for (int r = 0; r < matrix.GetLength(0); ++r)
                {
                    cSum += matrix[r, c];
                }
                double newMin = Convert.ToDouble(cSum) / matrix.GetLength(1);

                if (newMin < minMiddle)
                {
                    minMiddle = newMin;
                }
            }

            return minMiddle;
        }

        public double findMaxMiddleOfRowsInIntMatrix(int[,] matrix)
        {
            double maxMiddle = double.MinValue;

            for (int r = 0; r < matrix.GetLength(0); ++r)
            {
                int rSum = 0;
                for (int c = 0; c < matrix.GetLength(1); ++c)
                {
                    rSum += matrix[r, c];
                }

                double newMax = Convert.ToDouble(rSum) / matrix.GetLength(0);

                if (newMax > maxMiddle)
                {
                    maxMiddle = newMax;
                }
            }

            return maxMiddle;
        }
    }
}

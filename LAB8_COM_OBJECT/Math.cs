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
        public double findArithmeticMeanInIntVector(int[] vector)
        {
            return Convert.ToDouble(vector.Sum())/Convert.ToDouble(vector.Length);
        }

        public double findGeometricMeanInIntVector(int[] vector)
        {
            int ans = 1;

            foreach(int item in vector)
            {
                ans *= item;
            }
            return System.Math.Pow(ans, Convert.ToDouble(1) / Convert.ToDouble(vector.Length));
        }

        public int findSummOfPositiveValsInIntVector(int[] vector)
        {
            return vector.Sum(e => (e > 0 ? e : 0));
        }
    }
}

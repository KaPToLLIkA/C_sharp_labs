using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LAB8_COM_OBJECT
{
    [Guid("01D10028-A89D-47ee-8048-C27B6DD4BE63")]
   // [ComVisible(true)]
    public interface IMath
    {
        [DispId(1)]
        double findArithmeticMeanInIntVector(int[] vector);
        [DispId(2)]
        double findGeometricMeanInIntVector(int[] vector);
        [DispId(3)]
        int findSummOfPositiveValsInIntVector(int[] vector);
    }
}

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
        double findMinMiddleOfColumnsInIntMatrix(int[,] matrix);
        [DispId(2)]
        double findMaxMiddleOfRowsInIntMatrix(int[,] matrix);
        [DispId(3)]
        double findMiddleOfNonPositiveValsInIntMatrix(int[,] matrix);
    }
}

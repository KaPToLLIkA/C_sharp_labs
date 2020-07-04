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

    public class StrUtil : IStrUtil
    {
        public string toLowerCase(string str)
        {
            return str.ToLower();
        }

        public string toUpperCase(string str)
        {
            return str.ToUpper();
        }

        public string toUpperCaseFirstLetterInWords(string str)
        {
            return String.Join(" ", str
                .ToLower()
                .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(e => (e.Length > 1 ? e.Substring(0,1).ToUpper() + e.Substring(1) : e.ToUpper())));
        }
    }
}

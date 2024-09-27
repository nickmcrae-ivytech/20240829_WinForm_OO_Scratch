using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal static class ExtMethod
    {
        
        public static bool IsNotNil(this string value)
        {
            if (value == null)
                return false;

            if (string.IsNullOrEmpty(value)) return false;

            return true;
        }
        

    }
}

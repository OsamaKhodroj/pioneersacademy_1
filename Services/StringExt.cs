using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Services
{
    public static class StringExt
    {
        public static string GetStringCount(this string data)
        {
            return $"The string count is {data.Length}.";
        }
    }
}

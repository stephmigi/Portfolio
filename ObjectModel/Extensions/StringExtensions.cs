using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectModel
{
    public static class StringExtensions
    {
        public static string EllipseString(this string text, int length)
        {
            if (text == null) return string.Empty;
            if (text.Length > length && length > 0)
            {
                return text.Substring(0, (length - 3)) + "...";
            }
            else
                return text;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectModel.Extensions
{
    /// <summary>
    /// This class provides extensions for string class
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Cuts the text at desired length and adds "..." at the end.
        /// Useful for "summaries" of long texts.
        /// </summary>
        /// <param name="text">The text</param>
        /// <param name="length">The desired length</param>
        /// <returns>The formatted text.</returns>
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
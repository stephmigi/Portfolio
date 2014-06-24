using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ObjectModel
{
    public static class EnumHelpers
    {
        /// <summary>
        /// Gt all the values of an anum
        /// </summary>
        /// <typeparam name="T">Type of enum</typeparam>
        /// <returns>All values</returns>
        public static IEnumerable<T> GetValues<T>()
        {
            return Enum.GetValues(typeof(T)).Cast<T>();
        }

        /// <summary>
        /// Returns all elements of an enum with its ressourcized text.
        /// </summary>
        /// <typeparam name="T">Type of enum</typeparam>
        /// <returns>Dictionary of enum values and ressourcized texts.</returns>
        public static Dictionary<T, string> GetAllElementsWithResourceKey<T>()
        {
            var dic = new Dictionary<T, string>();
            foreach (var value in GetValues<T>())
            {
                string text = GetResourceKey(value);
                dic.Add(value, text);              
            }
            return dic;
        }

        /// <summary>
        /// Returns an enum value's resourced text.
        /// The resource key is located in the Description attribute.
        /// </summary>
        /// <typeparam name="T">Type of enum</typeparam>
        /// <param name="element">The enum value</param>
        /// <returns>Resourced text, but if this attribute is not present, the enum's value is returned.</returns>
        private static string GetResourceKey<T>(T element)
        {
            FieldInfo fi = element.GetType().GetField(element.ToString());
            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute));

            return attributes.Length > 0 ? attributes[0].Description : element.ToString();
        }
    }
}

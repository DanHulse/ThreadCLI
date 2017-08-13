using System;
using System.Reflection;
using System.Text.RegularExpressions;

namespace ThreadCLI.Helpers
{
    public static class StringHelpers
    {
        /// <summary>
        /// Splits the string by a delimiter or returns strings between delimiters.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <param name="delimiter">The delimiter.</param>
        /// <param name="secondDelimiter">The second delimiter.</param>
        /// <returns>Array of split strings</returns>
        public static string[] SplitString(this string str, string delimiter, string secondDelimiter = null)
        {
            if (str.Contains($"{delimiter}"))
            {
                if (secondDelimiter == null)
                {
                    return str.Split(new string[] { $"{delimiter}" }, StringSplitOptions.RemoveEmptyEntries);
                }

                return str.Split(new string[] { $"{delimiter}", $"{secondDelimiter}" }, StringSplitOptions.RemoveEmptyEntries);
            }

            return new string[] { str };
        }

        /// <summary>
        /// Parses the string data from the delimiters.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <param name="delimiter">The delimiter.</param>
        /// <param name="secondDelimiter">The second delimiter.</param>
        /// <returns>String containng data from between two markers</returns>
        public static string ParseString(this string str, string delimiter, string secondDelimiter = null)
        {
            if (str.Contains(delimiter))
            {
                if (string.IsNullOrEmpty(secondDelimiter))
                {
                    secondDelimiter = delimiter;
                }

                var matchedString = Regex.Matches(str, $@"\{delimiter}([^)]*)\{secondDelimiter}")[0].Value;

                var trimmedString = matchedString.Replace(delimiter, string.Empty).Replace(secondDelimiter, string.Empty);

                return trimmedString;
            }

            return string.Empty;
        }

        /// <summary>
        /// Parses the string into an enum.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="str">The string.</param>
        /// <param name="delimiter">The delimiter.</param>
        /// <param name="secondDelimiter">The second delimiter.</param>
        /// <returns>Enum value from string</returns>
        public static T ParseEnum<T>(this string str, string delimiter, string secondDelimiter = null)
        {
            if (typeof(T).GetTypeInfo().IsEnum)
            {
                return (T)Enum.Parse(typeof(T), str.ParseString(delimiter, secondDelimiter));
            }

            return default(T);
        }

        /// <summary>
        /// Parses the string into an int.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <param name="delimiter">The delimiter.</param>
        /// <param name="secondDelimiter">The second delimiter.</param>
        /// <returns>Int from the string data</returns>
        public static int? ParseInt(this string str, string delimiter, string secondDelimiter = null)
        {
            var parsedString = str.ParseString(delimiter, secondDelimiter);

            if (Int32.TryParse(parsedString, out int result))
            {
                return result;
            }

            return null;
        }
    }
}

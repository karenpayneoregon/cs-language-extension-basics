using System.Text.RegularExpressions;

namespace ExtensionsLibrary
{
    public static class ConverterExtensions
    {
        /// <summary>
        /// Is string an int
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsInteger(this string input) => 
            int.TryParse(input, out int number);

        public static string StripperNumbers(this string text) =>  
            Regex.Replace(text, "[^A-Za-z]", "");

        public static bool AlphaToInteger(this string text, ref int result)
        {
            var value = Regex.Replace(text, "[^0-9]", "");
            return int.TryParse(value, out result);
        }

    }
}
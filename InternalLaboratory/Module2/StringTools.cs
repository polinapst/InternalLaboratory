using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
    public static class StringTools
    {        
        /// <summary>
        /// Задание 4: Реализовать алгоритм конкатенации двух строк, содержащих только символы латинского алфавита, исключая повторяющиеся символы.
        /// </summary>
        public static string ConcatNonrepeating(string inputStringA, string inputStringB)
        {
            if (inputStringA == null || inputStringA.Length == 0)
            {
                throw new ArgumentNullException(nameof(inputStringA), "Input cannot be null or empty");
            }

            if (inputStringB == null || inputStringB.Length == 0)
            {
                throw new ArgumentNullException(nameof(inputStringB), "Input cannot be null or empty");
            }

            StringBuilder stringBuilder = new StringBuilder();

            foreach (char character in inputStringA)
            {
                if (stringBuilder.ToString().IndexOf(character) < 0)
                {
                    stringBuilder.Append(character);
                }
            }

            foreach (char character in inputStringB)
            {
                if (stringBuilder.ToString().IndexOf(character) < 0)
                {
                    stringBuilder.Append(character);
                }
            }

            return stringBuilder.ToString();
        }
    }
}

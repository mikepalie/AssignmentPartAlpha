using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AssignmentPartAlpha
{
    public class Check
    {
        public static bool isEmptyList(IEnumerable<object> Lista)
        {
            return (Lista.Count() > 0) ? false : true;
        }

        
       public static bool isValidInput1(string str, out int choiceOne)
        {
            if (int.TryParse(str, out choiceOne))
            {
                if (choiceOne < 1 || choiceOne > 2)
                {
                    Console.Clear();
                    Console.WriteLine("Your choice should be 1 or 2 !");
                    return false;
                }
                else
                    return true;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Your input isn't a number !");
                return false;
            }
        }

        public static bool isValidInput2(string str, out int choiceTwo)
        {
            if (int.TryParse(str, out choiceTwo))
            {
                if (choiceTwo < 0 || choiceTwo > 18)
                {
                    Console.Clear();
                    Console.WriteLine("Your choice should between 0 to 18 !");
                    return false;
                }
                else
                    return true;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Your input isn't a number !");
                return false;
            }
        }

        public static bool isDateTimeType(string str)
        {
            return DateTime.TryParse(str, out _);
        }

        public static bool isValidName(string str)
        {
            Regex regex = new Regex("^[a-zA-Z]+$");
            return regex.IsMatch(str);
        }
        public static bool isDouble(string str)
        {
            return Double.TryParse(str, out _);
        }

        public static bool isInt(string str)
        {
            return Int32.TryParse(str, out _);
        }
    }
}

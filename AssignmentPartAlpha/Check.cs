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
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your choice should be 1 or 2 !");
                    Console.ResetColor();
                    return false;
                }
                else
                    return true;
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Your input isn't a number !");
                Console.ResetColor();
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
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your choice should between 0 to 18 !");
                    Console.ResetColor();
                    return false;
                }
                else
                    return true;
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Your input isn't a number !");
                Console.ResetColor();
                return false;
            }
        }

        public static bool isValidInput3(string str, out int choiceThree)
        {
            if (int.TryParse(str, out choiceThree))
            {
                if (choiceThree < 0 || choiceThree > 10)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your choice should be between 0 to 10 !");
                    Console.ResetColor();
                    return false;
                }
                else
                    return true;
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Your input isn't a number !");
                Console.ResetColor();
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

        public static bool isEndDateValid(DateTime start, DateTime end)
        {
            return (start.Year <= end.Year && start.DayOfYear <= end.DayOfYear);
        }

        public static bool isValidMark(int mark)
        {
            return (mark >= 0 && mark <= 100);
        }
    }
}

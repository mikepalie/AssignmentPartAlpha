using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        
    }
}

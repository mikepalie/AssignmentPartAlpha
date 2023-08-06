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
    }
}

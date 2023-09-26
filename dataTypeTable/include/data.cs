using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataTypeTable.include
{
    internal class data
    {
        public static Dictionary<string, string> dict = new Dictionary<string, string>()
        {
            {"byte", "0 to 255" },
            {"sbyte", "-128 to 127" },
            {"short", "-32,768 to 32,767" },
            {"ushort", "0 to 65,535" },
            {"int", "-2,147,483,648 to 2,147,483,647" },
            {"uint", "0 to 4,294,967,295" },
            {"long", "-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807" },
            {"ulong", "0 to 18,446,744,073,709,551,615" },
            {"float", "-3.402823e38 to 3.402823e38" },
            {"double", "-1.79769313486232e308 to 1.79769313486232e308" },
            {"decimal", "(+ or -)1.0 x 10e-28 to 7.9 x 10e28" },
            {"char", "Any valid character, e.g. a,*, \x0058 (hex), or \u0058 (Unicode)" },
            {"bool", "True or False" },
            {"string", "any text" },
        };
    }
}

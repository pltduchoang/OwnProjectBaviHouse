using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BaviHouse.Validator
{
    class ValidatorMethods
    {
        public ValidatorMethods() { }
        public static bool StringValidator(string value)
        {
            if (System.String.IsNullOrWhiteSpace(value))
                return false;
            if (value.Length > 35)
                return false;
            if (value.Any(c => char.IsDigit(c)))
                return false;


            return true;
        }

        public static bool DateValidator(string value)
        {
            if (DateOnly.TryParse(value, out var date))
                return true;
            return false;
        }

        public static bool DoubleValidator(string value)
        {
            if (double.TryParse(value, out var doubleValue))
                return true;
            return false;
        }

        public static bool IntValidator(string value)
        {
            if (int.TryParse(value,out var intValue))
                return true;
            return false;
        }
    }
}

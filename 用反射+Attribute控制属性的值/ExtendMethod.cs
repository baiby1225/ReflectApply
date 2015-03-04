using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 用反射_Attribute控制属性的值
{
    public static class ExtendMethod
    {
        public static bool BetWeenNumber(this int number, int maxNumber, int minNumber)
        {
            bool b = false;
            if (number >= minNumber && number <= maxNumber)
            {
                b = true;
            }
            return b;
        }
        public static bool BetWeenLength(this string str, int maxLength, int minLength)
        {
            bool b = false;
            if (str.Length >= minLength && str.Length <= maxLength)
            {
                b = true;
            }
            return b;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SaintSender
{
    public class Validation
    {
        public static Boolean CorrectEmailAddress(string Address)
        {
            if (Regex.IsMatch(Address, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
                return true;
            else
                return false;
        }

        public static Boolean EmptyInput(string Input)
        {
            if (String.IsNullOrEmpty(Input))
            {
                return true;
            }
            return false;
        }

    }
}

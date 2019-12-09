using System;
using System.Text.RegularExpressions;

namespace EgnHelper
{
    public class EgnValidator
    {

        public bool IsValid(string egn)
        {
            if(!Regex.IsMatch(egn, "(^[0-9]{10}$)"))
            {
                return false;
            }
            return true;
        }
    }
}

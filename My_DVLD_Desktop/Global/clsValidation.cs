using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace My_DVLD_Desktop
{
    public class clsValidation
    {

        public static bool ValidateEmail(string EmailText)
        {
            var pattern = @"^[a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";

            var regex = new Regex(pattern);

            return regex.IsMatch(EmailText);
        }

        public static bool ValidateInteger(string number)
        {
            var Pattern = @"^[0-9]*$";

            var regex = new Regex(Pattern);

            return regex.IsMatch(number);
        }

        public static bool ValidateFloat(string number)
        {
            var Pattern = @"^[0-9]*(?:\.[0-9]*)?$";

            var regex = new Regex(Pattern);

            return regex.IsMatch(number);
        }

        public static bool IsNumber(string Number)
        {
            return ( (ValidateInteger(Number)) || (ValidateFloat(Number)) );
        }







    }
}

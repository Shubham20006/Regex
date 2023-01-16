using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexAssignment
{
     public class UserRegestration
    {
        bool a, b,c;
        public static string Firstname = "^[A-Z]{1}[a-z]{2}$";
        public static string Lastname = "^[A-Z]{1}[a-z]{2}$";
        public static string Email= "^[a-z]{3,}(.[0-9a-z]*)?@([a-z]){2,}.[a-z]+(.in)*";
        public void firstName(string Nm)
        {
             a=Regex.IsMatch(Nm,Firstname);

            if (a)
            {
                Console.WriteLine("{0} is a valid Last name.", Nm);
            }
            else
            {               
                Console.WriteLine("{0} is not a valid Last name.", Nm);               
            }
        }
        public void LastName(string Lm)
        {
             b = Regex.IsMatch(Lm, Lastname);

            if (b)
            {
                Console.WriteLine("{0} is a valid name.", Lm);
            }
            else
            {
                Console.WriteLine("{0} is not a valid name.", Lm);
            }
        }
        public void email(string Em)
        {
            c = Regex.IsMatch(Em, Email);

            if (c)
            {
                Console.WriteLine("{0} is a valid Email.", Em);
            }
            else
            {
                Console.WriteLine("{0} is not a valid Email.", Em);
            }
        }


    }
}

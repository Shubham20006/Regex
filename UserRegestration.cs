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
        bool a, b,c,d;
        public static string Firstname = "^[A-Z]{1}[a-z]{2}$";
        public static string Lastname  = "^[A-Z]{1}[a-z]{2}$";
        public static string Email     = "^[a-z]{3,}(.[0-9a-z]*)?@([a-z]){2,}.[a-z](.in)*";
        public static string Mob       = "^[1 - 9]{2}[: :][0-9]{10}$";
        public static string Pass      = "^.*(?=.{8,})(?=.*[A-Z])(?=.*[0-9])(?=.*[@#$%^&+=]).";
        public bool firstName(string Nm)
        {
            a=Regex.IsMatch(Nm,Firstname);        

            if (a)
            {
                Console.WriteLine("{0} is a valid first name.", Nm);
            }
            else
            {               
                Console.WriteLine("{0} is not a valid first name.", Nm);               
            }
            return a;
        }
        public bool LastName(string Lm)
        {
            b = Regex.IsMatch(Lm, Lastname);

            if (b)
            {
                Console.WriteLine("{0} is a valid lastname.", Lm);
            }
            else
            {
                Console.WriteLine("{0} is not a valid lastname.", Lm);
            }
            return b;
        }
        public bool email(string Em)
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
            return c;
        }
        public bool mobile(string Mb)
        {
            d = Regex.IsMatch(Mb, Mob);

            if (d)
            {
                Console.WriteLine("{0} is a valid Mobile number.", Mb);
            }
            else
            {
                Console.WriteLine("{0} is not a valid Mobile number.", Mb);
            }
            return d;
        }
        public bool PassWord(string Pw)
        {
            d = Regex.IsMatch(Pw, Pass);

            if (d)
            {
                Console.WriteLine("{0} is a valid password.", Pw);
            }
            else
            {
                Console.WriteLine("{0} is not a valid Password.", Pw);
            }
            return d;
        }


    }
}

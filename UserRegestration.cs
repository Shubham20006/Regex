using MoodAnalyserProject;
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
           
                a = Regex.IsMatch(Nm, Firstname);

                if (a)
                {
                    Console.WriteLine("{0} is a valid first name.", Nm);
                return a;
                }
                else
                {                  
                 throw new CustomException(CustomException.ExceptionType.INVALID_FIRSTNAME, "Enter Valid Name");
                }
                
            
          
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
                throw new CustomException(CustomException.ExceptionType.INVALID_LASTNAME, "Enter Valid LastName");
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
                throw new CustomException(CustomException.ExceptionType.INVALID_EMAIL_ADDRESS, "Enter Valid EmailAddress");
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
                throw new CustomException(CustomException.ExceptionType.INVALID_MOBILENUM, "Enter Valid Mobile number");
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
                throw new CustomException(CustomException.ExceptionType.INVALID_PASSWORD, "Enter Valid Password");
            }
            return d;
        }


    }
}

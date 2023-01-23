using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexAssignment
{
    public class CheckingByLambdaExpression
    {
        public static List<string> L = new List<string>();

        public static string Firstname = "^[A-Z]{1}[a-z]{2}$";
        public static string Lastname = "^[A-Z]{1}[a-z]{2}$";
        public static string Email = "^[a-z]{3,}(.[0-9a-z]*)?@([a-z]){2,}.[a-z](.in)*";
        public static string Mob = "^[1 - 9]{2}[: :][0-9]{10}$";
        public static string Pass = "^.*(?=.{8,})(?=.*[A-Z])(?=.*[0-9])(?=.*[@#$%^&+=]).";
        public static void ForFirstName()
        {
            Console.WriteLine("Rule for First Name:-\n1)only 3 character allowed.\n2)Only First char should capital");
            Console.WriteLine("\nEnter first name");
            string Nm = Console.ReadLine();
            L.Add(Nm);
            Regex match = new Regex(Firstname);
            List<string> otherList = L.Select(str => match.Match(str).Value).ToList();
            foreach (string str in otherList)
            {
                if (str.Length > 0)
                {
                    Console.WriteLine("{0} is a valid name.\n", Nm);
                }
                else
                {
                    Console.WriteLine("{0} is  Not valid name.\n", Nm);
                }
            }
            Console.WriteLine("___________________________________________________");
        }

        public static void ForLastName()
        {
            Console.WriteLine("Rule for Last Name:-\n1)only 3 character allowed.\n2)Only First char should capital");
            Console.WriteLine("\nEnter Last name");
            string Lm = Console.ReadLine();
            L.Add(Lm);
            Regex match = new Regex(Lastname);
            List<string> otherList = L.Select(str => match.Match(str).Value).ToList();
            foreach (string str in otherList)
            {
                if (str.Length > 0)
                {
                    Console.WriteLine("{0} is a valid lastname.\n", Lm);
                }
                else
                {
                    Console.WriteLine("{0} is  Not valid lastname.\n", Lm);
                }
            }
            Console.WriteLine("___________________________________________________");
        }
        public static void ForEmail()
        {

            Console.WriteLine("\nEnter Email");
            string Lm = Console.ReadLine();
            L.Add(Lm);
            Regex match = new Regex(Email);
            List<string> otherList = L.Select(str => match.Match(str).Value).ToList();
            foreach (string str in otherList)
            {
                if (str.Length > 0)
                {
                    Console.WriteLine("{0} is a valid EmailAddress.\n", Lm);
                }
                else
                {
                    Console.WriteLine("{0} is  Not valid EmailAddress.\n", Lm);
                }
            }
            Console.WriteLine("___________________________________________________");
        }
        public static void Formobile()
        {

            Console.WriteLine("\nEnter Mobile number");
            string Lm = Console.ReadLine();
            L.Add(Lm);
            Regex match = new Regex(Mob);
            List<string> otherList = L.Select(str => match.Match(str).Value).ToList();
            foreach (string str in otherList)
            {
                if (str.Length > 0)
                {
                    Console.WriteLine("{0} is a valid Mobile number.\n", Lm);
                }
                else
                {
                    Console.WriteLine("{0} is  Not valid Mobile number.\n", Lm);
                }
            }
            Console.WriteLine("___________________________________________________");
        }
        public static void ForPasword()
        {

            Console.WriteLine("\nEnter Passwors");
            string Lm = Console.ReadLine();
            L.Add(Lm);
            Regex match = new Regex(Pass);
            List<string> otherList = L.Select(str => match.Match(str).Value).ToList();
            foreach (string str in otherList)
            {
                if (str.Length > 0)
                {
                    Console.WriteLine("{0} is a valid Password.\n", Lm);
                }
                else
                {
                    Console.WriteLine("{0} is  Not valid Password.\n", Lm);
                }
            }
            Console.WriteLine("___________________________________________________");
        }
    }
}

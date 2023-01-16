using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexAssignment
{
    public class MethodStoring
    {
        public static void ForFirstName()
        {
            Console.WriteLine("Rule for First Name:-\n1)only 3 character allowed.\n2)Only First char should capital");
            Console.WriteLine("\nEnter first name");
            string Nm = Console.ReadLine();

            UserRegestration UR = new UserRegestration();
            UR.firstName(Nm);
        }
    }
}

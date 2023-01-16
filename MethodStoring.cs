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
            Console.WriteLine("\nEnter First Name : ");
            string Nm = Console.ReadLine();
            UserRegestration UR = new UserRegestration();
            UR.firstName(Nm);
        }
        public static void ForLatName()
        {
            Console.WriteLine("\nRule for Last Name:-\n1)only 3 character allowed.\n2)Only First char should capital");
            Console.WriteLine("\nEnter Last Name : ");
            string Lm = Console.ReadLine();

            UserRegestration UR = new UserRegestration();
            UR.LastName(Lm);
        }
        public static void Foremail()
        {
            Console.WriteLine("\nEnter Email : ");
            string Em = Console.ReadLine();

            UserRegestration UR = new UserRegestration();
            UR.email(Em);
        }
        public static void ForNumber()
        {
            Console.WriteLine("\nRule for Number:-\n1)entry code of 2 digit.\n2)give space after entry code\n3)only 10 integer allowed in mobile number.");
            Console.WriteLine("\nEnter Mobilr number with country code : ");
            string Mb = Console.ReadLine();

            UserRegestration UR = new UserRegestration();
            UR.mobile(Mb);
        }
    }
}

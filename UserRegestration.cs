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
        public static string Firstname = "^[A-Z]{1}[a-z]{2}$";

        public void firstName(string Nm)
        {
            bool a=Regex.IsMatch(Nm,Firstname);

            if (a)
            {
                Console.WriteLine("{0} is a valid name.", Nm);
            }
            else
            {               
                Console.WriteLine("{0} is not a valid name.", Nm);
                
                   
                

            }
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class UserDetails
    {
        public static void GetUserInformation()
        {
            Regex regex = new Regex(@"^[A-Z][a-z]{2,}$");
            string firstname;
            Console.WriteLine("\nEnter First Name starting with Caps(min 3 characters)");
            while (true)
            {
                firstname = Console.ReadLine();
                if (regex.IsMatch(firstname))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a Valid First Name!");
                }
            }
            Console.WriteLine("Your First name is: {0}", firstname);
        }
    }
}

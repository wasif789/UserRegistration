﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class UserDetails
    {
        public static string lastname;
        public static string firstname;
        public static string emails;

        public static void GetUserInformation()
        {
            Regex regex = new Regex(@"^[A-Z][a-z]{2,}$");
            Regex email = new Regex(@"^[a-zA-Z0-9]+([\.\+\-][a-zA-Z0-9]+)?@[a-zA-Z0-9-]+(\.[a-zA-Z]{2,}(\.[a-zA-Z]+)?)$");
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

            //Get Last Name from user
            Console.WriteLine("\nEnter Last Name starting with Caps(minimum 3 characters)");
            while (true)
            {
                lastname = Console.ReadLine();
                if (regex.IsMatch(lastname))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a Valid Name Name!");
                }
            }
            //Get email from user
            Console.WriteLine("\nEnter Email Address");
            while (true)
            {
                emails = Console.ReadLine();
                if (email.IsMatch(emails))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a Valid Email!");
                }
            }
            Console.WriteLine("Your First name is: {0}", firstname);
            Console.WriteLine("Your Last name is: {0}", lastname);
            Console.WriteLine("Your Email is: {0}", emails);
        }
    }
}

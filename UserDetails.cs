using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class UserDetails
    {
        public static string firstname;
        public static string lastname;
        public static string emails;
        public static string phoneNumber;
        private static string Password;
        public static Regex regex = new Regex(@"^[A-Z][a-z]{2,}$");
        public static Regex email = new Regex(@"^[a-zA-Z0-9]+([\.\+\-][a-zA-Z0-9]+)?@[a-zA-Z0-9]+(\.[a-zA-Z]{2,}(\.[a-zA-Z]+)?)$");
        public static Regex phone = new Regex(@"^[0-9]+\s[0-9]{10}$");


        public static void GetUserInformation()
        {

            Console.WriteLine("\nEnter First Name starting with Caps(minimum 3 characters)");
            firstname = Console.ReadLine();
            GetFirstName(firstname);

            Console.WriteLine("\nEnter Last Name starting with Caps(minimum 3 characters)");
            lastname = Console.ReadLine();
            GetLastName(lastname);

            Console.WriteLine("\nEnter Email Address");
            emails = Console.ReadLine();
            GetEmail(emails);

            Console.WriteLine("\nEnter Phone Number in the form (COUNTRY CODE \"Space\" 10-digit PHONE NUMBER)");
            phoneNumber = Console.ReadLine();
            GetPhoneNumber(phoneNumber);


            Console.WriteLine("\nEnter Password (minimum 8 characters)");
            Password = Console.ReadLine();
            GetPassword(Password);

            Display();
        }

        public static void Display()
        {
            Console.WriteLine("\n***********Display User Details**********\n");
            Console.WriteLine("Your First name is: {0}", firstname);
            Console.WriteLine("Your Last name is: {0}", lastname);
            Console.WriteLine("Your Email is: {0}", emails);
            Console.WriteLine("Your Phone number is: {0}", phoneNumber);
            Console.WriteLine("Your password is: {0}", Password);

        }

        //Get First Name from user
        public static string GetFirstName(string firstname)
        {

            if (regex.IsMatch(firstname))
            {
                return firstname;
            }
            else
            {
                Console.WriteLine("Please enter a Valid First Name!");
            }

            return default;
        }
        //Get Last Name from user
        public static string GetLastName(string lastname)
        {

            if (regex.IsMatch(lastname))
            {
                return lastname;
            }
            else
            {
                Console.WriteLine("Please enter a Valid Last Name!");
            }
            return default;

        }

        //Get Email from user
        public static string GetEmail(string emails)
        {
            if (email.IsMatch(emails))
            {
                return emails;
            }
            else
            {
                Console.WriteLine("Please enter a Valid Email!");
            }

            return default;
        }
        //Get Phone Number from user
        public static string GetPhoneNumber(string phoneNumber)
        {


            if (phone.IsMatch(phoneNumber))
            {
                return phoneNumber;
            }
            else
            {
                Console.WriteLine("Please enter a Valid Phone Number!");
            }
            return default;

        }
        //Get PassWord from user
        public static string GetPassword(string Password)
        {
            string pattern = @"(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?!.*[<>`])(?=[^.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\]*[.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\][^.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\]*$).{8,}$";
            Regex passWord = new Regex(pattern);
            if (passWord.IsMatch(Password))
            {
                return Password;
            }
            else
            {
                Console.WriteLine("Please enter a Valid Password (minimum 8 characters)!");
            }
            return default;
        }
    }
}


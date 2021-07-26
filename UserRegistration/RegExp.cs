using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace UserRegistration
{
    public class RegExp
    {

        public static string firstName;
        public static string lastName;
        public static string email;
        public static string phomeNumber;
        public static string password;

        public void Validate()
        {
            
            Console.WriteLine("Validate First Name..");
            Console.WriteLine("Enter FirstName ");
            string first = Console.ReadLine();
            ValidateFirstName(first);

            Console.WriteLine(".......................");
            Console.WriteLine("Validating LastName");
            Console.WriteLine("Enter lastName :");
            string last = Console.ReadLine();
            ValidateLastName(last);

            Console.WriteLine("......................");
            Console.WriteLine("Validate Email :");
            Console.WriteLine("Enter email address :");
            string mail = Console.ReadLine();
            ValidateEmail(mail);

            Console.WriteLine("......................");
            Console.WriteLine("Validate Mobile NUmber :");
            Console.WriteLine("Enter mobile Number :");
            string num = Console.ReadLine();
            ValidateMobilNumber(num);

            Console.WriteLine("..........................");
            Console.WriteLine("Validate Password :");
            Console.WriteLine("enter Password :");
            string pw = Console.ReadLine();
            PasswordRule(pw);
        }

        // public static string pattern = "^[A-Z][a-z]{2,}$";
        public static string ValidateFirstName(string firstName)
        {
            Regex exp = new Regex("^[A-Z][a-z]{2,}$");

            bool result = exp.IsMatch(firstName);
            if (result)
            {
                Console.WriteLine("Valid");
                return firstName;

            }
            else
            {
                Console.WriteLine("Invalid");
            }
            return default;
        }

        public static string ValidateLastName(string lastName)
        {
            Regex exp = new Regex("^[A-Z][a-z]{2,}$");

            bool result = exp.IsMatch(lastName);
            if (result)
            {
                Console.WriteLine("Valid");

            }
            else
            {
                Console.WriteLine("Invalid");
            }
            return default;
        }
        public static string ValidateEmail(string email)
        {
            // string[] validEmail = { "abc@yahoo.com", "abc-100$yahoo.com", "abc.100@yahoo.com", "abc111@abc.com", "abc.100@abc.net", "abc#1.com" };
            string eMailPattern = (@" ^[a - zA - Z0 - 9] + ([\.\+-][a - zA - Z0 - 9] +) ?@[a-zA - Z0 - 9]+(\.[a-zA - Z]{ 2,}(\.[a-zA-Z]+)?)$");
            Regex exp = new Regex(eMailPattern);
            // for(int i = 0; i < validEmail.Length;i++)
            //{
            bool result = exp.IsMatch(email);
            if (result)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            return default;
        }

        public static string ValidateMobilNumber(string phoneNumber)
        {
            //  string[] mobileNumbers = { "91 9700914979", "91 7338846979", "919959926452" };
            string numPattern = @"^[0-9]+[\s]+[0-9]{10}$";
            string num = (Console.ReadLine());
            Regex exp = new Regex(numPattern);
            //  for (int i = 0; i < mobileNumbers.Length; i++)
            //   {
            bool res = exp.IsMatch(phoneNumber);
            if (res)
            {
                Console.WriteLine("Mobile Num is Valid.");

            }
            else
            {
                Console.WriteLine("Invalid");
            }
            return default;
            // }
        }
        public static string PasswordRule(string password)
        {
            string[] input = { "Vivek@123", "Aditya@15", "Harish@22", };
            string pwPattern = @"^[a-z]*[A-Z][a-z]*.[a-z]*[0-9][a-z]*$";
            Regex exp = new Regex(pwPattern);
            // Console.WriteLine("Enter password :");
            //string password = Console.ReadLine();
            bool res = exp.IsMatch(password);
            if (res)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            return default;
        }
    }

 }


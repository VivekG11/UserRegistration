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
            try
            {
                if (firstName.Equals(""))
                {
                    throw new Expceptions(Expceptions.ExceptionType.EMPTY_MESSAGE, "FirstName should not be empty");
                }
                if (result)
                {
                    Console.WriteLine("Valid");
                    return firstName;

                }
                else
                {
                    throw new Expceptions(Expceptions.ExceptionType.INVALID_MESSAGE, "Invalid Name");
                    // Console.WriteLine("Invalid");
                }
            }
            catch (NullReferenceException ex)
            {
                return ex.Message;
            }
        }

        public static string ValidateLastName(string lastName)
        {
            Regex exp = new Regex("^[A-Z][a-z]{2,}$");

            bool result = exp.IsMatch(lastName);
            try
            {
                if (result.Equals( null))
                {
                    throw new Expceptions(Expceptions.ExceptionType.NULL, "Last NAme should not be Null");
                }
                if (result)
                {
                    Console.WriteLine("Valid");
                    return lastName;
                }
                else
                {
                    throw new Expceptions(Expceptions.ExceptionType.INVALID_MESSAGE, "Invalid Last Name ");
                // Console.WriteLine("Invalid");
                }
            }
            catch(NullReferenceException ex)
            {
                return ex.Message;
            }
        }
        public static string ValidateEmail(string email)
        {
            // string[] validEmail = { "abc@yahoo.com", "abc-100$yahoo.com", "abc.100@yahoo.com", "abc111@abc.com", "abc.100@abc.net", "abc#1.com" };
            string eMailPattern = (@" ^[a - zA - Z0 - 9] + ([\.\+-][a - zA - Z0 - 9] +) ?@[a-zA - Z0 - 9]+(\.[a-zA - Z]{ 2,}(\.[a-zA-Z]+)?)$");
            Regex exp = new Regex(eMailPattern);
            // for(int i = 0; i < validEmail.Length;i++)
            //{
            bool result = exp.IsMatch(email);
            try
            {
                if (result.Equals(""))
                {
                    throw new Expceptions(Expceptions.ExceptionType.EMPTY_MESSAGE, "Mail Id should not be empty");
                }
                if (result.Equals(null))
                {
                    throw new Expceptions(Expceptions.ExceptionType.NULL, "Mail should not be Null");
                }
                if (result)
                {
                    Console.WriteLine("Valid");
                    return email;
                }
                else
                {
                    throw new Expceptions(Expceptions.ExceptionType.INVALID_MESSAGE, "Invalid Mail");
                   // Console.WriteLine("Invalid");
                }
            }
            catch (NullReferenceException ex)
            {
                return ex.Message;
            }
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
            try
            {
                if (res.Equals(""))
                {
                    throw new Expceptions(Expceptions.ExceptionType.EMPTY_MESSAGE, "Mail Id should not be empty");
                }
                if (res.Equals(null))
                {
                    throw new Expceptions(Expceptions.ExceptionType.NULL, "Mail should not be Null");
                }

                if (res)
                {
                    Console.WriteLine("Mobile Num is Valid.");
                    return phoneNumber;
                }
                else
                {
                    throw new Expceptions(Expceptions.ExceptionType.INVALID_MESSAGE, "Invalid Number");
                    // Console.WriteLine("Invalid");
                }
            }
            catch (NullReferenceException ex)
            {
                return ex.Message;
            }
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
            try
            {
                if (res.Equals(""))
                {
                    throw new Expceptions(Expceptions.ExceptionType.EMPTY_MESSAGE, "Mail Id should not be empty");
                }
                if (res.Equals(null))
                {
                    throw new Expceptions(Expceptions.ExceptionType.NULL, "Mail should not be Null");
                }
                if (res)
                {
                    Console.WriteLine("Valid");
                    return default;
                }
                else
                {
                    throw new Expceptions(Expceptions.ExceptionType.INVALID_MESSAGE, "Invalid Password");
                    // Console.WriteLine("Invalid");
                }
            }
            catch (NullReferenceException ex)
            {
                return ex.Message;
            }
        }
    }

 }


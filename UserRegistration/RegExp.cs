using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace UserRegistration
{
    public class RegExp
    {

        public static Func<string, string> ValidateFirstName = (firstName) =>
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
          };

        public static Func<string, string> ValidateLastName = (lastName) =>
         {
             Regex exp = new Regex("^[A-Z][a-z]{2,}$");

             bool result = exp.IsMatch(lastName);
             try
             {
                 if (result.Equals(null))
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
             catch (NullReferenceException ex)
             {
                 return ex.Message;
             }
         };
        public static Func<string, string> ValidateEmail = (email) =>
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
         };

        public static Func<string, string> ValidateMobilNumber = (phoneNumber) =>
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
        };
        public static Func<string, string> PasswordRule = (password) =>
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
      };
    }

 }


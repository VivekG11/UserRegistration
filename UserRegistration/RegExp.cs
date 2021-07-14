using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace UserRegistration
{
    class RegExp
    {
       public static  string pattern = "^[A-Z][a-z]{2,}$";
        public void ValidateFirstName()
        {
            Regex exp = new Regex(pattern);
            Console.WriteLine("Enter first name :");
            string firstName = Console.ReadLine();
            bool result = Regex.IsMatch(firstName, pattern);
           if(result)
            {
                Console.WriteLine("Valid");
     
            }
           else
            {
                Console.WriteLine("Invalid");
            }
        }
        public void ValidateLastName()
        {
            Regex exp = new Regex(pattern);
            Console.WriteLine("Enter Last name :");
            string lastName = Console.ReadLine();
            bool result = Regex.IsMatch(lastName, pattern);
            if (result)
            {
                Console.WriteLine("Valid");

            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}

using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User Registration.......");
            RegExp regExp = new RegExp();
            // regExp.ValidateEmail();
           // regExp.ValidateMobilNumber();
            regExp.PasswordRule();
        }
    }
}

using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User Registration.......");
            Console.WriteLine("Verifying Details....");
           // RegExp regExp = new RegExp();
            //regExp.Validate();
            Console.WriteLine("Enter first Name :");
            string first = Console.ReadLine();
            RegExp.ValidateFirstName(first);

            Console.WriteLine("Validating LastName");
            Console.WriteLine("Enter lastName :");
            string last = Console.ReadLine();
            RegExp.ValidateLastName(last);

            Console.WriteLine("Validate Email :");
            Console.WriteLine("Enter email address :");
            string mail = Console.ReadLine();
            RegExp.ValidateEmail(mail);

            Console.WriteLine("......................");
            Console.WriteLine("Validate Mobile NUmber :");
            Console.WriteLine("Enter mobile Number :");
            string num = Console.ReadLine();
            RegExp.ValidateMobilNumber(num);

            Console.WriteLine("..........................");
            Console.WriteLine("Validate Password :");
            Console.WriteLine("enter Password :");
            string pw = Console.ReadLine();
            RegExp.PasswordRule(pw);

        }
    }
}

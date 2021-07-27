using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistration
{
     public class Expceptions : Exception
    {
        ExceptionType type;
        public string message;

        public enum ExceptionType
        {
            NULL,EMPTY_MESSAGE,INVALID_MESSAGE
        }
        public Expceptions(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}

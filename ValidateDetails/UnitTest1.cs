using Microsoft.VisualStudio.TestTools.UnitTesting;

using UserRegistration;

namespace ValidateDetails
{
    [TestClass]
    public class Validation
    {
        
         [TestMethod]
         [DataRow("Vivek" , "Vivek")]
         [DataRow("Vivek" , " ")]
         public void ValidateFirst(string x , string expected)

         {
             var actual = RegExp.ValidateFirstName(x);
             Assert.AreEqual(expected, actual);
         }

        [TestMethod]
        public void ValidatingFirstName()
        {
            string input = "Vivek";
            string res = RegExp.ValidateFirstName(input);

            Assert.AreEqual(res, input);


        }
       

        [TestMethod]
        [DataRow("Vivek", "Vivek")]
        [DataRow("Vivek", " ")]
        public void ValidateLast(string x, string expected)

        {
            var actual = RegExp.ValidateLastName(x);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("abc@yahoo.com", "abc@yahoo.com")]
        [DataRow ("abc.100@yahoo.com" , "abc.100@yahoo.com")]
        [DataRow ("abc111@abc.com" , null)]

        public void ValidateMail(string x , string expected)
        {
            var actual = RegExp.ValidateEmail(x);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow ("91 9700914979" , "91 9700914979")]
        [DataRow ("91 7338846969" ," 91 7338846979")]
        [DataRow ("91 9676294064" , null)]
        
        public void ValidateNumber(string x, string expected)
        {
            var actual = RegExp.ValidateMobilNumber(x);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow ("Vivek@13","Vivek@13")]
        [DataRow ("Siva#159", "Siva#159")]
        [DataRow ("Abhi@166" , null)]

        public void ValidatePassword(string x , string expected)
        {
            var actual = RegExp.PasswordRule(x);
            Assert.AreEqual(expected, actual);
        }

    }
}


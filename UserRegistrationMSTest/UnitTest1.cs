using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;

namespace UserRegistrationMSTest
{
    [TestClass]
    public class UnitTest1
    {
        //Validation for First Name
        [TestMethod]
        [DataRow("Ash", "Ash")]
        [DataRow("As", "Please enter a Valid First Name!")]
        [DataRow("asmitha", "Please enter a Valid First Name!")]
        [DataRow("Asmi12", "Please enter a Valid First Name!")]
        [DataRow(null, "Object reference not set to an instance of an object.")]
        [DataRow("", "Please enter a Valid First Name!")]
        public void ValidateUserFirstname(string a, string expected)
        {
            try
            {
                var actual = UserDetails.GetFirstName(a);
                Assert.AreEqual(expected, actual);
            }
            catch (CustomisedException actual)
            {
                Assert.AreEqual(expected, actual.Message);
            }

        }

        //Validation for Last Name
        [TestMethod]
        [DataRow("Satesh", "Satesh")]
        [DataRow("Sa", "Please enter a Valid Last Name!")]
        [DataRow("satesh", "Please enter a Valid Last Name!")]
        [DataRow(null, "Object reference not set to an instance of an object.")]
        [DataRow("Satesh12", "Please enter a Valid Last Name!")]
        [DataRow("", "Please enter a Valid Last Name!")]
        public void ValidateUserLastname(string a, string expected)
        {
            try
            {
                var actual = UserDetails.GetLastName(a);
                Assert.AreEqual(expected, actual);
            }
            catch (CustomisedException actual)
            {
                Assert.AreEqual(expected, actual.Message);
            }

        }

        //Validation for Email
        [TestMethod]
        [DataRow("abc@gmail.com", "abc@gmail.com")]
        [DataRow("abc-100@yahoo.com", "abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com", "abc.100@yahoo.com")]
        [DataRow("abc111@yahoo.com", "abc111@yahoo.com")]
        [DataRow("abc111@abc.com", "abc111@abc.com")]
        [DataRow("abc-100@abc.net", "abc-100@abc.net")]
        [DataRow("abc.100@abc.com.au", "abc.100@abc.com.au")]
        [DataRow("abc@1.com", "abc@1.com")]
        [DataRow("abc@gmail.com.com", "abc@gmail.com.com")]
        [DataRow("abc+100@gmail.com", "abc+100@gmail.com")]
        [DataRow("abc", "Please enter a Valid Email!")]
        [DataRow("abc@.com.my", "Please enter a Valid Email!")]
        [DataRow("abc123@.com", "Please enter a Valid Email!")]
        [DataRow("abc123@.com.com", "Please enter a Valid Email!")]
        [DataRow("abc()*@gmail.com", "Please enter a Valid Email!")]
        [DataRow(".abc@abc.com", "Please enter a Valid Email!")]
        [DataRow("abc@%*.com", "Please enter a Valid Email!")]
        [DataRow("abc..2002@gmail.com", "Please enter a Valid Email!")]
        [DataRow("abc.@gmail.com", "Please enter a Valid Email!")]
        [DataRow("abc@abc@gmail.com", "Please enter a Valid Email!")]
        [DataRow("abc@gmail.com.1a", "Please enter a Valid Email!")]
        [DataRow("abc@gmail.com.aa.au", "Please enter a Valid Email!")]
        [DataRow(null, "Object reference not set to an instance of an object.")]
        [DataRow("", "Please enter a Valid Email!")]

        public void ValidateUserEmail(string a, string expected)
        {
            try
            {
                var actual = UserDetails.GetEmail(a);
                Assert.AreEqual(expected, actual);
            }
            catch (CustomisedException actual)
            {
                Assert.AreEqual(expected, actual.Message);
            }
        }

        //Validation for Phone Number
        [TestMethod]
        [DataRow("1 1000987267", "1 1000987267")]
        [DataRow("91 9842905050", "91 9842905050")]
        [DataRow("100 9842905050", "100 9842905050")]
        [DataRow("919842905050", "Please enter a Phone Number!")]
        [DataRow("919842905", "Please enter a Phone Number!")]
        [DataRow("91 984290", "Please enter a Phone Number!")]
        [DataRow("91 984290505000000", "Please enter a Phone Number!")]
        [DataRow(null, "Object reference not set to an instance of an object.")]
        [DataRow("", "Please enter a Phone Number!")]
        public void ValidateUserPhoneNumber(string a, string expected)
        {
            try
            {
                var actual = UserDetails.GetPhoneNumber(a);
                Assert.AreEqual(expected, actual);
            }
            catch (CustomisedException actual)
            {
                Assert.AreEqual(expected, actual.Message);
            }
        }

        ////Validation for Password
        [TestMethod]
        [DataRow("Asmith@123", "Asmith@123")]
        [DataRow("asMi#tha123", "asMi#tha123")]
        [DataRow("asmi@tha1S", "asmi@tha1S")]
        [DataRow("@Asmitha129", "@Asmitha129")]
        [DataRow("As-mitha123", "As-mitha123")]
        [DataRow("asmitha123)@1234", "Please enter a Password!")]
        [DataRow("Asmit@haa", "Please enter a Password!")]
        [DataRow("ash123", "Please enter a Password!")]
        [DataRow("ash@123", "Please enter a Password!")]
        [DataRow("@asmi#12ash", "Please enter a Password!")]
        [DataRow(")asmi12", "Please enter a Password!")]
        [DataRow(")asMi12", "Please enter a Password!")]
        [DataRow("asm-tha@12S", "Please enter a Password!")]
        [DataRow("asmiTha@s", "Please enter a Password!")]
        [DataRow(null, "Object reference not set to an instance of an object.")]
        [DataRow("", "Please enter a Password!")]

        public void ValidateUserPassword(string a, string expected)
        {
            try
            {
                var actual = UserDetails.GetPassword(a);
                Assert.AreEqual(expected, actual);
            }
            catch (CustomisedException actual)
            {
                Assert.AreEqual(expected, actual.Message);
            }
        }

    }
}

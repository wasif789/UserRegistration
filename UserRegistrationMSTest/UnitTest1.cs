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
        [DataRow("As", null)]
        [DataRow("asmitha", null)]
        [DataRow("Asmi12", null)]
            public void ValidateUserFirstname(string a, string expected)
            {
                var actual = UserDetails.GetFirstName(a);
                Assert.AreEqual(expected, actual);
            }

            //Validation for Last Name
            [TestMethod]
            [DataRow("Satesh", "Satesh")]
            [DataRow("Sa", null)]
            [DataRow("satesh", null)]
            [DataRow("Satesh12", null)]
            public void ValidateUserLastname(string a, string expected)
            {
                var actual = UserDetails.GetLastName(a);
                Assert.AreEqual(expected, actual);
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
            [DataRow("abc", null)]
            [DataRow("abc@.com.my", null)]
            [DataRow("abc123@.com", null)]
            [DataRow("abc123@.com.com", null)]
            [DataRow("abc()*@gmail.com", null)]
            [DataRow(".abc@abc.com", null)]
            [DataRow("abc@%*.com", null)]
            [DataRow("abc..2002@gmail.com", null)]
            [DataRow("abc.@gmail.com", null)]
            [DataRow("abc@abc@gmail.com", null)]
            [DataRow("abc@gmail.com.1a", null)]
            [DataRow("abc@gmail.com.aa.au", null)]

            public void ValidateUserEmail(string a, string expected)
            {
                var actual = UserDetails.GetEmail(a);
                Assert.AreEqual(expected, actual);
            }

            //Validation for Phone Number
            [TestMethod]
            [DataRow("1 1000987267", "1 1000987267")]
            [DataRow("91 9842905050", "91 9842905050")]
            [DataRow("100 9842905050", "100 9842905050")]
            [DataRow("919842905050", null)]
            [DataRow("919842905", null)]
            [DataRow("91 984290", null)]
            [DataRow("91 984290505000000", null)]
            public void ValidateUserPhoneNumber(string a, string expected)
            {
                var actual = UserDetails.GetPhoneNumber(a);
                Assert.AreEqual(expected, actual);
            }

            ////Validation for Password
            [TestMethod]
            [DataRow("Asmith@123", "Asmith@123")]
            [DataRow("asMi#tha123", "asMi#tha123")]
            [DataRow("asmi@tha1S", "asmi@tha1S")]
            [DataRow("@Asmitha129", "@Asmitha129")]
            [DataRow("As-mitha123", "As-mitha123")]
            [DataRow("asmitha123)@1234", null)]
            [DataRow("Asmit@haa", null)]
            [DataRow("ash123", null)]
            [DataRow("ash@123", null)]
            [DataRow("@asmi#12ash", null)]
            [DataRow(")asmi12", null)]
            [DataRow(")asMi12", null)]
            [DataRow("asm-tha@12S", null)]
            [DataRow("asmiTha@s", null)]

            public void ValidateUserPassword(string a, string expected)
            {
                var actual = UserDetails.GetPassword(a);
                Assert.AreEqual(expected, actual);
            }

        
    }
}

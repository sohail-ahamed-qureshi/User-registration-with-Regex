using NUnit.Framework;
using System;
using UserRegistrationUsingRegex;

namespace NUnitUserValidation
{
    public class Tests
    {
        bool firstName, sadFirstName;
        bool lastName, sadLastName;
        bool mobile, sadMobile;
        bool email, sadEmail;
        bool password, sadPassword;
        [SetUp]
        public void SetupForHappy_ReturnsEntrySuccessfully()
        {
            //Happy test case entry successfull
            RegexValidation regex = new RegexValidation();
            firstName = regex.CheckName("Sohail");
            lastName = regex.CheckName("Ahamed");
            mobile = regex.CheckMobileNo("91 9663552136");
            email = regex.CheckEmail("sohailqureshi82@gmail.com");
            password = regex.CheckPassword("S@k12345678");

            //Sad Test case entry fails
            sadFirstName = regex.CheckName("sohail");
            sadLastName = regex.CheckName("Aha");
            sadMobile = regex.CheckMobileNo("919663552136");
            sadEmail = regex.CheckEmail("sohailqureshi82gmail.com");
            sadPassword = regex.CheckPassword("Sk12345678");
        }
        [Test]
        public void GivenUserValidations_ReturnsEntrySuccessfully()
        {
            if (firstName && lastName && mobile && email && password)
                Assert.Pass("Entry SuccessFull");
            else
                Assert.Fail("Entry Failed");
        }
        [Test]
        public void GivenUserValidations_ReturnsEntryFails()
        {
            if (sadFirstName && sadLastName && sadMobile && sadEmail && sadPassword)
                Assert.Pass("Entry SuccessFull");
            else
                Assert.Fail("Entry Failed");
        }

        [Test]
        [TestCase("sohailquershi@gmail.com")]
        [TestCase("abc.100@yahoo.com")]
        [TestCase("abc-100@abc.net")]
        [TestCase("abc.100@abc.com.au")]
        [TestCase("abc+100@gmail.com")]
        public void GivenMultipleEmailsEntries_ReturnsResult(string email)
        {
            RegexValidation regex = new RegexValidation();
            bool result = regex.CheckEmail(email);
            Assert.IsTrue(result);
        }
    }
}
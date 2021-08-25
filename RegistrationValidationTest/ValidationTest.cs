using NUnit.Framework;
using RegistrationValidation;

namespace RegistrationValidationTest
{
    public class Tests
    {
        UserRegister userRegister = new UserRegister();
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GivenFirstName_WhenValidated_ShouldReturnHappy()
        {
            string firstName = "Pavan";
            bool result = userRegister.FirstNameValidate(firstName);
            Assert.AreEqual(true, result);
            Assert.Pass();
        }
        [Test]
        public void GivenFirstName_WhenValidated_ShouldReturnSad()
        {
            string firstName = "Pavan12";
            bool result = userRegister.FirstNameValidate(firstName);
            Assert.AreEqual(false, result);
            Assert.Pass();
        }
        [Test]
        public void GivenLastName_WhenValidated_ShouldReturnHappy()
        {
            string lastName = "Yalala";
            bool result = userRegister.LastNameValidation(lastName);
            Assert.AreEqual(true, result);
            Assert.Pass();
        }

        [Test]
        public void GivenLastName_WhenNotValidated_ShouldReturnSad()
        {
            string lastName = "yalala";
            bool result = userRegister.LastNameValidation(lastName);
            Assert.AreEqual(false, result);
            Assert.Pass();
        }
        [Test]
        public void GivenMobileNumber_WhenValidated_ShouldReturnHappy()
        {
            string number = "91 9010073313";
            bool result = userRegister.MobileValidation(number);
            Assert.AreEqual(true, result);
            Assert.Pass();
        }

        [Test]
        public void GivenMobileNumber_WhenNotValidated_ShouldReturnSad()
        {
            string number = "9010073313";
            bool result = userRegister.MobileValidation(number);
            Assert.AreEqual(false, result);
            Assert.Pass();
        }

        [Test]
        public void GivenPassword_WhenValidated_ShouldReturnHappy()
        {
            string password = "Pawan@12";
            bool result = userRegister.PasswordValidation(password);
            Assert.AreEqual(true, result);
            Assert.Pass();
        }

        [Test]
        public void GivenPassword_WhenNotValidated_ShouldReturnSad()
        {
            string password = "akjakj";
            bool result = userRegister.PasswordValidation(password);
            Assert.AreEqual(false, result);
            Assert.Pass();
        }

        [Test]
        public void GivenEmailId_WhenValidated_ShouldReturnHappy()
        {
            string email = "pavanyalala67@gmail.com";
            bool result = userRegister.EmailValidation(email);
            Assert.AreEqual(true, result);
            Assert.Pass();
        }

        [Test]
        public void GivenEmailId_WhenNotValidated_ShouldReturnSad()
        {
            string email = "pas@45sa";
            bool result = userRegister.EmailValidation(email);
            Assert.AreEqual(false, result);
            Assert.Pass();
        }
        [Test]
        [TestCase("abc-100@yahoo.com")]
        [TestCase("abc@yahoo.com")]
        [TestCase("abc.100@yahoo.com")]
        [TestCase("abc111@abc.com")]
        
        public void GivenMultipleEmailIds_WhenValidated_ShouldReturnHappy(string email)
        {
            bool result = userRegister.EmailValidation(email);
            Assert.AreEqual(true, result);
            Assert.Pass();
        }
        [TestCase("abc-100")]
        [TestCase("abch")]
        [TestCase("@ya")]
        [TestCase("a1")]

        public void GivenMultipleEmailIds_WhenValidated_ShouldReturnSad(string email)
        {
            bool result = userRegister.EmailValidation(email);
            Assert.AreEqual(false, result);
            Assert.Pass();
        }

    }
}
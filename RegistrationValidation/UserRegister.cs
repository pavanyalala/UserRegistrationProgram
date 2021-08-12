using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegistrationValidation
{
    class UserRegister
    {
        readonly string FirstLastName = "^[A-Z]{1}[a-z]{2,}$";

        /// <summary>
        /// first name validation
        /// </summary>
        /// <returns></returns>
        public bool FirstNameValidate(string name)
        {
            Regex regex = new Regex(FirstLastName);
            bool Validation = regex.IsMatch(name);
            if(Validation)
                Console.WriteLine("First Name is Valid");
            else
                Console.WriteLine("First Name is Not Valid");
            return Validation;
        }
        /// <summary>
        /// Uc-2 last name validation
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool LastNameValidation(string name)
        {

            Regex regex = new Regex(FirstLastName);
            bool Validation = regex.IsMatch(name);
            if (Validation)
                Console.WriteLine("Last Name is Valid");
            else
                Console.WriteLine("Last Name is Not Valid");
            return Validation;
        }
        public bool EmailValidation(string Email)
        {
            string Mail = "^[0-9a-zA-z]+[.+_-]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-z]{2,3}([.][a-zA-z]{2,3}){0,1}$";
            Regex regex = new Regex(Mail);
            bool Validation = regex.IsMatch(Email);
            if (Validation)
                Console.WriteLine("Last Name is Valid");
            else
                Console.WriteLine("Last Name is Not Valid");
            return Validation;
        }
        /// <summary>
        /// UC-4 Mobile validation
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public bool MobileValidation(string number)
        {
            string Number= "^[9][1][ ][6-9]{1}[0-9]{9}$";
            Regex regex = new Regex(Number);
            bool Validation = regex.IsMatch(number);
            if (Validation)
                Console.WriteLine("Phone Number  is Valid");
            else
                Console.WriteLine("Phone Number is Not Valid");
            return Validation;
        }
        /// <summary>
        /// UC-5 password validation
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool PasswordValidation(string name)
        {
            string Password = "^[A-Za-z0-9!@#$%^&*]{8}$";
            Regex regex = new Regex(Password);
            bool Validation = regex.IsMatch(name);
            if (Validation)
                Console.WriteLine("Password  is Valid");
            else
                Console.WriteLine("Password is Not Valid");
            return Validation;
        }
        /// <summary>
        /// UC 6 Atleast one upper case
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool UpperCasePasswordValidation(string name)
        {
            string Password = "^[A-Za-z0-9!@#$%^&*]{7}[A-Z]{1}$";
            Regex regex = new Regex(Password);
            bool Validation = regex.IsMatch(name);
            if (Validation)
                Console.WriteLine("Password  is Valid");
            else
                Console.WriteLine("Password is Not Valid");
            return Validation;
        }
        /// <summary>
        /// UC-7 Numeric password valiadtion
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool NumericPasswordValidation(string name)
        {
            string Password = "^[A-Za-z0-9!@#$%^&*]{6}[A-Z]{1}[0-9]{1}$";
            Regex regex = new Regex(Password);
            bool Validation = regex.IsMatch(name);
            if (Validation)
                Console.WriteLine("Password  is Valid");
            else
                Console.WriteLine("Password is Not Valid");
            return Validation;
        }

    }
}

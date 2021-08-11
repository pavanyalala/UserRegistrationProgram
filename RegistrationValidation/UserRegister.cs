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
        public bool MobileValidation(string number)
        {
            String Number= "^[9][1][ ][6-9]{1}[0-9]{9}$";
            Regex regex = new Regex(Number);
            bool Validation = regex.IsMatch(number);
            if (Validation)
                Console.WriteLine("Phone Number  is Valid");
            else
                Console.WriteLine("Phone Number is Not Valid");
            return Validation;
        }
    }
}

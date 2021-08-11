using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegistrationValidation
{
    class UserRegister
    {
        string FirstName = "^[A-Z]{1}[a-z]{2,}$";
        /// <summary>
        /// first name validation
        /// </summary>
        /// <returns></returns>
        public bool FirstNameValidate(string name)
        {
           
            Regex regex = new Regex(FirstName);
            bool Validation = regex.IsMatch(name);
            if(Validation)
                Console.WriteLine("First Name is Valid");
            else
                Console.WriteLine("First Name is Not Valid");
            return Validation;
        }
        
    }
}

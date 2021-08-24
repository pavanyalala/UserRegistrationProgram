using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegistrationValidation
{
    class ValidAllEmails
    {
        public void ValidEmail()
        {
            const string ValidMail = "^[0-9a-zA-z]+[.+_-]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-z]{2,3}([.][a-zA-z]{2,3}){0,1}$";
            string[] Mail =
            {
                "abc@yahoo.com",
                "abc-100@yahoo.com",
                "abc.100@yahoo.com",
                "abc111@abc.com",
                "abc-100@abc.net",
                "abc.100@abc.com.au",
                "abc@1.com",
                "abc@gmail.com.com",
                "abc+100@gmail.com" ,
                "abc",
                "abc@.com.my",
                "abc123@gmail.a",
                "abc123@.com" ,
                "abc123@.com.com",
                ".abc@abc.com",
                "abc()*@gmail.com",
                "abc@%*.com",
                "abc..2002@gmail.com",
                "abc.@gmail.com",
                "abc@abc@gmail.com",
                "abc@gmail.com.1a",
                "abc@gmail.com.aa.au"
            };
            for (int i = 0; i <= Mail.Length; i++)
            {
                if (Regex.IsMatch(Mail[i], ValidMail) == true)
                    Console.WriteLine(" Valid Mail : " + Mail[i]); 
                else
                    Console.WriteLine("Invalid Mail : " +Mail[i]);
            }
        }
    }
}

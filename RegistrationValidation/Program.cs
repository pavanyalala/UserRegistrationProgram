using System;

namespace RegistrationValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Program");
            UserRegister userRegister = new UserRegister();
            Console.WriteLine("Enter Choice" +
                              "\n1.FirstName" +
                              "\n2.LastName" +
                              "\n3.Email Validation" +
                              "\n4.Phone Number" +
                              "\n5.Password " +
                              "\n6.Upper case password" +
                              "\n7.Numeric password" +
                              "\n8.Valid All Mails"
                              
                             );
            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    bool val1 = userRegister.FirstNameValidate("Pavan");
                    Console.WriteLine(val1);
                    break;
                case 2:
                    bool val2 = userRegister.LastNameValidation("Yalala");
                    Console.WriteLine(val2);
                    break;
                case 3:
                    bool val3 = userRegister.EmailValidation("pavanyalala4508@gmail.com");
                    Console.WriteLine(val3);
                    break;
                case 4:
                    bool val4 = userRegister.MobileValidation("91 9010073313");
                    Console.WriteLine(val4);
                    break;
               case 5:
                    bool val5 = userRegister.PasswordValidation("poij456%");
                    Console.WriteLine(val5);
                    break;
                case 6:
                    bool val6 = userRegister.UpperCasePasswordValidation("gg45487S");
                    Console.WriteLine(val6);
                    break;
                case 7:
                    bool val7 = userRegister.NumericPasswordValidation("hjhjhjA7");
                    Console.WriteLine(val7);
                    break;
                case 8:
                    ValidAllEmails validAllEmails = new ValidAllEmails();
                    validAllEmails.ValidEmail();
                    break;
                



            }
            
           
        }
    }
}

using System;

namespace RegistrationValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Program");
            UserRegister userRegister = new UserRegister();
            bool val =  userRegister.FirstNameValidate("Pavan");
            Console.WriteLine(val);
        }
    }
}

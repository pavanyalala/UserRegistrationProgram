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
                              "\n2.LastName" 
                              
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
               
            }
            
           
        }
    }
}

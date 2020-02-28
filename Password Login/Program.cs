
using System;
using System.Text.RegularExpressions;

namespace Password_Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "";
            string login = "";
            Console.WriteLine(@"Напишите консольное приложение, позволяющие пользователю зарегистрироваться под «Логином»,
состоящем только из символов латинского алфавита, и пароля, состоящего из цифр и символов.");
            Console.WriteLine(new string('-', 7));
            string patternForPassword = @"[a-zA-Z0-9]"; // @"^(?=.*\d)(?=.*[a-z])(?=.*[0-9])(?=.*[A-Z])(?!.*\s).*$";
            string patternForLogin = @"^[a-zA-Z]";
         
            Console.WriteLine("Enter a login");
            login = Console.ReadLine();
          
            Console.WriteLine("Enter a password");
            password = Console.ReadLine();
            
            
            Regex regex1 = new Regex(patternForLogin);
            if (regex1.IsMatch(login))
            {
                Console.WriteLine("The login is good");
            }

            else Console.WriteLine("Bad-bad-bad login");
            
            Regex regex = new Regex(patternForPassword);
            if (regex.IsMatch(password))
            {
                Console.WriteLine("The password is good");
            }
            else Console.WriteLine("Bad-bad-bad password");
            Console.ReadLine();
        }
    }
}

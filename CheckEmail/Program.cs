using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CheckEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input e-mail: ");

            string line;
            do
            {
                line = Console.ReadLine();
            }
            while (!IsValid(line));
            Console.WriteLine("New address was saved");
            string eMail = line;
            Console.ReadLine();
        }
        static bool IsValid(string eMail)
        {
            string pattern = @"^[a-z0-9_-]+@[a-z0-9_-]+\.{1}\w{2,3}$";
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
            if (regex.IsMatch(eMail))
                if(!Regex.IsMatch(eMail, @"\s"))
                return true; 
            Console.WriteLine("This e-mail is not valid. Please, try again");
            return false;
        }
    }
}

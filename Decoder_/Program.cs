//Напишите шуточную программу «Дешифратор», которая бы в текстовом файле могла бы заменить все предлоги на слово «ГАВ!».

using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Decoder_
{
    class Program
    {
        static void Main(string[] args)
        {

            var stream = new StreamReader("pretexts.txt", Encoding.Default);
            string pretexts = stream.ReadToEnd();
            stream.Close();
   
            stream = new StreamReader("text.txt", Encoding.Default);
            Console.WriteLine("Строка до шифрования:");
            string text = stream.ReadToEnd();
         

            stream.Close();
            Console.WriteLine(text);
            MatchCollection match = Regex.Matches(pretexts, "\"(.*?)\"", RegexOptions.Singleline); 
            string result = string.Empty;
            for (int i = 0; i < match.Count; i++)
            {
                text = Regex.Replace(text, "\\s"+match[i].Groups[1].Value + "\\s", " ГАВ ");
            }
            for (int i = 0; i < match.Count; i++)
            {
                text = Regex.Replace(text, "\\b" + match[i].Groups[1].Value.ToUpper() + "\\s", "ГАВ ");
            }

            Console.WriteLine("\nСтрока после шифрования:");

            Console.WriteLine(text);

            using (StreamWriter sw = new StreamWriter("newText.txt", false, Encoding.Default))
            {
                sw.Write(text);
            }
            Console.ReadLine();
        }
    }
}

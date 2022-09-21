using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scope
{
    class Program
    {
        static string language = "english";
        static void Main(string[] args)
        {
            showOff();
            Console.WriteLine(language);
        }

        private static void showOff()
        {
            List<string> languages = new List<string> { "english", "german", "french", "spanish"};

            foreach(string language in languages)
            {
                sayHello(language);
            }
        }

        private static void sayHello(string language)
        {
            Console.Write($"you can greet people in {language} by saying ");
            switch(language)
            {
                case "english":
                    Console.WriteLine("hello");
                    break;
                case "german":
                    Console.WriteLine("hallo");
                    break;
                case "french":
                    Console.WriteLine("bonjour");
                    break;
                case "spanish":
                    Console.WriteLine("hola");
                    break;
                default:
                    Console.WriteLine("huh");
                    break;
            }
        }
    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Section_04
{
    class Program
    {
        static void Main(string[] args)
        {
            validateEmail();
            CapitalizeOneWord();
            CapitalizeOneOrEachWordInASentence();

        }
        static void validateEmail()
        {

            Console.WriteLine("Please enter an e-mail address to check if it is valid.");
            string input = Console.ReadLine();

            if (input.Length == 0)
            {
                Console.WriteLine("Given E-mail is empty.");
            }
            else if (new EmailAddressAttribute().IsValid(input))
            {
                Console.WriteLine("E-mail is valid.");
            }
            else
            {
                Console.WriteLine("E-mail is not valid.");
            }
        }

        static void CapitalizeOneWord()
        {
            Console.WriteLine("Please enter a word to capitalize it:\n");
            string str = Console.ReadLine();

            if (str.Length == 0)
                System.Console.WriteLine("Empty String");

            else if (str.Length == 1)
                System.Console.WriteLine("Result: " + char.ToUpper(str[0]));

            else
                System.Console.WriteLine("Result: " + char.ToUpper(str[0]) + str.Substring(1));
            

        }

        static void CapitalizeOneOrEachWordInASentence()
        {
            Console.Write("\nPlease enter a sentence you'd wish to be capitalized:\n");
            string str = Console.ReadLine();
            string titleCase = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
            
            Console.WriteLine("Result: " + titleCase);
            
            Console.ReadKey();

        }
    }
}


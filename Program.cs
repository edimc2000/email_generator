using System.Globalization;
using System.Xml.Linq;

namespace email_generator;

internal class Program
{
    private static void Main(string[] args)
    {
        User employee1 = new();

        employee1.Suffix = "robertsoncollege.ca";

        Write("Input your First Name\t: ");
        employee1.FirstName = (ReadLine() ?? "").Trim();
        Write("Input your Last Name\t: ");
        employee1.LastName = (ReadLine() ?? "").Trim();


        
        PromptBirthYear(); 

        WriteLine("Last Name \t:" + employee1.FirstName);
        WriteLine("First Name \t: " + employee1.LastName);
        WriteLine("Birth Year \t: " + employee1.LastName);
        WriteLine("Email Address \t: " + employee1.Email);
        PrintMessage(employee1.FirstName, employee1.LastName, employee1.Email);



        void PromptBirthYear()
        {
            while (true)
            {
                Write("Input your Year of Birth (4 digits) \t: ");
                string birthYR = ReadLine(); 

                if (birthYR.Length == 4 && birthYR.All(char.IsDigit))
                {
                    employee1.BirthYear = int.Parse(birthYR);
                    break;
                }

                WriteLine("Error: Year of birth must be a 4-digit numeric value (e.g., 1998).");

            }
        }


        void PrintMessage(string firstName, string lastName, string emailAddress)
        {
            string fullName = $"{firstName} {lastName}";
            string formattedName =
                CultureInfo.CurrentCulture.TextInfo.ToTitleCase(fullName);
 
            WriteLine($"Hello {formattedName}, welcome to Robertson College!\n" +
                      $"Your new email address is {emailAddress}");


        }

    }
}
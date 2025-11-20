using System;

namespace email_generator;

internal class Utility
{
    /// <summary> Prompts user for string input and validates it's not empty/whitespace</summary>
    /// <param name="prompt">The display prompt for the user</param>
    /// <returns>Validated non-empty string input</returns>
    public static string GetStringInput(string prompt)
    {
        while (true)
        {
            Write($"{prompt}\t\t\t: ");
            string userInput = ReadLine();

            if (userInput.Trim().Length > 0) return userInput;

            WriteLine("Error: Unable to process an empty string.\n");
        }
    }

    /// <summary>Prompts for and validates a 4-digit birth year</summary>
    /// <returns>Validated birth year as integer</returns>
    /// <remarks>Continuously prompts until valid 4-digit input received</remarks>
    public static int GetBirthYear()
    {
        while (true)
        {
            Write("Input your Year of Birth (4 digits) \t: ");
            string birthYearInput = ReadLine();

            if (birthYearInput.Length == 4 && birthYearInput.All(char.IsDigit))
                return int.Parse(birthYearInput);

            WriteLine("Error: Year of birth must be a 4-digit numeric value (e.g., 1998).\n");
        }
    }

    /// <summary>Displays formatted welcome message with user's generated email address</summary>
    /// <param name="firstName">User's first name</param>
    /// <param name="lastName">User's last name</param>
    /// <param name="emailAddress">Generated email address</param>
    public static void PrintMessage(string firstName, string lastName, string emailAddress)
    {
        string fullName = $"{firstName} {lastName}";
        string formattedName = CurrentCulture.TextInfo.ToTitleCase(fullName);

        WriteLine($"Hello {formattedName}, welcome to Robertson College!\n" +
                  $"Your new email address is {emailAddress}");
    }
}
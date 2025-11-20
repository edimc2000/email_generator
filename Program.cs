namespace email_generator;

/// <summary> Main Program for the email generator </summary>
/// /// <remarks>
/// <para>Author: Eddie C.</para>
/// <para>Version: 1.0</para>
/// <para>Since: 2025-11-16</para>
/// </remarks>
internal class Program
{
    private static void Main(string[] args)
    {
        // Initialize new user with validated inputs
        User person = new()
        {
            Suffix = "@robertsoncollege.ca",
            FirstName = Utility.GetStringInput("Input your First Name"),
            LastName = Utility.GetStringInput("Input your Last Name"),
            BirthYear = Utility.GetBirthYear()
        };

        // Display some message using the inputs 
        Utility.PrintMessage(person.FirstName, person.LastName, person.Email);
    }
}
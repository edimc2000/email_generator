namespace email_generator;

/// <summary>
/// Represents a user with personal information and email generation
/// Email format: [First letter of first name][Last name][Year of birth]@domain
/// </summary>
/// /// <remarks>
/// <para>Author: Eddie C.</para>
/// <para>Version: 1.0</para>
/// <para>Since: 2025-11-18</para>
/// </remarks>
internal class User
{
    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public int? BirthYear { get; set; }

    /// <summary> Generated email in format: firstInitial + lastName + birthYear + suffix</summary>
    public string Email => $"{FirstName[0]}{LastName}{BirthYear}{Suffix}".ToLower();

    public string? Suffix { get; set; }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace email_generator;

internal class User
{
    public string? FirstName { get; set; }

    public string? LastName { get; set; }
    
    public int? BirthYear { get; set; }
    
    public string Email => $"{FirstName[0]}{LastName}{BirthYear}@{Suffix}".ToLower();
    
    public string? Suffix { get; set; }
}
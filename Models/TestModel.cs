namespace Models;

public class TestModel
{
    public string? FirstName { get; set; }
    
    public string? LastName { get; set; }

    public string? FullName => $"{FirstName} {LastName}".Trim();
}
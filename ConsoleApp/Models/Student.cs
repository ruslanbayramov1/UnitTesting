namespace ConsoleApp.Models;

public class Student
{
    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
    public string Surname { get; set; } = default!;
    public string GroupCode { get; set; } = default!;
}

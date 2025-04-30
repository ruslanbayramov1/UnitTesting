using ConsoleApp.Models;
using ConsoleApp.Services.Interfaces;

namespace ConsoleApp.Services.Implements;

public class OperationService : IOperationService
{
    private readonly List<Student> _list = [ new Student()
        {
            Id = Guid.Parse("3f2504e0-4f89-11d3-9a0c-0305e82c3301"),
            GroupCode = "CX102",
            Name = "Willie",
            Surname = "Fox"
        }];

    public int SumArr(int[] nums)
    {
        if (nums.Length > 10)
            throw new Exception($"The length is greater than 10, its {nums.Length}");

        int sum = 0;
        foreach (int i in nums)
            sum += i;

        return sum;
    }

    public DateTime GetCurrentDate()
        => DateTime.Now;

    public object? GetObjectById(Guid id)
        => _list.FirstOrDefault(x => x.Id == id);
}

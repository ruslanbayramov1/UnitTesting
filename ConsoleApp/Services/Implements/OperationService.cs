using ConsoleApp.Services.Interfaces;

namespace ConsoleApp.Services.Implements;

public class OperationService : IOperationService
{
    public int SumArr(int[] nums)
    {
        if (nums.Length > 10)
            throw new Exception($"The length is greater than 10, its {nums.Length}");

        int sum = 0;
        foreach (int i in nums)
            sum += i;

        return sum;
    }
}

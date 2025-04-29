namespace ConsoleApp.Utils;

public class Operation
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

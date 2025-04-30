namespace ConsoleApp.Services.Interfaces;

public interface IOperationService
{
    int SumArr(int[] nums);
    DateTime GetCurrentDate();
    object? GetObjectById(Guid id);
}

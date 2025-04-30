using ConsoleApp.Services.Interfaces;
using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApp.Tests.ServicesTests;

public class OperationServiceTests
{
    private readonly IOperationService _operationService;
    public OperationServiceTests()
    {
        var provider = ServiceRegistration.Configure();
        _operationService = provider.GetRequiredService<IOperationService>();
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4 ,5}, 15)]
    [InlineData(new int[] { 1, 5, 3, 4 ,7}, 20)]
    public void OperationService_SumArr_LengthLessThan10_ReturnsSumIntAsExpected(int[] arr, int expected)
    {
        //Arrange

        //Act
        var res = _operationService.SumArr(arr);

        //Assert
        res.Should().Be(expected);
    }

    [Fact]
    public void OperationService_SumArr_LengthGreaterThan10_ThrowsException()
    {
        //Arrange
        int[] arr = Enumerable.Range(1, 11).ToArray();

        //Act
        Action act = () => _operationService.SumArr(arr);

        //Assert
        act.Should().Throw<Exception>();
    }
}

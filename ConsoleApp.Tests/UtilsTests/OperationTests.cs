using ConsoleApp.Utils;
using FluentAssertions;

namespace ConsoleApp.Tests.UtilsTests;

public class OperationTests
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4 ,5}, 15)]
    [InlineData(new int[] { 1, 5, 3, 4 ,7}, 20)]
    public void Operation_SumArr_LengthLessThan10_ReturnsSumIntAsExpected(int[] arr, int expected)
    {
        //Arrange
        Operation operation = new();

        //Act
        var res = operation.SumArr(arr);

        //Assert
        res.Should().Be(expected);
    }

    [Fact]
    public void Operation_SumArr_LengthGreaterThan10_ThrowsException()
    {
        //Arrange
        int[] arr = Enumerable.Range(1, 11).ToArray();
        Operation operation = new();

        //Act
        Action act = () => operation.SumArr(arr);

        //Assert
        act.Should().Throw<Exception>();
    }
}

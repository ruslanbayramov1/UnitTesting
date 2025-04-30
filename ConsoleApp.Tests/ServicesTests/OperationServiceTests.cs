using ConsoleApp.Models;
using ConsoleApp.Services.Interfaces;
using FluentAssertions;
using FluentAssertions.Extensions;
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

    [Fact]
    public void OperationService_GetCurrentDate_IsTrueValue_ReturnsDate()
    { 
        //Arrange
        var testDate = 1.January(2025);

        //Act
        var date = _operationService.GetCurrentDate();

        //Assert
        date.Should().BeAfter(testDate);
    }

    [Fact]
    public void OperationService_GetStudent_IsValidData_ReturnsStudent()
    {
        //Arrange

        //Act
        var student = _operationService.GetObjectById(Guid.Parse("3f2504e0-4f89-11d3-9a0c-0305e82c3301")) as Student;

        //Assert
        student.Should().NotBeNull();
        student.Should().BeOfType<Student>();
        student.Name.Should().NotBeNullOrWhiteSpace();
        student.Surname.Should().NotBeNullOrWhiteSpace();
        student.GroupCode.Should().NotBeNullOrWhiteSpace();
        student.Id.Should().NotBe("00000000-0000-0000-0000-000000000000");
    }
}

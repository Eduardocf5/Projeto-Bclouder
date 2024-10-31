// Controllers/PersonControllerTests.cs
using Xunit;
using Microsoft.AspNetCore.Mvc;
using Moq;

public class PersonControllerTests
{
    private readonly Mock<ITaskManagerContext> _mockContext;
    private readonly PersonController _controller;

    public PersonControllerTests()
    {
        _mockContext = new Mock<ITaskManagerContext>();
        _controller = new PersonController(_mockContext.Object);
    }

    [Fact]
    public async Task GetPeople_ReturnsOkResult()
    {
        // Arrange
        // Mock data setup

        // Act
        var result = await _controller.GetPeople();

        // Assert
        var okResult = Assert.IsType<OkObjectResult>(result);
        // Further assertions
    }
}

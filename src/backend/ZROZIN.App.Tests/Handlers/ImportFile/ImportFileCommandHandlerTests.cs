using FluentAssertions;
using ZROZIN.App.Handlers.ImportFile;

namespace ZROZIN.App.Tests.Handlers.ImportFile;

public class ImportFileCommandHandlerTests
{
    [Fact]
    public async Task Handle_ShouldReturnSuccess()
    {
        // Arrange
        var sut = new ImportFileCommandHandler();

        // Act
        var result = await sut.Handle(new ImportFileCommand("file"), CancellationToken.None);

        // Assert
        result.IsSuccess.Should().BeTrue();
    }
}
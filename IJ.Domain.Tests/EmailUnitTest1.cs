using FluentAssertions;
using Xunit;
using Moq;
using IJ.Domain.Entities.ValueObjects;
using IJ.Domain.Interfaces.Usuarios;
using IJ.Domain.Validation.ValueObjects;

namespace IJ.Domain.Tests;

public class EmailUnitTest1
{
    
    private Mock<IEmailRepository> _emailRepositoryMock;
    private Mock<EmailValidation> _emailValidationMock;

    public EmailUnitTest1()
    {
        _emailRepositoryMock = new Mock<IEmailRepository>();
        _emailValidationMock = new Mock<EmailValidation>();
    }

    [Fact]
    public void Constructor_WithValidEmail_ValidatesAndSetsProperties()
    {
        // Arrange
        var emailId = Guid.NewGuid();
        var email = new Email();
        email.IdEmail = emailId;
        email.Email = "test@example.com";

        _emailValidationMock.Setup(ev => ev.Validate(It.IsAny<Email>()))
            .Returns(new ValidationResult());

        // Act
        var emailInstance = new Email(_emailRepositoryMock.Object, _emailValidationMock.Object);

        // Assert
        emailInstance.Should().NotBeNull();
        emailInstance.Email.Should().Be(email.Email);
        emailInstance.IdEmailRepository.Should().Be(emailId);
    }

    [Fact]
    public void Constructor_WithInvalidEmail_FailsValidation()
    {
        // Arrange
        var email = new Email
        {
            Email = "invalid_email"
        };

        var validationResult = new ValidationResult();
        validationResult.Errors.Add("Email is invalid.");

        _emailValidationMock.Setup(ev => ev.Validate(It.IsAny<Email>()))
            .Returns(validationResult);

        // Act
        var emailInstance = new Email(_emailRepositoryMock.Object, _emailValidationMock.Object);

        // Assert
        emailInstance.Should().BeNull();
    }
}

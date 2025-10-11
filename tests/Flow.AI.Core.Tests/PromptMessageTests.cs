using System;
using Flow.AI.Core.Models;
using Xunit;

namespace Flow.AI.Core.Tests.Models
{
    public class PromptMessageTests
    {
        [Fact]
        public void Constructor_ShouldInitializeWithEmptyValues()
        {
            // Act
            var message = new PromptMessage();

            // Assert
            Assert.Equal(string.Empty, message.Role);
            Assert.Equal(string.Empty, message.Content);
        }

        [Fact]
        public void Properties_ShouldBeSettableAndRetrievable()
        {
            // Arrange
            var msg = new PromptMessage
            {
                Role = "user",
                Content = "Hello, world!"
            };

            // Assert
            Assert.Equal("user", msg.Role);
            Assert.Equal("Hello, world!", msg.Content);
        }
    }
}

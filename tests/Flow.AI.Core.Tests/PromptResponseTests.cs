using Flow.AI.Core.Models;

namespace Flow.AI.Core.Tests.Models
{
    public class PromptResponseTests
    {
        [Fact]
        public void Constructor_ShouldInitializeDefaults()
        {
            // Act
            var response = new PromptResponse();

            // Assert
            Assert.Equal(string.Empty, response.Content);
            Assert.Equal(string.Empty, response.ModelId);
            Assert.True(response.TimestampUtc <= DateTime.UtcNow);
        }

        [Fact]
        public void Properties_ShouldBeSettableAndRetrievable()
        {
            // Arrange
            var timestamp = new DateTime(2025, 1, 1, 12, 0, 0, DateTimeKind.Utc);
            var response = new PromptResponse
            {
                Content = "Response text",
                ModelId = "gpt-4o-mini",
                TotalTokens = 123,
                TimestampUtc = timestamp
            };

            // Assert
            Assert.Equal("Response text", response.Content);
            Assert.Equal("gpt-4o-mini", response.ModelId);
            Assert.Equal(123, response.TotalTokens);
            Assert.Equal(timestamp, response.TimestampUtc);
        }
    }
}


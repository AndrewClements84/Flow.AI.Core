using Flow.AI.Core.Models;

namespace Flow.AI.Core.Tests
{
    public class TokenFlowSummaryTests
    {
        [Fact]
        public void TokenFlowSummary_ShouldSetAndReturnPropertiesCorrectly()
        {
            // Arrange
            var now = DateTime.UtcNow;
            var summary = new TokenFlowSummary
            {
                TotalTokens = 123,
                PromptTokens = 45,
                CompletionTokens = 78,
                EstimatedCost = 0.0123m,
                TimestampUtc = now
            };

            // Act & Assert
            Assert.Equal(123, summary.TotalTokens);
            Assert.Equal(45, summary.PromptTokens);
            Assert.Equal(78, summary.CompletionTokens);
            Assert.Equal(0.0123m, summary.EstimatedCost);
            Assert.Equal(now, summary.TimestampUtc);
        }

        [Fact]
        public void TokenFlowSummary_ShouldHaveDefaultTimestamp()
        {
            // Act
            var summary = new TokenFlowSummary();

            // Assert
            Assert.True(summary.TimestampUtc <= DateTime.UtcNow);
        }
    }
}

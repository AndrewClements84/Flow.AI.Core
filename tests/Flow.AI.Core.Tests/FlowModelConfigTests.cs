using Flow.AI.Core.Models;

namespace Flow.AI.Core.Tests
{
    public class FlowModelConfigTests
    {
        [Fact]
        public void FlowModelConfig_ShouldInitializeAndSetPropertiesCorrectly()
        {
            // Arrange
            var config = new FlowModelConfig
            {
                Id = "test-model",
                Provider = "OpenAI",
                ModelName = "gpt-4o-mini",
                TokenLimit = 4096,
                Notes = "Test configuration"
            };

            // Act & Assert
            Assert.Equal("test-model", config.Id);
            Assert.Equal("OpenAI", config.Provider);
            Assert.Equal("gpt-4o-mini", config.ModelName);
            Assert.Equal(4096, config.TokenLimit);
            Assert.Equal("Test configuration", config.Notes);
        }
    }
}

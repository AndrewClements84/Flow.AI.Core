using Flow.AI.Core.Interfaces;
using Xunit;

namespace Flow.AI.Core.Tests
{
    public class FlowProviderContractTests
    {
        private class DummyTokenFlowProvider : ITokenFlowProvider
        {
            public int CountTokens(string modelId, string text)
            {
                // A very simple placeholder: count tokens by splitting on whitespace.
                return string.IsNullOrWhiteSpace(text)
                    ? 0
                    : text.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
            }
        }

        [Fact]
        public void CountTokens_ShouldReturnPositive_WhenTextProvided()
        {
            var provider = new DummyTokenFlowProvider();
            var count = provider.CountTokens("dummy-model", "Hello world from Flow.AI!");
            Assert.True(count > 0);
        }

        [Fact]
        public void CountTokens_ShouldReturnZero_WhenEmpty()
        {
            var provider = new DummyTokenFlowProvider();
            var count = provider.CountTokens("dummy-model", "");
            Assert.Equal(0, count);
        }
    }
}

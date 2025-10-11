using Flow.AI.Core.Models;

namespace Flow.AI.Core.Tests
{
    public class PromptInstanceTests
    {
        [Fact]
        public void Constructor_ShouldInitializeDefaultValues()
        {
            // Act
            var instance = new PromptInstance();

            // Assert
            Assert.NotNull(instance.Template);
            Assert.NotNull(instance.Variables);
            Assert.Empty(instance.Variables);
            Assert.Equal(string.Empty, instance.RenderedText);
            Assert.True(instance.CreatedUtc <= DateTime.UtcNow);
        }

        [Fact]
        public void Properties_ShouldBeSettableAndRetrievable()
        {
            // Arrange
            var template = new PromptTemplate { Template = "Hello {{name}}" };
            var variables = new Dictionary<string, string> { ["name"] = "Andrew" };
            var rendered = "Hello Andrew";
            var timestamp = new DateTime(2025, 1, 1, 12, 0, 0, DateTimeKind.Utc);

            // Act
            var instance = new PromptInstance
            {
                Template = template,
                Variables = variables,
                RenderedText = rendered,
                CreatedUtc = timestamp
            };

            // Assert
            Assert.Equal(template, instance.Template);
            Assert.Same(variables, instance.Variables);
            Assert.Equal(rendered, instance.RenderedText);
            Assert.Equal(timestamp, instance.CreatedUtc);
        }

        [Fact]
        public void Constructor_ShouldAssignNewTemplateInstance()
        {
            // Act
            var instance1 = new PromptInstance();
            var instance2 = new PromptInstance();

            // Assert – ensure each instance has its own PromptTemplate
            Assert.NotSame(instance1.Template, instance2.Template);
            Assert.NotNull(instance1.Template.Id);
        }
    }
}


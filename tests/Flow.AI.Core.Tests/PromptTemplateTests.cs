using Flow.AI.Core.Models;

namespace Flow.AI.Core.Tests.Models
{
    public class PromptTemplateTests
    {
        [Fact]
        public void Constructor_ShouldInitializeDefaults()
        {
            // Act
            var template = new PromptTemplate();

            // Assert
            Assert.False(string.IsNullOrEmpty(template.Id));
            Assert.Equal(string.Empty, template.Template);
            Assert.NotNull(template.RequiredVariables);
            Assert.Empty(template.RequiredVariables);
        }

        [Fact]
        public void Properties_ShouldBeSettableAndRetrievable()
        {
            // Arrange
            var id = Guid.NewGuid().ToString();
            var vars = new List<string> { "name", "topic" };
            var template = new PromptTemplate
            {
                Id = id,
                Template = "Hello {{name}} about {{topic}}",
                RequiredVariables = vars
            };

            // Assert
            Assert.Equal(id, template.Id);
            Assert.Equal("Hello {{name}} about {{topic}}", template.Template);
            Assert.Same(vars, template.RequiredVariables);
            Assert.Equal(2, template.RequiredVariables.Count);
        }
    }
}


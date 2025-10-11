using System;

namespace Flow.AI.Core.Models
{
    /// <summary>
    /// Represents a standardized model response returned after generation.
    /// </summary>
    public class PromptResponse
    {
        public string Content { get; set; }
        public string ModelId { get; set; }
        public int TotalTokens { get; set; }
        public DateTime TimestampUtc { get; set; }

        public PromptResponse()
        {
            Content = string.Empty;
            ModelId = string.Empty;
            TimestampUtc = DateTime.UtcNow;
        }
    }
}


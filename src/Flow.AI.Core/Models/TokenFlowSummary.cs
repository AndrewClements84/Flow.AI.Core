namespace Flow.AI.Core.Models
{
    /// <summary>
    /// Represents summarized token-level statistics for a model interaction.
    /// (Reserved for use in PromptFlow.AI or higher layers.)
    /// </summary>
    public class TokenFlowSummary
    {
        public int TotalTokens { get; set; }
        public int PromptTokens { get; set; }
        public int CompletionTokens { get; set; }
        public decimal EstimatedCost { get; set; }
        public DateTime TimestampUtc { get; set; } = DateTime.UtcNow;
    }
}
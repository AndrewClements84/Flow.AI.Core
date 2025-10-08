namespace Flow.AI.Core.Interfaces
{
    /// <summary>
    /// Defines a contract for components capable of counting tokens
    /// for a given model and input text.
    /// </summary>
    public interface ITokenFlowProvider
    {
        /// <summary>
        /// Counts the number of tokens used by the specified model for a given text input.
        /// </summary>
        /// <param name="modelId">The model identifier (e.g., gpt-4o-mini, claude-3-opus).</param>
        /// <param name="text">The input text to analyze.</param>
        /// <returns>The total token count for the input.</returns>
        int CountTokens(string modelId, string text);
    }
}


using System.Threading.Tasks;
using Flow.AI.Core.Models;

namespace Flow.AI.Core.Interfaces
{
    /// <summary>
    /// Defines a contract for model clients that can generate text responses.
    /// </summary>
    public interface IModelClient
    {
        /// <summary>
        /// Generates a model response for the given prompt.
        /// </summary>
        Task<PromptResponse> GenerateAsync(string prompt);
    }
}


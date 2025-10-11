using System.Collections.Generic;
using Flow.AI.Core.Models;

namespace Flow.AI.Core.Interfaces
{
    /// <summary>
    /// Defines a contract for managing prompt conversation history.
    /// </summary>
    public interface IPromptContextManager
    {
        IReadOnlyList<PromptMessage> Messages { get; }
        void AddMessage(string role, string content);
        void Clear();
    }
}


using System;
using System.Collections.Generic;

namespace Flow.AI.Core.Models
{
    /// <summary>
    /// Represents a fully rendered prompt derived from a template and variables.
    /// </summary>
    public class PromptInstance
    {
        public PromptTemplate Template { get; set; }
        public IReadOnlyDictionary<string, string> Variables { get; set; }
        public string RenderedText { get; set; }
        public DateTime CreatedUtc { get; set; }

        public PromptInstance()
        {
            Template = new PromptTemplate();
            Variables = new Dictionary<string, string>();
            RenderedText = string.Empty;
            CreatedUtc = DateTime.UtcNow;
        }
    }
}


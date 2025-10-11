using System;
using System.Collections.Generic;

namespace Flow.AI.Core.Models
{
    /// <summary>
    /// Defines a reusable prompt template used for structured text generation.
    /// </summary>
    public class PromptTemplate
    {
        public string Id { get; set; }
        public string Template { get; set; }
        public List<string> RequiredVariables { get; set; }

        public PromptTemplate()
        {
            Id = Guid.NewGuid().ToString();
            Template = string.Empty;
            RequiredVariables = new List<string>();
        }
    }
}
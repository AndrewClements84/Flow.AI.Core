namespace Flow.AI.Core.Models
{
    public class PromptMessage
    {
        public string Role { get; set; }
        public string Content { get; set; }

        public PromptMessage()
        {
            Role = string.Empty;
            Content = string.Empty;
        }
    }
}


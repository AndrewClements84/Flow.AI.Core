namespace Flow.AI.Core.Models
{
    /// <summary>
    /// Represents shared model configuration metadata used across Flow components.
    /// (Not yet consumed by TokenFlow.AI but retained for future compatibility.)
    /// </summary>
    public class FlowModelConfig
    {
        public string Id { get; set; } = string.Empty;
        public string Provider { get; set; } = string.Empty;
        public string ModelName { get; set; } = string.Empty;
        public int TokenLimit { get; set; }
        public string Notes { get; set; }
    }
}
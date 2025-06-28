namespace ProjectAI.Models
{
    public class ChatMessage
    {
        public string Id { get; set; }
        public string Role { get; set; } // "user", "assistant", or "system"
        public string Content { get; set; }

        public ChatMessage()
        {
            Id = Guid.NewGuid().ToString(); // Generate a unique ID by default
        }
    }
}

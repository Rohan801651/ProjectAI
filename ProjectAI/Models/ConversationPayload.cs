using System.Collections.Generic;

namespace ProjectAI.Models
{
    public class ConversationPayload
    {
        // Represents the messages array from the client-side state
        public List<ChatMessage> HistoryMessages { get; set; }

        // Represents the new text input by the user
        public string NewUserMessageContent { get; set; }

        public ConversationPayload()
        {
            HistoryMessages = new List<ChatMessage>();
        }
    }
}

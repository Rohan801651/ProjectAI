using System.Collections.Generic;

namespace ProjectAI.Models
{
    public class InitialChatViewModel
    {
        public ChatMessage InitialAssistantMessage { get; set; }

        public InitialChatViewModel(ChatMessage initialAssistantMessage)
        {
            InitialAssistantMessage = initialAssistantMessage;
        }
    }
}

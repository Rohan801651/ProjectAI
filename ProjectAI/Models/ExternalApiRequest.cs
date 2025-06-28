using System.Collections.Generic;

namespace ProjectAI.Models
{
    public class ExternalApiRequest
    {
        public List<ApiMessage> Messages { get; set; }

        public ExternalApiRequest()
        {
            Messages = new List<ApiMessage>();
        }
    }
}

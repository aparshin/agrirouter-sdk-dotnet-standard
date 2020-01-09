using System.Collections.Generic;
using com.dke.data.agrirouter.api.dto.onboard;

namespace com.dke.data.agrirouter.api.service.parameters
{
    /**
     * Parameter container definition.
     */
    public class MessagingParameters : SendMessageParameters
    {
        public List<string> EncodedMessages { get; set; }
    }
}
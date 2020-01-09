using Agrirouter.Request.Payload.Account;
using com.dke.data.agrirouter.api.dto.onboard;

namespace com.dke.data.agrirouter.api.service.parameters
{
    /**
     * Parameter container definition.
     */
    public class ListEndpointsParameters : SendMessageParameters
    {
        
        public ListEndpointsQuery.Types.Direction Direction { get; set; }
        
        public string TechnicalMessageType { get; set; }
    }
}
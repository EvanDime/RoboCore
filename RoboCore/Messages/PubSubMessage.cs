using System.Collections.Generic;

namespace RoboCore.Messages
{
    public class PubSubMessage : IWrappedMessage
    {
        public string Payload { get; set; }
        public string DataIntegrityValues { get; set; }
    }
}
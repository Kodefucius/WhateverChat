using System.Runtime.Serialization;

namespace WhateverChatService
{
    [DataContract]
    public class WhateverChatClient
    {
        [DataMember]
        public string Id { get; set; }
        [DataMember]
        public WhateverChatClientState State { get; set; }
    }
}
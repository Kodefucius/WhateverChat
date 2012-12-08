using System.Runtime.Serialization;

namespace WhateverChatService
{
    [DataContract]
    public class Conversation
    {
        [DataMember]
        public string FromId { get; set; }
        [DataMember]
        public string ToId { get; set; }
    }
}
using System;

namespace ApplicationCore.Entities
{
    public class Message : BaseEntity
    {
        public int MessageTypeId { get; set; }
        public MessageType MessageType { get; set; }
        public int RecipientTypeId { get; set; }
        public RecipientType RecipientType { get; set; }
        public DateTime SendDate { get; set; }
        public string UserId { get; set; }
    }
}
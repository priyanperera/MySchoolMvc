using System;

namespace ApplicationCore.Entities
{
    public class Event : BaseEntity
    {
        public int EventTypeId { get; set; }
        public EventType EventType { get; set; }
        public DateTime EventDate { get; set; }
    }
}
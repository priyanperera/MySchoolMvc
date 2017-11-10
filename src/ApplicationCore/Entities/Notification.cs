namespace ApplicationCore.Entities
{
    public class Notification : BaseEntity
    {
        public int NotificationTypeId { get; set; }
        public NotificationType NotificationType { get; set; }
        public string UserId { get; set; }
    }
}
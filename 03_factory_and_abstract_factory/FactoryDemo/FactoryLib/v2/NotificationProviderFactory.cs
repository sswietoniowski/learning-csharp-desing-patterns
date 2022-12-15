namespace FactoryLib.v2
{
    public static class NotificationProviderFactory
    {
        public static INotificationProvider Create(NotificationType notificationType) =>
            notificationType switch
            {
                NotificationType.Email => new EmailProvider(),
                NotificationType.SMS => new SmsProvider(),
                _ => throw new ArgumentException("Invalid notification type")
            };
    }
}

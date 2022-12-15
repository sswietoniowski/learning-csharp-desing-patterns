namespace FactoryLib.v2;

public static class NotificationProviderFactory
{
    public static INotificationProvider CreateProvider(NotificationType notificationType) =>
        notificationType switch
        {
            NotificationType.Email => new EmailNotificationProvider(),
            NotificationType.SMS => new SmsNotificationProvider(),
            _ => throw new ArgumentException("Invalid notification type")
        };
}
namespace FactoryLib.v3;

public class EmailNotificationProviderFactory : NotificationProviderFactory
{
    public override INotificationProvider CreateProvider() => new EmailProvider();
}
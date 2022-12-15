namespace FactoryLib.v3
{
    public class EmailNotificationProviderFactory : NotificationProviderFactory
    {
        public override INotificationProvider Create() => new EmailProvider();
    }
}

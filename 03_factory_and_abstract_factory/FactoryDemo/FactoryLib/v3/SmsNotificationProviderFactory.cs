namespace FactoryLib.v3
{
    public class SmsNotificationProviderFactory : NotificationProviderFactory
    {
        public override INotificationProvider CreateProvider() => new SmsProvider();
    }
}

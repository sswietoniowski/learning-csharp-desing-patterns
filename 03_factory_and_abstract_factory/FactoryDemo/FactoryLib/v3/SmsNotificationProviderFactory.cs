namespace FactoryLib.v3
{
    public class SmsNotificationProviderFactory : NotificationProviderFactory
    {
        public override INotificationProvider Create() => new SmsProvider();
    }
}

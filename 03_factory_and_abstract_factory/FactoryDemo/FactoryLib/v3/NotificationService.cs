namespace FactoryLib.v3;

public class NotificationService
{
    private readonly Dictionary<NotificationType, NotificationProviderFactory> _factories;

    private List<User> _users = new();

    public NotificationService()
    {
        _factories = new();

        foreach (NotificationType type in Enum.GetValues(typeof(NotificationType)))
        {
            var factory = (NotificationProviderFactory)Activator.CreateInstance(
                Type.GetType($"FactoryLib.v3.{type}NotificationProviderFactory") ?? throw new InvalidOperationException())!;

            _factories.Add(type, factory);
        }
    }

    private INotificationProvider CreateProvider(NotificationType notificationType) =>
        _factories[notificationType].CreateProvider();

    public void AddUser(User user)
    {
        _users.Add(user);
    }

    public void Notify(string message)
    {
        foreach (var user in _users)
        {
            var provider = CreateProvider(user.NotificationType);
            provider.Send(user, message);
        }
    }
}
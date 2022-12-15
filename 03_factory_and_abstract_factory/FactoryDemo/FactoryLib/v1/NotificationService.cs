namespace FactoryLib.v1;

public class NotificationService
{
    private List<User> _users = new();

    public void AddUser(User user)
    {
        _users.Add(user);
    }

    public void Notify(string message)
    {
        foreach (var user in _users)
        {
            if (user.NotificationType == NotificationType.Email)
            {
                var emailProvider = new EmailProvider();
                emailProvider.Send(user, message);
            }
            else if (user.NotificationType == NotificationType.SMS)
            {
                var smsProvider = new SmsProvider();
                smsProvider.Send(user, message);
            }
            else
            {
                throw new Exception("Unknown notification type");
            }
        }
    }
}
namespace FactoryLib.v2;

public interface INotificationProvider
{
    void Send(User user, string message);
}
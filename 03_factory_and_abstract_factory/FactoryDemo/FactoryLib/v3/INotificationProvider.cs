namespace FactoryLib.v3;

public interface INotificationProvider
{
    void Send(User user, string message);
}
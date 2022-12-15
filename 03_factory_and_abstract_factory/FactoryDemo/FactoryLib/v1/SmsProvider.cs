namespace FactoryLib.v1;

public class SmsProvider
{
    public void Send(User user, string message)
    {
        Console.WriteLine($"To {user.Name} was sent an SMS to phone number {user.PhoneNumber} with the message: {message}");
    }
}
namespace FactoryLib.v1;

public class EmailProvider
{
    public void Send(User user, string message)
    {
        Console.WriteLine($"To {user.Name} was sent an email to address {user.Email} with the message: {message}");
    }
}
namespace FactoryLib.v3
{
    public class EmailProvider : INotificationProvider
    {
        public void Send(User user, string message)
        {
            Console.WriteLine($"To {user.Name} was sent an email to address {user.Email} with the message: {message}");
        }
    }
}

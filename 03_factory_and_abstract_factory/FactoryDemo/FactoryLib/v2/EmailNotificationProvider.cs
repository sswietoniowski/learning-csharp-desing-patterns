namespace FactoryLib.v2
{
    public class EmailNotificationProvider : INotificationProvider
    {
        public void Send(User user, string message)
        {
            Console.WriteLine($"To {user.Name} was sent an email to address {user.Email} with the message: {message}");
        }
    }
}

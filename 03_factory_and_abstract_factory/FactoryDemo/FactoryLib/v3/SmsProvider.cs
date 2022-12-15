namespace FactoryLib.v3
{
    public class SmsProvider : INotificationProvider
    {
        public void Send(User user, string message)
        {
            Console.WriteLine($"To {user.Name} was sent an SMS to phone number {user.PhoneNumber} with the message: {message}");
        }
    }
}

namespace FactoryLib.v2
{
    public class SmsNotificationProvider : INotificationProvider
    {
        public void Send(User user, string message)
        {
            Console.WriteLine($"To {user.Name} was sent an SMS to phone number {user.PhoneNumber} with the message: {message}");
        }
    }
}

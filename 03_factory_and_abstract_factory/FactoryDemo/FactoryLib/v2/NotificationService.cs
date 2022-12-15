namespace FactoryLib.v2
{
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
                var provider = NotificationProviderFactory.CreateProvider(user.NotificationType);
                provider.Send(user, message);
            }
        }
    }
}

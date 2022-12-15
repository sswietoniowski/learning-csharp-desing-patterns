namespace FactoryLib.v2;

public class User
{
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public NotificationType NotificationType { get; set; } = NotificationType.Email;
}
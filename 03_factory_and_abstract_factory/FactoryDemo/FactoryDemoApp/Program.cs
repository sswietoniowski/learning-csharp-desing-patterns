// send notifications to users without a factory patterns

using v1 = FactoryLib.v1;
using v2 = FactoryLib.v2;
using v3 = FactoryLib.v2;

var user1 = new v1.User { Name = "John Doe", Email = "jdoe@unknown.com", PhoneNumber = "000-0000", NotificationType = v1.NotificationType.Email};
var user2 = new v1.User { Name = "Alice Fox", Email = "afox@unknown.com", PhoneNumber = "111-1111", NotificationType = v1.NotificationType.SMS };

var notificationServiceV1 = new v1.NotificationService();
notificationServiceV1.AddUser(user1);
notificationServiceV1.AddUser(user2);

notificationServiceV1.Notify("Hello World without factory pattern!");

// send notifications to users using simple factory pattern

var user3 = new v2.User { Name = "John Doe", Email = "jdoe@unknown.com", PhoneNumber = "000-0000", NotificationType = v2.NotificationType.Email };
var user4 = new v2.User { Name = "Alice Fox", Email = "afox@unknown.com", PhoneNumber = "111-1111", NotificationType = v2.NotificationType.SMS };

var notificationServiceV2 = new v2.NotificationService();
notificationServiceV2.AddUser(user3);
notificationServiceV2.AddUser(user4);

notificationServiceV2.Notify("Hello world with simple factory pattern!");

// send notifications to users using factory method pattern

var user5 = new v3.User { Name = "John Doe", Email = "jdoe@unknown.com", PhoneNumber = "000-0000", NotificationType = v2.NotificationType.Email };
var user6 = new v3.User { Name = "Alice Fox", Email = "afox@unknown.com", PhoneNumber = "111-1111", NotificationType = v2.NotificationType.SMS };

var notificationServiceV3 = new v3.NotificationService();
notificationServiceV3.AddUser(user5);
notificationServiceV3.AddUser(user6);

notificationServiceV3.Notify("Hello world with factory method pattern!");

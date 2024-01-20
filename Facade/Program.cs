// See https://aka.ms/new-console-template for more information

using Facade;
using Facade.Email;

INotificationSender notificationSender = NotificationSender.GetInstance();

var emailMessage = new EmailMessageBuilder()
    .SetFrom("example@mail.ru")
    .SetTo("examole2@mai;.ru")
    .SetSubject("test")
    .SetData("Test")
    .Build();

notificationSender.EmailNotification(emailMessage);
notificationSender.SmsNotification("+7432432423", "test");
// See https://aka.ms/new-console-template for more information

using Facade;

INotificationSender notificationSender = new NotificationSender();

notificationSender.EmailNotification("example@mail.com", "test");
notificationSender.SmsNotification("+7432432423", "test");
using Facade.Email;

namespace Facade;

public interface INotificationSender
{
    public string SmsNotification(string to, string data);

    public string EmailNotification(EmailMessage message);

    public string PushNotification(string to, string data);
}
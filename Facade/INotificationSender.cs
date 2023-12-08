namespace Facade;

public interface INotificationSender
{
    public string SmsNotification(string to, string data);

    public string EmailNotification(string to, string data);

    public string PushNotification(string to, string data);
}
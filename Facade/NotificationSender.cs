using Facade.Email;
using Facade.Push;
using Facade.SMS;

namespace Facade;

public class NotificationSender:INotificationSender
{
    private static readonly NotificationSender Instance = new NotificationSender();
    public static NotificationSender GetInstance() => Instance;

    
    private EmailNotificationSender _emailNotificationSender = new();
    private SmsNotificationSender _smsNotificationSender = new();
    private PushNotificationSender _pushNotificationSender = new();


    public string SmsNotification(string to, string data)
    {
        var sms = _smsNotificationSender.CreateSmsMessage("deafult", to, data);
        try
        {
            _smsNotificationSender.SendSmsMessage(sms);
            return "SMS notification successful send";
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        
    }

    public string EmailNotification(EmailMessage message)
    {
        try
        {
           _emailNotificationSender.SendEmailMessage(message);
            return "email notification successful send";
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

    }

    public string PushNotification(string to, string data)
    {
        throw new NotImplementedException();
    }
}
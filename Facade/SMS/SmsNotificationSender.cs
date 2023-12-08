namespace Facade.SMS;

public class SmsNotificationSender
{
    public SmsMessage CreateSmsMessage(string from, string to, string data)
    {
        return new SmsMessage
        {
            FromNumber = from,
            ToNumber = to,
            Data = data 
        };
    }

    public void SendSmsMessage(SmsMessage smsMessage)
    {
        Console.WriteLine($"SMS Message from: {smsMessage.FromNumber}, To: {smsMessage.ToNumber}, Data {smsMessage.Data} was sended");
    }
}
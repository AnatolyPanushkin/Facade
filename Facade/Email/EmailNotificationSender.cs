namespace Facade.Email;

public class EmailNotificationSender
{
    public EmailMessage CreateEmailMessage(string from, string to, string data)
    {
        return new EmailMessage
        {
            FromEmailAddress = from,
            ToEmailAddress = to,
            Data = data
        };
    }

    public void SendEmailMessage(EmailMessage emailMessage)
    {
        Console.WriteLine($"Email Message from: {emailMessage.FromEmailAddress}, To: {emailMessage.ToEmailAddress}, Data {emailMessage.Data} was sended");
    }
    
}
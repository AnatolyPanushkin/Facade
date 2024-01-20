namespace Facade.Email;

public class EmailNotificationSender
{
    public void SendEmailMessage(EmailMessage emailMessage)
    {
        Console.WriteLine($"Email Message from: {emailMessage.FromEmailAddress}, To: {emailMessage.ToEmailAddress}, Data {emailMessage.Data} was sended");
    }
    
}
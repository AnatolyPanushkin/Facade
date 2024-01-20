namespace Facade.Email;

public class EmailMessage
{
    public string FromEmailAddress { get; set; }
    public string ToEmailAddress { get; set; }
    public string SubjectOfEmail { get; set; }
    public string Attachments { get; set; }
    public string Data { get; set; }
}
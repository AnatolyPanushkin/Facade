namespace Facade.Email;

public class EmailMessageBuilder
{
    private EmailMessage _emailMessage = new EmailMessage();

    public EmailMessage Build()
    {
        var result = _emailMessage;

        _emailMessage = new EmailMessage();

        return result;
    }

    public EmailMessageBuilder SetFrom(string from)
    {
        _emailMessage.FromEmailAddress = from;
        return this;
    }

    public EmailMessageBuilder SetTo(string to)
    {
        _emailMessage.ToEmailAddress = to;
        return this;
    }

    public EmailMessageBuilder SetSubject(string subject)
    {
        _emailMessage.SubjectOfEmail = subject;
        return this;
    }

    public EmailMessageBuilder SetAttachments(string attachments)
    {
        _emailMessage.Attachments = attachments;
        return this;
    }

    public EmailMessageBuilder SetData(string data)
    {
        _emailMessage.Data = data;
        return this;
    }
}
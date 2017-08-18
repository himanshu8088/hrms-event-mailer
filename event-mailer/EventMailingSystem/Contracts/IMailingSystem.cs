namespace EventMailingSystem
{
    public interface IMailingSystem
    {
        string To { get; set; }
        string From { get; set; }
        string Subject { get; set; }
        string Content { get; set; }

        void Send(string to,string from,string subject, string content);        
    }
}
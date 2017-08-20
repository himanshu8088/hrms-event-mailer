using System.IO;

namespace EventMailingSystem
{
    public interface IMail
    {
        string To { get; set; }
        string From { get; set; }
        string Subject { get; set; }
        string Msg { get; set; }
    }
}
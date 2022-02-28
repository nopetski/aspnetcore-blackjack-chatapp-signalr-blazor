namespace ChatApp.Shared
{
    public class ChatMessage
    {
        public string? User { get; set; }
        public string? Message { get; set; }
        public DateTime TS { get; set; }

        public ChatMessage() { }

        public ChatMessage(string? user, string? message, DateTime tS)
        {
            User = user;
            Message = message;
            TS = tS;
        }
    }
}

namespace VKTChat.Core.Models
{
    public class Message
    {
        public int IdMessage { get; set; }
        public User? User { get; set; }
        public Bot? Bot { get; set; }
        public string Text { get; set; }
        public DateTime SentDateTime { get; set; }
        public bool IsChanged { get; set; }
        public Image? Image { get; set; }
        private Message(User? fromUser, Bot? fromBot, string text)
        {
            User = fromUser;
            Bot = fromBot;
            Text = text;
            IsChanged = false;
            SentDateTime = DateTime.Now;
        }
        public static Message FromUser(User fromUser, string text)
        {
            return new Message(fromUser, null, text);
        }

        public static Message FromBot(Bot fromBot, string text)
        {
            return new Message(null, fromBot, text);
        }
    }
}

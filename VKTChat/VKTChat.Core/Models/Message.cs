using System;

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
        private Message(int idMessage, User? fromUser, Bot? fromBot, string text)
        {
            IdMessage = idMessage;
            User = fromUser;
            Bot = fromBot;
            Text = text;
            IsChanged = false;
            SentDateTime = DateTime.Now;
        }
        public static Message FromUser(int idMessage, User fromUser, string text)
        {
            return new Message(idMessage, fromUser, null, text);
        }

        public static Message FromBot(int idMessage, Bot fromBot, string text)
        {
            return new Message(idMessage, null, fromBot, text);
        }
    }
}

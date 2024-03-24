using System;

namespace VKTChat.Core.Models
{
    public class Message
    {
        public int IdMessage { get; set; }
        public User From { get; set; }
        public string Text { get; set; }
        public DateTime SentDateTime { get; set; }
#nullable enable
        public Image Image { get; set; }
#nullable disable
        public Message(int idMessage, User from, string text)
        {
            IdMessage = idMessage;
            From = from;
            Text = text;
            Image = null;
            SentDateTime = DateTime.Now;
        }
    }
}

using System;

namespace VKTChat.Core.Models
{
    public class Message
    {
        public int ID { get; set; }
        public User From { get; set; }
        public User To { get; set; }
        public string Text { get; set; }
        public DateTime SentDateTime { get; set; }
#nullable enable
        public Image Image { get; set; }
#nullable disable
        public Message(int id, User from, User to, string text)
        {
            ID = id;
            From = from;
            To = to;
            Text = text;
            Image = null;
            SentDateTime = DateTime.Now;
        }
    }
}

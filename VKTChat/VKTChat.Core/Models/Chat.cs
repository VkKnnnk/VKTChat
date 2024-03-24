using System;
using System.Collections.Generic;

namespace VKTChat.Core.Models
{
    public class Chat
    {
        public int IdChat { get; set; }
        public string Name { get; set; }
        public DateTime CreationDateTime { get; set; }
        public List<Message> Messages { get; set; }
        public Chat(int idChatid, string name)
        {
            IdChat = idChatid;
            Name = name;
            Messages = new List<Message>();
            CreationDateTime = DateTime.Now;
        }
    }
}

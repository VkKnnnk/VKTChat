using System;
using MvvmCross.ViewModels;

namespace VKTChat.Core.Models
{
    public class Chat
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public MvxObservableCollection<Message> Messages { get; set; }
        public User Owner { get; set; }
        public DateTime CreationDateTime { get; set; }
        public Chat(int id, string name, User owner)
        {
            ID = id;
            Name = name;
            Messages = new MvxObservableCollection<Message>();
            Owner = owner;
            CreationDateTime = DateTime.Now;
        }
    }
}

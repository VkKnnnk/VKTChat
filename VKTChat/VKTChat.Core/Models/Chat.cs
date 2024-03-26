namespace VKTChat.Core.Models
{
    public class Chat
    {
        public int IdChat { get; set; }
        public string Name { get; set; }
        public DateTime CreationDateTime { get; set; }
        public List<Message> Messages { get; set; }
        public Chat(string name)
        {
            Name = name;
            Messages = new List<Message>();
            CreationDateTime = DateTime.Now;
        }
    }
}

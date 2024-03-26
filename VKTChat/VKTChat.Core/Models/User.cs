namespace VKTChat.Core.Models
{
    public class User
    {
        public int IdUser { get; set; }
        public string UserName { get; set; }
        public string DisplayName { get; set; }
        public Image DefaultUserPhoto { get; set; }
        public List<Chat> Chats { get; set; }
#nullable enable
        public Image? UserPhoto { get; set; }
        public string? AboutMe { get; set; }
#nullable disable
        public User(string username, string displayname)
        {
            UserName = username;
            DisplayName = displayname;
            AboutMe = null;
            UserPhoto = null;
            DefaultUserPhoto = new Image("default_userphoto.png");
            Chats = new List<Chat>();
        }
    }
}

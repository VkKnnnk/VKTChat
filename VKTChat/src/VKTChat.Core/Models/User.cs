namespace VKTChat.Core.Models
{
    public class User
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string DisplayName { get; set; }
#nullable enable
        public Image? UserPhoto { get; set; }
        public string? AboutMe { get; set; }
#nullable disable
        public Image DefaultUserPhoto { get; set; }
        public User(int id, string username, string displayname)
        {
            ID = id;
            UserName = username;
            DisplayName = displayname;
            AboutMe = null;
            UserPhoto = null;
            DefaultUserPhoto = new Image("default_userphoto.png");
        }
    }
}

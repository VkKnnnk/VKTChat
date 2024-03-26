namespace VKTChat.Core.Models
{
    public class Bot
    {
        public int IdBot { get; set; }
        public string BotName { get; set; }
        public string DisplayName { get; set; }
        public Image DefaultBotPhoto { get; set; }
        public Bot(int idBot, string botName, string displayName)
        {
            IdBot = idBot;
            BotName = botName;
            DisplayName = displayName;
            DefaultBotPhoto = new Image("default_botphoto.png");
        }
    }
}

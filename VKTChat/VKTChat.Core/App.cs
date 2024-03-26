using MvvmCross;
using MvvmCross.ViewModels;
using VKTChat.Core.Services;
using VKTChat.Core.ViewModels;

namespace VKTChat.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            Mvx.IoCProvider?.RegisterType<IAppdataService, AppdataService>();
            Mvx.IoCProvider?.RegisterType<IMessageService, MessageService>();
            Mvx.IoCProvider?.RegisterType<IChatService, ChatService>();
            Mvx.IoCProvider?.RegisterType<IBotService, BotService>();
            RegisterAppStart<ChatsVM>();
        }
    }
}

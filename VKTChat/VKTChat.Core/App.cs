using MvvmCross;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VKTChat.Core.Services;
using VKTChat.Core.ViewModels;

namespace VKTChat.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            Mvx.IoCProvider.RegisterType<IMessageService, MessageService>();
            Mvx.IoCProvider.RegisterType<IChatService, ChatService>();
            Mvx.IoCProvider.RegisterType<IUserService, UserService>();
            Mvx.IoCProvider.RegisterType<IBotService, BotService>();
            RegisterAppStart<ChatsVM>();
        }
    }
}

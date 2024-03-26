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

            // Создание словаря для хранения именованных синглтонов
            var dataContexts = new Dictionary<string, IDataContext>();

            // Регистрация синглтонов и добавление их в словарь
            var userDataContext = new UserDataContext();
            Mvx.IoCProvider?.RegisterSingleton<IDataContext>(() => userDataContext);
            dataContexts["UserDataContext"] = userDataContext;

            var chatDataContext = new ChatDataContext();
            Mvx.IoCProvider?.RegisterSingleton<IDataContext>(() => chatDataContext);
            dataContexts["ChatDataContext"] = chatDataContext;

            Mvx.IoCProvider?.RegisterType<IUserService>(() => new UserService(
                Mvx.IoCProvider.Resolve<IAppdataService>()
            ));

            Mvx.IoCProvider?.RegisterType<IChatService>(() => new ChatService(
                dataContexts["UserDataContext"],
                Mvx.IoCProvider.Resolve<IAppdataService>()
            ));

            Mvx.IoCProvider?.RegisterType<IMessageService>(() => new MessageService(
                dataContexts["ChatDataContext"],
                Mvx.IoCProvider.Resolve<IAppdataService>()
            ));

            Mvx.IoCProvider?.RegisterType<IBotService, BotService>();
            RegisterAppStart<ChatsVM>();
        }
    }
}

using MvvmCross.ViewModels;
using VKTChat.Core.ViewModels;

namespace VKTChat.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<ChatsVM>();
        }
    }
}

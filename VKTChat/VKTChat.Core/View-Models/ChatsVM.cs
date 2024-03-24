using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System.Windows.Input;
using VKTChat.Core.Models;
using VKTChat.Core.Services;

namespace VKTChat.Core.ViewModels
{
    public class ChatsVM : MvxViewModel
    {
        private readonly IChatService _chatService;
        private readonly IMvxNavigationService _navigationService;
        public ChatsVM(IChatService chatService, IMvxNavigationService navigationService)
        {
            _chatService = chatService;
            _navigationService = navigationService;
        }
        private ICommand? _clickCommand;
        public ICommand ClickCommand =>
            _clickCommand ??= new MvxCommand(() =>
            {
                _navigationService.Navigate();
            });
    }
}

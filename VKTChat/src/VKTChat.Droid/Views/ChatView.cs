using Android.App;
using Android.OS;
using MvvmCross.Platforms.Android.Views;
using VKTChat.Core.ViewModels;

namespace VKTChat.Droid.Views
{
    [Activity(Label = "Chat", Theme = "@style/Theme.AppCompat")]
    public class ChatView : MvxActivity<ChatVM>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.ChatsView);
        }
    }
}

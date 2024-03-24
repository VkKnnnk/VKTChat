using MvvmCross.Platforms.Android.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VKTChat.Core.ViewModels;

namespace VKTChat.Droid.Views
{
    [Activity(Label = "Новый чат", Theme = "@style/Theme.AppCompat")]
    public class CreateChatView : MvxActivity<ChatCreateVM>
    {
        protected override void OnCreate(Bundle? bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.CreateChatView);
        }
    }
}

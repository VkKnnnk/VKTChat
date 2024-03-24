using Android.Runtime;
using MvvmCross.Platforms.Android.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VKTChat.Core;

namespace VKTChat.Droid
{
    [Application]
    public class MainApplication : MvxAndroidApplication<Setup, App>
    {
        public MainApplication(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {
        }
    }
}

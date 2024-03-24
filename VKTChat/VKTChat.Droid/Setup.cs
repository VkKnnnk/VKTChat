using Microsoft.Extensions.Logging;
using MvvmCross.Platforms.Android.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VKTChat.Core;

namespace VKTChat.Droid
{
    public class Setup : MvxAndroidSetup<App>
    {
        protected override ILoggerFactory? CreateLogFactory() => default!;
        protected override ILoggerProvider? CreateLogProvider() => default!;
    }
}

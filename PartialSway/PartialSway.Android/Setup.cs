using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Platforms.Android.Core;
using MvvmCross.ViewModels;

namespace PartialSway.Droid
{
    public class Setup : MvxAndroidSetup
    {
        public Setup() : base()
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new BaseApp();
        }

    }
}
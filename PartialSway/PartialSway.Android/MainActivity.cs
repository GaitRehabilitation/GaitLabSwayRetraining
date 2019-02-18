using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using MvvmCross.Forms.Platforms.Android.Views;
using MvvmCross.Forms.Platforms.Android.Core;

namespace PartialSway.Droid
{
    [Activity(Label = "PartialSway", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity :  MvxFormsAppCompatActivity<MvxFormsAndroidSetup<BaseApp, FormApp>, BaseApp, FormApp>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            //global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            //LoadApplication(new App());
        }
    }
}
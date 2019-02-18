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
using MvvmCross.Platforms.Android.Views;
using PartialSway.ViewModels;

namespace PartialSway.Droid.Views
{
    [Activity(Label = "View for ListViewModel")]
    public class SessionsView : MvxActivity<SessionsViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Sessions);
        }
    }
}
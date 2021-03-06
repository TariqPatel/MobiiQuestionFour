﻿using Android.App;
using Android.Content.PM;
using Android.OS;
using MvvmCross.Forms.Droid.Views;

namespace MVVM.Droid
{
    [Activity(Label = "FormsApplicationActivity",
              ScreenOrientation = ScreenOrientation.Portrait,
              LaunchMode = LaunchMode.SingleTask)]
    public class FormsApplicationActivity : MvxFormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            ToolbarResource = Resource.Layout.Toolbar;
            TabLayoutResource = Resource.Layout.Tabbar;

            base.OnCreate(bundle);
        }
    }
}
﻿using MvvmCross.Core.ViewModels;
using MvvmCross.Forms.iOS;
using MvvmCross.Forms.Platform;
using MvvmCross.Platform;
using MvvmCross.Platform.Logging;
using MvvmCross.Platform.Platform;
using Plugin.Settings;
using Plugin.Settings.Abstractions;
using UIKit;

namespace MVVM.iOS
{
    public class Setup : MvxFormsIosSetup
    {
        public Setup(MvxFormsApplicationDelegate applicationDelegate, UIWindow window)
            : base(applicationDelegate, window)
        {
        }

        protected override void InitializeFirstChance()
        {
            base.InitializeFirstChance();

            Mvx.RegisterSingleton<Core.Services.ILocalizeService>(() => new Services.LocalizeService());
            Mvx.RegisterSingleton<ISettings>(() => CrossSettings.Current);
        }

        protected override MvxLogProviderType GetDefaultLogProviderType() => MvxLogProviderType.None;

        protected override MvxFormsApplication CreateFormsApplication()
        {
            return new Core.FormsApp();
        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.MvxApp();
        }

        protected override IMvxTrace CreateDebugTrace()
        {
            return new Core.DebugTrace();
        }
    }
}

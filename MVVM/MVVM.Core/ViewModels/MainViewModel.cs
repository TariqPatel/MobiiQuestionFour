using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using Xamarin.Forms;

namespace MVVM.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public MainViewModel(IMvxNavigationService navigationService, Services.IAppSettings settings)
        {
            _navigationService = navigationService;
        }

        public IMvxAsyncCommand GoToSecondPageCommand =>
            new MvxAsyncCommand(async () => { await _navigationService.Navigate<SecondViewModel>(); });

        public IMvxCommand ChangeTitle =>
            new MvxCommand(() =>
            {
                IsFirstChecked = !IsFirstChecked;
                Title = IsFirstChecked ? "Im Changed!" : "Page 1";
            });

        public IMvxCommand ChangeBackground =>
            new MvxCommand(() =>
            {
                IsSecondChecked = !IsSecondChecked;
                Color = IsSecondChecked ? Color.Aqua : Color.White;
            });

        public IMvxCommand ChangeSecondBox =>
            new MvxCommand(() => { ChangeBackground.Execute(); });

        public bool IsFirstChecked;
        public bool IsSecondChecked;
        public bool IsThirdChecked = false;

        public string _title = "Page 1";

        public string Title
        {
            get => _title;
            set => _title = value;
        }

        public Color Color { get; set; }
    }
}
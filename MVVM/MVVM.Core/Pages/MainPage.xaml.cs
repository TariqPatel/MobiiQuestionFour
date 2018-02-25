using System;
using MvvmCross.Forms.Views;
using MVVM.Core.ViewModels;

namespace MVVM.Core.Pages
{
    public partial class MainPage : MvxContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            ThirdBox.Clicked += ClickedThirdBox;

        }

        private void ClickedThirdBox(object sender, EventArgs e)
        {
            SecondBox.SetCheckBox();
        }
    }
}

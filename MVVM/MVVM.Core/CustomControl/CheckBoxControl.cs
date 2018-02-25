using System;
using Xamarin.Forms;

namespace MVVM.Core.CustomControl
{
    public class CheckBoxControl : Button
    {
        public event EventHandler CheckBoxChecked;
        public bool IsChecked { get; set; }
        public bool UseCustomImage { get; set; }

        public void SetCheckBox()
        {
            IsChecked = !IsChecked;
            var eventHandler = CheckBoxChecked;
            eventHandler?.Invoke(sender: this, e: EventArgs.Empty);
        }
    }
}

using System;
using Android.Content;
using Android.Widget;
using MVVM.Core.CustomControl;
using MVVM.Droid.CustomRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CheckBoxControl), typeof(CheckBoxRenderer))]

namespace MVVM.Droid.CustomRenderers
{
    public class CheckBoxRenderer : ViewRenderer<CheckBoxControl, CheckBox>
    {
        private CheckBox _checkBox;

        public CheckBoxRenderer(Context context) : base(context)
        {
        }

        private void CheckBox_Click_Event(object sender, EventArgs e)
        {
            Element.SendClicked();
        }

        private void Check_CheckBox(object sender, EventArgs e)
        {
            _checkBox.Checked = Element.IsChecked;
        }

        protected override void OnElementChanged(ElementChangedEventArgs<CheckBoxControl> e)
        {
            base.OnElementChanged(e);

            if (Control == null)
            {
                _checkBox = new CheckBox(Context);
                SetNativeControl(_checkBox);
            }

            if (e.NewElement == null) return;

            if (e.NewElement.UseCustomImage)
            {
                _checkBox.SetButtonDrawable(Resource.Drawable.customImageCheck);
            }

            _checkBox.Click += CheckBox_Click_Event;
            e.NewElement.CheckBoxChecked += Check_CheckBox;
        }
    }
}